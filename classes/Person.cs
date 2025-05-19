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