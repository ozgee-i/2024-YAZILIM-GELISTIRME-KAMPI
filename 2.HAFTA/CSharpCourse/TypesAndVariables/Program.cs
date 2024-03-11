using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //value types
            Console.WriteLine("HELLO WORLD!");            
            decimal number6 =25.9m;  //daha hassas hesaplamalar için virgülden sonra daha fazla değer tutar
            double number5 = 10.4;
            char character = 'A';    //değer tip
            bool condation = true;    //mantıksal değer tipi true veya false
            byte number4 = 0;         //8 bit yer tutar  0-255  değer tip
            short number3 = -32768;  //16 bit yer tutar   değer tip
            int number1 = 2147483647;   //32 bit yer tutar   değer tip
            long number2 = 2147483648;  //64 bit yer tutar   değer tip
            var number7 = 10;
            number7 = 'A';
          
            Console.WriteLine("Number1 is {0} ",number1);
            Console.WriteLine("Number2 is {0} ", number2);
            Console.WriteLine("Number3 is {0} ", number3);            
            Console.WriteLine("Number4 is {0} ", number4);
            Console.WriteLine("Number5 is {0} ", number5);
            Console.WriteLine("Number6 is {0} ", number6);
            Console.WriteLine("Character is {0} ", character);
            Console.WriteLine("Character is {0} ", (int)character);  //characterin sayısal karşılığını bize verir
            Console.WriteLine((int)Days.Friday);
            Console.WriteLine("Number7 is {0} ", number7);

            Console.ReadLine();
        }
        enum Days
        {
            Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday   //başlangıç değerlerini değiştirebilirsin Monday=10 gibi
        }
    }
}
