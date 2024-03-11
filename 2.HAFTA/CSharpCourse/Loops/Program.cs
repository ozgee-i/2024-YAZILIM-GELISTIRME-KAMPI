using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhiteLoop();
            //DoLoop();

            if (IsPrimeNumber(7))
            {
                Console.WriteLine("This is a prime number");

            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }

            Console.ReadLine();
        }
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number%i==0)
                {
                    result = false;
                    i = number;  // döngüyü kırar
                }
            }
            return result;
        }

        private static void ForLoop()
        {
            for (int i = 1; i <= 100; i += 2)  //i=i+2 ile i+=2 ayndır   (int i = 100; i <= 0; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");
        }

        private static void WhiteLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0} ", number);
        }

        private static void DoLoop()
        {
            int number = 10;
            do
            {    //şart sağlanmasa bile döngüye girer
                Console.WriteLine(number);
                number--;
            } while (number > 11);
        }

        private static void ForEachLoop()
        {
            string[] students = new string[3] { "engin", "derin", "salih" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
