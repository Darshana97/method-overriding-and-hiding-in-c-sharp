using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overriding_and_hiding
{

    class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("Base class");
        }
    }

    class DerivedClass : BaseClass
    {
        //method hiding
        /* public new void Print()
         {
             Console.WriteLine("Derived Class");
         }*/

        //method overriding
        public override void Print()
        {
            Console.WriteLine("Derived Class");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BaseClass B = new DerivedClass();
            B.Print();
            Console.ReadLine();
        }

    }
}
