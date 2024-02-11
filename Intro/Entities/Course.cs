using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Entities;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }


    public Course() 
    {

    }

    public Course(int id, string name, string description, double price) 
    {
        Id = id;
        Name = name;
        Description = description;
        Price = price;
    }
}
