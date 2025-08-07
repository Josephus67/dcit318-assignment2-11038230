// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

// Interface IMovable
public interface IMovable
{
    void Move();
}

// Class Car implementing IMovable
public class Car : IMovable
{
    private string brand;
    
    public Car(string brand = "Generic Car")
    {
        this.brand = brand;
    }
    
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
    
    public string GetBrand()
    {
        return brand;
    }
}

// Class Bicycle implementing IMovable
public class Bicycle : IMovable
{
    private string type;
    
    public Bicycle(string type = "Generic Bicycle")
    {
        this.type = type;
    }
    
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
    
    public new string GetType()
    {
        return type;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Interfaces Demo ");
        
        // instances of Car and Bicycle
        Car car = new Car("Toyota");
        Bicycle bicycle = new Bicycle("Mountain Bike");
        
        // Call Move() method on each instance
        Console.WriteLine($"{car.GetBrand()}:");
        car.Move();
        
        Console.WriteLine($"\n{bicycle.GetType()}:");
        bicycle.Move();
        
        // polymorphism with interfaces
        Console.WriteLine("\n Polymorphism with Interfaces ");
        IMovable[] movableObjects = { new Car("Honda"), new Bicycle("Road Bike") };
        
        foreach (IMovable obj in movableObjects)
        {
            Console.Write($"{obj.GetType().Name}: ");
            obj.Move();
        }
        
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
