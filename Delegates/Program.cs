using System;

namespace Delegates
{
    class Program
    {
        // public delegate int FunctionDelegate(int a, int b);
        static void Main(string[] args)
        {

            #region Simple Implementation
            //FunctionDelegate del = new FunctionDelegate(Method);
            FunctionDelegate del = Method;

            //del(2, 2);
            //del.Invoke(2, 2);



            Console.WriteLine(del(2, 2));

            //as a function parameter 
            Console.WriteLine(Marks(del));

            #endregion


            #region Multicast Implementation

            //   Mutlticast implementation with void return type  

            TestMutliCast delmultiCast = Method1;
            delmultiCast += Method2;
            delmultiCast();



            // Mutlticast implementation with int return type  

            TestMutliCastint intMulti = Method3;
            intMulti += Method4;
            intMulti += Method5;
            int i = intMulti();

            Console.WriteLine("Return Value is " + i);

            #endregion

        }


        #region Simple Delegate
        // Defines delegate
        public delegate int FunctionDelegate(int a, int b);


        // Defines method to which the delegate can point.
        private static int Method(int a, int b)
        {
            return a + b;
        }


        //public int GPA(Method() x)
        public static int Marks(FunctionDelegate paramDel)
        {
            int Mid = 15;
            int Final = 40;

            return paramDel(Mid, Final);
        }

        #endregion

        #region Multicast Delegate
        public delegate void TestMutliCast();
        public delegate int TestMutliCastint();
        public static void Method1()
        {
            Console.WriteLine("Delegate 1st method called!!!!");
        }

        public static void Method2()
        {
            Console.WriteLine("Delegate 2nd method called!!!!");
        }

        public static int Method3()
        {
            Console.WriteLine("Delegate 3rd method called!!!!");
            return 3;
        }

        public static int Method4()
        {
            Console.WriteLine("Delegate 4th method called!!!!");
            return 4;
        }
        public static int Method5()
        {
            Console.WriteLine("Delegate 5th method called!!!!");
            return 5;
        }

        public static void getName(string name)
        {
            Console.WriteLine("My Name: " + name);
        }

        public static void getLocation(string location)
        {
            Console.WriteLine("My Loc: " + location);
        }
        #endregion


    }


}
