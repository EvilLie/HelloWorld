using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffBetweenWritelnAndWriteConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("With Console.Write");
            Console.Write("Hello ");
            Console.Write(" World ");
            Console.Write(" !!!");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("With Console.WriteLine");
            Console.WriteLine("Hello");
            Console.WriteLine("World");
            Console.WriteLine("!!!");
            Console.ReadLine();
        }
    }
}
