// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

// Abstract class Shape
public abstract class Shape
{
    public abstract double GetArea();
}

// Derived class Circle
public class Circle : Shape
{
    private double radius;
    
    public Circle(double radius)
    {
        this.radius = radius;
    }
    
    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
    
    public double GetRadius()
    {
        return radius;
    }
}

// Derived class Rectangle
public class Rectangle : Shape
{
    private double length;
    private double width;
    
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }
    
    public override double GetArea()
    {
        return length * width;
    }
    
    public double GetLength()
    {
        return length;
    }
    
    public double GetWidth()
    {
        return width;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Abstract Classes and Methods Demo");
        
        // instances of Circle and Rectangle
        Circle circle = new Circle(5.0);
        Rectangle rectangle = new Rectangle(4.0, 6.0);
        
        // Displaying their areas
        Console.WriteLine($"Circle with radius {circle.GetRadius()}:");
        Console.WriteLine($"Area = {circle.GetArea():F2}");
        
        Console.WriteLine($"\nRectangle with length {rectangle.GetLength()} and width {rectangle.GetWidth()}:");
        Console.WriteLine($"Area = {rectangle.GetArea():F2}");
        
        // Show polymorphism with abstract classes
        Console.WriteLine("\nPolymorphism with Abstract Classes");
        Shape[] shapes = { new Circle(3.0), new Rectangle(2.5, 4.0) };
        
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetType().Name} area: {shape.GetArea():F2}");
        }
        
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
