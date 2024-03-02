using System;

class Program
{
    static void Main()
    {
        
        double x = 30 * Math.PI / 180; 
        double y = 45 * Math.PI / 180;

        
        double numerator = Math.Sin(x) + Math.Cos(y);

       
        double denominator = Math.Cos(x) - Math.Sin(x);

        
        double expression = numerator / denominator * Math.Tan(x * y);

        
        Console.WriteLine("Значення виразу: " + expression);
    }
}

