using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace StaticKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileString = "function FunctionName(defaultData){\n";

            Type[] typelist = GenerateFile.GetTypesInNamespace(Assembly.GetExecutingAssembly(), "StaticKeyword");
            foreach (var type in typelist)
            {
                // Get the public properties.
                PropertyInfo[] propInfos = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
              
                //DisplayPropertyInfo(propInfos);

                
                fileString += WritePropertyInfo(propInfos);
            }

            fileString += "}";
            // now create a js file
            CreateFile(fileString);
        }

        public static string WritePropertyInfo(PropertyInfo[] propInfos)
        {
            string body = "";
            // Display information for all properties.
            foreach (var propInfo in propInfos)
            {
                var defaultValue = SetDefaultValue(propInfo.PropertyType);
                body += $"this.{ConvertToCamelCase(propInfo.Name)} : defaultData.{propInfo.Name} | {defaultValue};\n";
            }
            return body;
        }

        public static void CreateFile(string body)
        {
            string path = @"F:\ClassName.js";

            try
            {

                WriteFile(path, body);
                ReadFile(path);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void WriteFile(string path,string body)
        {
            try
            {


                // Create the file, or overwrite if the file exists.
                using (FileStream fs = File.Create(path, 1024))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(body);
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void ReadFile(string path)
        {
            try
            {

                // Open the stream and read it back.
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

     




        public static void DisplayPropertyInfo(PropertyInfo[] propInfos)
        {
            // Display information for all properties.
            foreach (var propInfo in propInfos)
            {
                bool readable = propInfo.CanRead;
                bool writable = propInfo.CanWrite;

                Console.WriteLine(" Property name: {0}", propInfo.Name);
                Console.WriteLine(" Property type: {0}", propInfo.PropertyType);
                Console.WriteLine(" Read-Write:    {0}", readable & writable);
                if (readable)
                {
                    MethodInfo getAccessor = propInfo.GetMethod;
                    Console.WriteLine("   Visibility:    {0}", GetVisibility(getAccessor));
                }
                if (writable)
                {
                    MethodInfo setAccessor = propInfo.SetMethod;
                    Console.WriteLine("   Visibility:    {0}", GetVisibility(setAccessor));
                }
                Console.WriteLine();
            }
        }

        public static string ConvertToCamelCase(string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0)
                    result = result.Append(Char.ToLower(str[i]));
                else
                    result = result.Append(str[i]);
            }
            return result.ToString();
        }

        public static string SetDefaultValue(Type type)
        {

            string result = null;

            switch (type.Name)
            {
                case "Int16":
                    result = "0";
                    break;
                case "Int32":
                    result = "0";
                    break;
                case "Int64":
                    result = "0";
                    break;
                default:
                    result = "null";
                    break;
            }
            
            return result;
        }
      

        public static String GetVisibility(MethodInfo accessor)
        {
            if (accessor.IsPublic)
                return "Public";
            else if (accessor.IsPrivate)
                return "Private";
            else if (accessor.IsFamily)
                return "Protected";
            else if (accessor.IsAssembly)
                return "Internal/Friend";
            else
                return "Protected Internal/Friend";
        }
}
}
