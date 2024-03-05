
using Business.Concrete;
using Entities.Concrete;

Console.WriteLine("Hello, World!");

//Arrays

string[] ogrenciler = new string[3];  
ogrenciler[0]= "engin";
ogrenciler[1]= "kerem";
ogrenciler[2]= "berkay";

for (int i = 0; i < ogrenciler.Length; i++)  //i=i+1
{
    Console.WriteLine(ogrenciler[i]);
}


string[] sehirler1 = new[] { "ANKARA ", "İSTANBUL", "İZMİR" };
foreach (string sehir in sehirler1)  //sehir takma isim istediğin adı verebilirsin
{
    Console.WriteLine(sehir);
}


List<string>  yeniSehirler1= new List<string> { "ankara 1","izmir 1","istanbul 1"};
yeniSehirler1.Add(item:"Adana 1");
foreach (var sehir in yeniSehirler1) 
{
    Console.WriteLine(sehir);
}

Person person1 = new Person();
person1.FirstName = "özge";
person1.LastName = "irhan";
person1.DateOfBirthYear = 1999;
person1.NationalIdentity = 123;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

//PttManager pttManager = new PttManager(new PersonManager());

/*array,class, abstrack bunlar referans tiplerdir
int double bool bunlar değer tiplerdir yani stack üzerinden gider
stack ve heap kısımlarından oluşur

int s1=10;
int s2=20;
s2=s1;
s1=30;
Console.WriteLine(s2);

string[] sehirler1=new [] {"ANKARA ","İSTANBUL","İZMİR"};
string[] sehirler2=new [] {"Bursa ","Antalya","Diyarbakır"};
sehirler2=sehirler1;
sehirler1[0]="Adana";
Console.WriteLine(sehirler2[0]);
*/