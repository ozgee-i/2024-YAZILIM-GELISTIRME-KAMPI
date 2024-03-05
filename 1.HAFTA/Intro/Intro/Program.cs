
using Intro.Business;
using Intro.Entities;
using System.Diagnostics;
using System.Net.Http.Headers;

Console.WriteLine("Hello, World!");

string message = "Krediler";
int turm = 12;
double amount = 100000;

//variables --> camelCase
bool isAuthenticated = true;  //sisteme girmiş mi 


//condition
if (isAuthenticated)
{
    Console.WriteLine("Buton-->Hoşgeldiniz");
}
else 
{
    Console.WriteLine("Buton-->Sisteme giriş yapıldı");
}

string[] loans = { "Kredi 1 ", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5" , "Kredi 6" };
/*string[] loans2 = new string[6];
loans2[0] = "Kredi 1";*/

       //start    condition    increment
for (int i = 0; i <loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}



Course course1 = new Course();   //new demek referans oluşturmak demek
course1.Id =1;
course1.Name = "C# 2024 yazılım geliştirme kampı";
course1.Description =".NET 8 vs...";
course1.Price = 0;

Course course2 = new Course();  
course2.Id = 2;
course2.Name = "java kamp";
course2.Description = "java 17...";
course2.Price = 2000;

Course[] courses = { course1, course2 };

for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
}

Console.WriteLine("------------------");

CourseManager courseManager = new();
courseManager.GettAll();

Console.WriteLine("kod bitti");
