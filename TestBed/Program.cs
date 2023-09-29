using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            do
            {
                Console.Write("Enter number: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine(x);
            } while (x > 0);

            Console.WriteLine("DONE");
            Console.ReadKey();

        }
    }
}
