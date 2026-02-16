using System;
using System.Security.Cryptography.X509Certificates;

class PentagonClass
{
    static void Main(string[] args)
    {
        Pentagon p1 = new Pentagon();
        Pentagon p2 = new Pentagon(5);
        
        Console.WriteLine("Pentagon p1");
        Console.WriteLine(new string('-',25));
        p1.Display();

        Console.WriteLine("\nPentagon p2");
        Console.WriteLine(new string('-',25));
        p2.Display();


    }
}
class Pentagon
{
    public double Side;
    //default
    public Pentagon()
    {
        Side = 0;
    }
    //Parameterized
    public Pentagon(double Side)
    {
        this.Side = Side;
    }
    public double GetPerimeter(double Side)
    {
        return 5 * Side;
    }
    public double GetArea(double Side)
    {
        return (Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * Math.Pow(Side, 2)) / 4;
    }
    public void Display()
    {
        Console.WriteLine("Side length: " + Side);
        Console.WriteLine("Perimeter: {0:F3}", GetPerimeter(Side));
        Console.WriteLine("Area: {0:F3}", GetArea(Side));
    }
}
