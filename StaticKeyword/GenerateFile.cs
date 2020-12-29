using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace StaticKeyword
{
    public class GenerateFile
    {

        public static Type[] GetTypesInNamespace(Assembly assembly, string nameSpace)
        {
            var x = assembly.GetTypes()
                      .Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal))
                      .ToArray();

            //for (int i = 0; i < x.Length; i++)
            //{
            //  //  x[i].DeclaringType
            //    PropertyInfo[] myPropertyInfo;
            //    // Get the properties of 'Type' class object.

            //    //Type T = x[i].BaseType;
            //    myPropertyInfo = T.GetType().GetProperties();
            //    Console.WriteLine("Properties of System.Type are:");
            //    for (int j = 0; j < myPropertyInfo.Length; j++)
            //    {
            //        Console.WriteLine(myPropertyInfo[i].ToString());
            //    }

            //    Console.WriteLine(x[i].Name);
            //}



            return x;

        }
    }
}
