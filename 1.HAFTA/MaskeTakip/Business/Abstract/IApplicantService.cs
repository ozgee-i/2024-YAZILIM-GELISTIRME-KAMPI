using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        void ApplyForMask(Person person);

        List<Person> GetList();

        bool CheckPerson(Person person);     //mernis den kontrol sağlayacak

    }
}
/*
 interfaceler başka methot imzalarını barındırırlar. 
Birbirinin alternatifi olan sistemlerin farklı implemantasyon yapmalarını sağlar 
yani yabancı uyruklu ve türk olanlar farklı olur

*/