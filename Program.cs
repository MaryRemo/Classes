using System;
using System.Collections.Generic;

public class Employee
{
    public string FirstName { get; set;}
    public string LastName { get; set;}
    public string Title { get; set; }
    public DateTime StartDate { get; set;}
}
public class Company
{
    public string Name { get;}
    public DateTime CreatedOn { get;}

    public List<Employee> Employees {get; set;}
    // Create a public property for holding a list of current employees

    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */

    public Company(string name, DateTime createdOn) {
        Name = name;
        CreatedOn = createdOn;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of a company. Name it whatever you like.

        Company newCompany = new Company("WaterBurger", new DateTime(2019, 4, 12));

        // Create three employees
         Employee John = new Employee()
            {
                FirstName = "John",
                LastName = "Heimer-Schmit",
                Title = "Assistant",
                StartDate = new DateTime(2019, 4, 12),
            };
        Employee Jacob = new Employee()
            {
                FirstName = "Jacob",
                LastName = "Heimer-Schmitt",
                Title = "Assistant",
                StartDate = new DateTime(2019, 4, 12),
            };
         Employee Jingle = new Employee()
            {
                FirstName = "Jingle",
                LastName = "Heimer-Schmit",
                Title = "Assistant",
                StartDate = new DateTime(2019, 4, 12),
            };
        newCompany.Employees = new List<Employee>();
        // Assign the employees to the company
        newCompany.Employees.Add(John);
        newCompany.Employees.Add(Jacob);
        newCompany.Employees.Add(Jingle);

        /*
            Iterate the company's employee list and generate the
            simple report shown above
        */
    newCompany.Employees.ForEach(employee => {
        Console.WriteLine ($"{employee.FirstName} {employee.LastName} works for {newCompany.Name} as an {employee.Title} since {employee.StartDate}");
    }
    );
    {
        
    }
    }
}