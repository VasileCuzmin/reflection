namespace Demo.Console;

interface ITalk
{
    void Talk(string sentence);
}

class EmployeeMarkerAttribute : Attribute
{
}

class Employee : Person
{
    public string Company { get; set; }
}

public class Person : ITalk
{
    public string Name { get; set; }
    public int age;
    private string _aPrivateField = "private field";

    public Person()
    {
        System.Console.WriteLine("A person is being created");
    }

    public Person(string name)
    {
        System.Console.WriteLine($"A person with {name} is being created");
        Name = name;
    }

    private Person(int age, string name)
    {
        System.Console.WriteLine($"A person with {name} and {age} is being created");
        this.age = age;
        Name = name;
    }

    public void Talk(string sentence)
    {
        System.Console.WriteLine($"talking...{sentence}");
    }

    protected void Yell(string sentence)
    {
        System.Console.WriteLine($"yelling...{sentence}");
    }

    public override string ToString()
    {
        return $"{Name} {age} {_aPrivateField}";
    }
}

class Alien : ITalk
{
    public void Talk(string sentence)
    {
        System.Console.WriteLine($"Alien talking...{sentence}");
    }
}