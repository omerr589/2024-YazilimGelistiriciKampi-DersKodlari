using Intro.Business;
using Intro.DataAcess.Concrete;
using Intro.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        CourseManager courseManager = new CourseManager(new CourseDal());

        List<Course> courses = courseManager.GetAll();

        foreach (Course course in courses)
        {
            Console.WriteLine(course.Name + " " + course.Price);
        }

        CourseManager courseManager2 = new CourseManager(new EfCourseDal());

        List<Course> courses2 = courseManager2.GetAll();

        foreach (Course course2 in courses2)
        {
            Console.WriteLine(course2.Name + " " + course2.Price);
        }

        // Polymorphism();
    }

    private static void Polymorphism()
    {
        IndividualCustomer customer1 = new IndividualCustomer();
        customer1.Id = 1;
        customer1.NationalIdentity = "12345678910";
        customer1.FirstName = "Ömer Faruk";
        customer1.Lastname = "0123456";
        customer1.CustomerNumber = "7654321";

        IndividualCustomer customer2 = new IndividualCustomer();
        customer2.Id = 2;
        customer2.NationalIdentity = "98765432190";
        customer2.FirstName = "Özgür";
        customer2.Lastname = "Atılgan";
        customer2.CustomerNumber = "1234567";

        CorprateCustomer customer3 = new CorprateCustomer();
        customer3.Id = 3;
        customer3.Name = "Kodlama.io";
        customer3.CustomerNumber = "1425360";
        customer3.TaxNumber = "123456789";

        CorprateCustomer customer4 = new CorprateCustomer();
        customer4.Id = 4;
        customer4.Name = "ABC";
        customer4.CustomerNumber = "0654321";
        customer4.TaxNumber = "987654321";

        BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

        foreach (BaseCustomer customer in customers)
        {
            if (customer is IndividualCustomer)
            {
                Console.WriteLine("Identity: " + ((IndividualCustomer)customer).NationalIdentity);
            }
            else if (customer is CorprateCustomer)
            {
                Console.WriteLine("Identity: " + ((CorprateCustomer)customer).TaxNumber);
            }
            Console.WriteLine("Name: " + customer.CustomerNumber);
        }
    }
}

