using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello, World!!!";
            Console.WriteLine($"{a}");
            Console.WriteLine("Hello, World!!!");
            Console.WriteLine("{0}",a);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
