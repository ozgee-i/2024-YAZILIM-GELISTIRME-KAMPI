using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManager
{
    Course[] courses =new Course[2];
    //constructor bloğu çalışır ilk new olduğu zaman 
    public CourseManager()   //new olduğu zaman çalışr
    {
       
        Console.WriteLine("başladı");
        Course course1 = new Course();   //new demek referans oluşturmak demek
        course1.Id = 1;
        course1.Name = "C# 2024 yazılım geliştirme kampı";
        course1.Description = ".NET 8 vs...";
        course1.Price = 0;

        Course course2 = new Course();
        course2.Id = 2;
        course2.Name = "java kamp";
        course2.Description = "java 17...";
        course2.Price = 2000;

        courses[0] = course1;
        courses[1] = course2;

    }
    public Course[] GettAll()  //methot 
    {   //veri kaynağından çekilir...
        return courses;
    }
}
