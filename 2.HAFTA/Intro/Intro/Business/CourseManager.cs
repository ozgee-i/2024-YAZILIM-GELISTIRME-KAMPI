﻿using Intro.DataAccess.Abstracts;
using Intro.DataAccess.Concretes;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManager   //operasyon tutucu sınıf
{
    //dependency injection
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GettAll()  //methot 
    {   //business rules   
        return _courseDal.GetAll();
    }

    internal List<Course> GetAll()
    {
        throw new NotImplementedException();
    }
}
  
