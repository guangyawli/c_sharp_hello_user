using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloword
{
    class Program
    {
        static void Main(string[] args)
        {
            string stry = "",xx="";
            string strx = " Your name： \n";

            string s = "Hello";

            Console.Write("Please enter");
            Console.Write($"{strx}");

            stry = Console.ReadLine();

            Console.Clear();

            Console.WriteLine(" {0},{1} ", s, stry);

            Console.WriteLine("按任意鍵離開");
            Console.ReadKey();

        }
    }
}
