using System;

namespace Value_ReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueType vt;
            vt = new ValueType();

            ReferenceType rt;
            rt = new ReferenceType();
            
        }


        public class ValueType
        {
            public ValueType()
            {
                int i = 100;

                Console.WriteLine(i);

                ChangeValue(i);

                Console.WriteLine(i);
            }
            static void ChangeValue(int x)
            {
                x = 200;

                Console.WriteLine(x);
            }
            
        }

        public class ReferenceType
        {
            public ReferenceType()
            {
                Student std1;
                std1 = new Student();
                std1.StudentName = "Bill";
                Console.WriteLine($"Old Value : {std1.StudentName}");
                ChangeReferenceType(std1);
                Console.WriteLine($"New Value : {std1.StudentName}");
            }
            static void ChangeReferenceType(Student std2)
            {
                std2.StudentName = "Steve";
            }
        }


        private class Student
        {
            public string StudentName { get; set; }
        }

    }
}
