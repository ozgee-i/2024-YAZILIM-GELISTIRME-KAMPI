
using Intro.Business;
using Intro.DataAccess.Concretes;
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

CourseManager courseManager = new(new EfCourseDal());

List<Course> courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}


Console.WriteLine("kod bitti");

Console.WriteLine("---------------------------------------------------------------------------");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678912";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "12345678944";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123789";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlama.io";
customer3.CustomerNumber = "456789";
customer3.TaxNumber = "1234567891";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 3;
customer4.Name = "abc";
customer4.CustomerNumber = "456712";
customer4.TaxNumber = "1234567845";

BaseCustomer[] customers = {customer1,customer2,customer3,customer4 };
//polymorphism
foreach (BaseCustomer customer in customers)
{    
    Console.WriteLine(customer.CustomerNumber);
}


