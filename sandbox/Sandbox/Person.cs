
// a parent class called Person
public class Person
{
    private string _name;

    public Person(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }
}

// a class that inherits from Person
/*public class Student : Person
{
    public string GetNumber()
    {
        return "0123456789";
    }
}*/
