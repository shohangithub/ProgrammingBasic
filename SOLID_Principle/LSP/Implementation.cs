using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principle.LSP
{
    public class Implementation
    {
        public abstract class Fruit
        {
            public abstract string GetColor();
        }
        public class Apple : Fruit
        {
            public override string GetColor()
            {
                return "Red";
            }
        }
        public class Orange : Fruit
        {
            public override string GetColor()
            {
                return "Orange";
            }
        }
    }
}
