using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace StrongNameVerification
{
    class Program
    {
        static void Main(string[] args)
        {
            var class1 = new Class1();
            Console.WriteLine(class1.TestReturn());
        }
    }
}
