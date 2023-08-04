using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int number = int.Parse(Console.ReadLine());
            if (MySharedLibrary.MyUtility.IsPrime(number))
                Console.WriteLine($"{number} is a prime number.");
            else
                Console.WriteLine($"{number} is not a prime number.");
            Console.ReadKey();
        }
    }
}
