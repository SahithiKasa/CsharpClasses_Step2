using System;

class Employee
{
    // Static field
    public static int TotalEmployees;

    // Properties
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }

    // Static Constructor
    static Employee()
    {
        TotalEmployees = 0;
        Console.WriteLine("Static Constructor: Running only once...");
    }

    // Default Constructor
    public Employee()
    {
        Id = 0;
        Name = "Not Assigned";
        Salary = 0;
    }

    // Parameterized Constructor
    public Employee(int id, string name, double salary) : this()   // calling default constructor
    {
        if (salary < 0)
        {
            throw new Exception("Salary cannot be negative!");
        }

        Id = id;
        Name = name;
        Salary = salary;

        TotalEmployees++;
    }

    // Method to print details
    public void Print()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Salary: {Salary}");
    }
}

class Program2
{
    static void Main()
    {
        Employee e1 = new Employee(101, "Arun", 45000);
        Employee e2 = new Employee(102, "Sahithi", 55000);

        e1.Print();
        e2.Print();

        Console.WriteLine("Total Employees: " + Employee.TotalEmployees);
    }
}
