using System;

public class Student1
{
    // Public Properties
    public string Name { get; set; }
    public int Marks { get; set; }
    public string Course { get; set; }

    // ================================
    // METHOD 1: To set details
    // ================================
    public void SetDetails(string name, int marks, string course)
    {
        Name = name;
        Marks = marks;
        Course = course;
    }

    // ================================
    // METHOD 2: To display student details
    // ================================
    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Marks: {Marks}, Course: {Course}");
    }

    // ================================
    // METHOD 3: Check pass/fail
    // ================================
    public string CheckResult()
    {
        if (Marks >= 35)
            return "Pass";
        else
            return "Fail";
    }

    // ================================
    // METHOD 4: Grade based on marks
    // ================================
    public string GetGrade()
    {
        if (Marks >= 90)
            return "A+";
        else if (Marks >= 75)
            return "A";
        else if (Marks >= 60)
            return "B";
        else if (Marks >= 35)
            return "C";
        else
            return "Fail";
    }
}

public class Program1
{
    public static void Main()
    {
        // Create array of Student objects
        Student1[] students = new Student1[3];

        // Initialize array
        students[0] = new Student1();
        students[1] = new Student1();
        students[2] = new Student1();

        // Set details using METHOD 1
        students[0].SetDetails("Sahithi", 95, "C#");
        students[1].SetDetails("Farid", 72, "Java");
        students[2].SetDetails("Arun", 30, "Python");

        // Display all students
        Console.WriteLine("=== Student Details ===");
        foreach (var stu in students)
        {
            stu.DisplayDetails();

            // Call METHOD 3 and METHOD 4
            Console.WriteLine("Result: " + stu.CheckResult());
            Console.WriteLine("Grade: " + stu.GetGrade());
            Console.WriteLine();
        }
    }
}
