using System;

class Program
{
    static void Main()
    {
       
        double x0 = 1; 
        double y0 = 2; 
        double x1 = 0; 
        double y1 = 0; 
        double R = 3; 

        
        double distance = Math.Sqrt(Math.Pow(x0 - x1, 2) + Math.Pow(y0 - y1, 2));

        
        bool isInsideOrOnCircle = distance <= R;

        
        Console.WriteLine(isInsideOrOnCircle);
    }
}