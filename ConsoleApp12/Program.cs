using System;

namespace ZooManagement
{   
    class Program
    {
        static void Main(string[] args)
        {
            // Inmatning av djurens egenskaper
            Console.Write("Ange djurets namn: ");
            string name = Console.ReadLine();

            Console.Write("Ange djurets ålder: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Ange djurets vikt: ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Ange djurets habitat: ");
            string habitat = Console.ReadLine();

            Console.Write("Ange djurets ras (Hund): ");
            string breed = Console.ReadLine();

            // Skapa ett djur
            Dog dog = new Dog(name, age, breed, weight, habitat);
            dog.MakeSound();
            dog.Eat();
            dog.Fetch();

            // Skapa Bulldog
            Bulldog bulldog = new Bulldog("Bully", 2, 25.0, "Apartment", "Brindle");
            bulldog.MakeSound();
            bulldog.Eat();
            bulldog.Snore();

            // Skapa Chihuahua
            Chihuahua chihuahua = new Chihuahua("Chico", 1, 5.0, "House", "Small");
            chihuahua.MakeSound();
            chihuahua.Eat();
            chihuahua.Shake();

            // Håll konsolen öppen
            Console.ReadLine();
        }
    }
}
