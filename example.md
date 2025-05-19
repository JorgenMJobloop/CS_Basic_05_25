# Examples

# When creating new Console Applications in C#
```sh
dotnet new console --use-program-main

# for unit tests

dotnet new xunit
```

# using the string[] args command-line parser
```cs
class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        if (args.Length == 0)
        {
            throw new Exception("No arguments was passed to the compiler!");
        }
        Console.WriteLine("Hello, would you like to tell me a little about yourself?");
        person.Name = args[0];
        person.Age = Int32.Parse(args[1]);
        person.Birthday = DateTime.Parse(args[2]);
        person.Greeting();
    }
}
```

# using a constructor
```cs
public class Person
{
    public string? Name;
    public int Age;
    public DateTime Birthday;
    public List<string>? Hobbies;

    public Person(string name, int age, DateTime birthday, List<string> hobbies)
    {
        Name = name;
        Age = age;
        Birthday = birthday;
        Hobbies = hobbies;
    }

    /// <summary>
    /// A greeting method, that prints out information provided by our user.
    /// </summary>
    public void Greeting()
    {
        if (Hobbies == null || Hobbies.Count == 0)
        {
            Console.WriteLine($"Hello {Name}. You are {Age} years old!\nYour birthday is {Birthday}, and you have no hobbies currently listed!");
            return;
        }

        string _hobbies;

        if (Hobbies.Count == 1)
        {
            _hobbies = Hobbies[0];
        }
        else
        {
            _hobbies = string.Join(", ", Hobbies.Take(Hobbies.Count - 1)) + " & " + Hobbies.Last();
        }

        Console.WriteLine($"Hello {Name}! You are {Age} old.\nAnd your birthday is {Birthday}.\nAnd your hobbies are {_hobbies}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("John Doe", 30, DateTime.Parse("22.02.1990"), ["Programming", "Gaming", "Ethical hacking"]);
        person.Greeting();
    }
}

```