using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Sandbox Project.");
        Student student = new Student("Brigham", "234");
        string name = student.GetName();
        string number = student.GetNumber();
        Console.WriteLine(name);
        Console.WriteLine(number);
        // the student instance automatically has the GetName() method!
        /*Student student = new Student();
        string name = student.GetName();
        Console.WriteLine(name);*/
    }
}