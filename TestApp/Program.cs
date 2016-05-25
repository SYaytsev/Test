using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeClass.SomeAction1();
            SomeClass.SomeAction2();
            LastAction();
            Console.ReadLine();
        }

        static void LastAction()
        {
            Console.WriteLine("Last Action");
        }
    }
}
