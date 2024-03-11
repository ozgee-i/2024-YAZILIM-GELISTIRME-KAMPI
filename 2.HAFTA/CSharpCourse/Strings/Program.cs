using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Engin Demiroğ";
            var result =sentence.Length;

            var result2=sentence.Clone();  //string değerinin referansın oluşturur 
            sentence = "My name is Derin Demiroğ"; 

            bool result3 = sentence.EndsWith("ğ");  //bittiği
            bool result4 = sentence.StartsWith("My name");  //başladığı

            var result5 = sentence.IndexOf("name");  //metin içinde arama
            var result6 = sentence.IndexOf(" ");  //bulduğu ilk boşluğu sayar
            var result7 = sentence.LastIndexOf(" "); //aramaya sondan başlar

            var result8 = sentence.Insert(0, "Hello");  //yeni bir şey ekler
            var result9=sentence.Substring(3); //şuradan başla şu kadar al  3,4

            var result10 = sentence.ToLower(); //küçük  harfe çevirir
            var result11 = sentence.ToUpper(); //büyük harfe çevirir

            var result12 = sentence.Replace(" ", " -");  //değiştirme işlemi yapar
            var result13 = sentence.Remove(2);  //2 den itibaren sil veya şu kadar sil  2,5

            Console.WriteLine(result9);
            Console.ReadLine();
        }

        public static void Intro()
        {
            string city1 = "Ankara";
            //Console.WriteLine(city[0]);
            foreach (var item in city1)
            {
                Console.WriteLine(item);
            }

            string city2 = "istanbul";
            string result = city1 + city2;
            Console.WriteLine(result);
            Console.WriteLine("{0},{1}", city1, city2);   //String.Format()
        }
    }
}
