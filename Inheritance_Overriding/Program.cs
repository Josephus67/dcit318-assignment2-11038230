// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

// Base class Animal
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

// Derived class Dog
public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

// Derived class Cat
public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Inheritance and Method Overriding Demo ===");
        
        // An instances of Animal, Dog, and Cat
        Animal genericAnimal = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();
        
        // Call MakeSound() method on each instance
        Console.Write("Animal: ");
        genericAnimal.MakeSound();
        
        Console.Write("Dog: ");
        dog.MakeSound();
        
        Console.Write("Cat: ");
        cat.MakeSound();
        
        // Demonstrate polymorphism
        Console.WriteLine("\n Polymorphism Example ");
        Animal[] animals = { new Animal(), new Dog(), new Cat() };
        
        foreach (Animal animal in animals)
        {
            Console.Write($"{animal.GetType().Name}: ");
            animal.MakeSound();
        }
        
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
