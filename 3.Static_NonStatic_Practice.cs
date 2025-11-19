using System;

class Student

{ 

    //non static fields//
    public string name;
    public int [] marks;

    public static int totalStudents = 0;  //static field(public)//

    //Non static method//
    public void CalculateAverage()
    {
        int sum = 0;
        for (int i = 0; i < marks.Length; i++)
        {
            sum += marks[i];
        }
        double average = (double)sum / marks.Length;
        Console.WriteLine($"{name}'s average marks: {average}");
    }
    public static void ShowTotalStudents()    //static method//
    {
        Console.WriteLine($"Total Students: {totalStudents}");
    }
    public void ShowDetails()  //non static method//
    {
        Console.WriteLine($"Student Name:{name}");
        Console.WriteLine("Marks:  ");
        foreach (int m in marks)
        {
            Console.Write(m + " ");
        }
        Console.WriteLine();
    }
    public static void IncreaseStudentCount()     //static method to increase count//
    {
        totalStudents++;
    }
}

        class Program
    {
        static void Main()
        {
            Student s1 = new Student();
            s1.name = "Alice";
            s1.marks = new int [] { 78, 90, 87 };
            Student.IncreaseStudentCount();
            Student s2 = new Student();
            s2.name = "Bob";
            s2.marks = new int [] { 90, 98, 72 };

            s1.ShowDetails();
            s1.CalculateAverage();     //non static method called by object//

            s2.ShowDetails();
            s2.CalculateAverage();
            Student.ShowTotalStudents();   //it is nonstatic method called by classname without object//


        }
    }


        
    

