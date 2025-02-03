
// a child class called Student
public class Student : Person
{
    private string _number;

    // calling the parent constructor using "base"!
    public Student(string name, string number) : base(name)
    {
      _number = number;
    }

    public string GetNumber()
    {
        return _number;
    }
}


// a regular class called Person
/*public class Person
{
    public string GetName()
    {
        return "Joseph";
    }
}*/
