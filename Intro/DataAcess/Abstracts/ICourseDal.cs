using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAcess.Abstracts;

public interface ICourseDal
{
    // Bu interface'i implemente eden sınıflar bu methodları içermelidir
    List<Course> GetAll(); // Collection

    void Add(Course course);
}
