using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManager
{

    Course[] courses = new Course[3];
    public CourseManager()
    {
        Course course1 = new Course(1, "C#", ".NET 8", 0);
        Course course2 = new Course(2, "Python", "Python 3.12", 1000);
        Course course3 = new Course(3, "Java", "Java 17", 3000);

        courses[0] = course1;
        courses[1] = course2;
        courses[2] = course3;
    }

    public Course[] GetAll() // Method
    {
        for (int i = 0; i < courses.Length; i++)
        {
            Console.WriteLine("Course: " + courses[i].Name + " / " + courses[i].Price);
        }

        return courses;
    }
}
