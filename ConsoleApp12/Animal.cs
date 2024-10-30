public class Animal
{
    // Egenskaper
    public string Name { get; set; }
    public int Age { get; set; }
    public string Species { get; set; }
    public double Weight { get; set; }
    public string Habitat { get; set; }

    // Konstruktor med standardvärden
    public Animal(string name = "Unknown", int age = 0, string species = "Unknown", double weight = 0.0, string habitat = "Unknown")
    {
        Name = name;
        Age = age;
        Species = species;
        Weight = weight;
        Habitat = habitat;
    }

    // Metoder
    public virtual void MakeSound()
    {
        Console.WriteLine($"{Name} makes a sound.");
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping.");
    }
}

// Första djurklass: Hund
public class Dog : Animal
{
    public string Breed { get; set; }

    public Dog(string name, int age, string breed, double weight, string habitat)
        : base(name, age, "Dog", weight, habitat)
    {
        Breed = breed;
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says Woof!");
    }

    public void Fetch()
    {
        Console.WriteLine($"{Name} is fetching a ball.");
    }
}

// Underklass av Hund: Bulldog
public class Bulldog : Dog
{
    public string Color { get; set; }

    public Bulldog(string name, int age, double weight, string habitat, string color)
        : base(name, age, "Bulldog", weight, habitat)
    {
        Color = color;
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says Woof! (Bulldog style)");
    }

    public void Snore()
    {
        Console.WriteLine($"{Name} is snoring.");
    }
}

// Underklass av Hund: Chihuahua
public class Chihuahua : Dog
{
    public string Size { get; set; }

    public Chihuahua(string name, int age, double weight, string habitat, string size)
        : base(name, age, "Chihuahua", weight, habitat)
    {
        Size = size;
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says Yip Yip!");
    }

    public void Shake()
    {
        Console.WriteLine($"{Name} is shaking.");
    }
}