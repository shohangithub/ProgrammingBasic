﻿using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            // int is the type argument
            GenericList<int> list = new GenericList<int>();
            for (int x = 0; x < 10; x++)
            {
                list.AddHead(x);
            }
            foreach (int i in list)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine("\nDone");

            YieldKeyword.Consumer();
        }
    }
}
