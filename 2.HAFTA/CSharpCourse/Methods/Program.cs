using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Add();
            //var result = Add2(5, 3);

            //int n1 = 20;
            //int n2 = 100;
            //var result2 = Add3(n1 , n2);
            //Console.WriteLine(result2);
            //Console.WriteLine(n1);

            //Console.WriteLine(Multiply(2, 4));
            //Console.WriteLine(Multiply(2, 4, 5));

            Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));

            Console.ReadLine();

        }

        static void Add()
        {
            Console.WriteLine("Added!!!");
        }

        static int Add2(int n1, int n2)   //n2=30 denirse değer verilmezse 30 kabul eder
        {
            var result = n1 + n2;
            return result;
        }

        static int Add3(int n1, int n2)
        {
            n1 = 30;
            return n1 + n2;
        }
        //değer tiplerinin referans tip gibi kullanmak için ref kullanırız veya out kullanırız. ref de mutlaka set edilmesi gerekiyor

        static int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }
        static int Multiply(int n1, int n2, int n3)
        {
            return n1 * n2 * n3;
        }

        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
