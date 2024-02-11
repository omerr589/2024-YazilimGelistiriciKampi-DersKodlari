using Intro.DataAcess.Abstracts;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAcess.Concrete;


// Dal -> Data Acess Layer
public class CourseDal : ICourseDal
{
    List<Course> courses;

    public CourseDal()
    {
        Course course1 = new Course(1, "C#", ".NET 8", 0);
        Course course2 = new Course(2, "Python", "Python 3.12", 1000);
        Course course3 = new Course(3, "Java", "Java 17", 3000);

        courses = new List<Course> { course1, course2, course3 };
    }

    public List<Course> GetAll() // Collection
    {
        // Burada DB işlemleri yapılır
        return courses;
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }

}
