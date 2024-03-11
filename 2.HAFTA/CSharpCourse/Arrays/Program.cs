using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";

            string[] students2 = { "engin", "derin", "salih" };


            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("------------------------");


            string[,] reglons = new string[5, 3]  //7satır 3 sütun
            {
                {"istanbul","izmit","balıkesir" },
                  {"ankara","konya","kırıkkale" },
                    {"antalya","adana","mersin" },
                      {"rize","trabzon","samsun" },
                        {"izmir","muğla","manisa" },

            };
            for (int i = 0; i <= reglons.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= reglons.GetUpperBound(1); j++)
                {
                    Console.WriteLine(reglons[i, j]);
                }
                Console.WriteLine("*******************");
            }



            Console.ReadLine();
        }
    }
}
