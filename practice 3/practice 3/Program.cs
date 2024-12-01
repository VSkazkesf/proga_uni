public class Person
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Introduce()
    {
        Console.WriteLine($"Hello, I am {name} and I am {age} years old.");
    }
}

class Program
{
    static void Main()
    {
        Person person1 = new Person("John", 25);
        person1.Introduce();

        Person person2 = new Person("Mari", 6);
        person2.Introduce();
    }
}