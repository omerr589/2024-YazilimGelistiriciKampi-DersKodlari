using Intro.DataAcess.Abstracts;
using Intro.Entities;

namespace Intro.DataAcess.Concrete;

public class EfCourseDal : ICourseDal
{
    List<Course> courses;

    public EfCourseDal()
    {
        // Bu DB'den Gelecek
        Course course1 = new Course(1, "JavaScript", ".NET 8", 0);
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
