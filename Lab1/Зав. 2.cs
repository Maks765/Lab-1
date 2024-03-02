using System;

class Program
{
    static void Main()
    {
        
        double R1 = 10; 
        double R2 = 20;
        double R3 = 30;

        
        double totalResistance = 1 / (1 / R1 + 1 / R2 + 1 / R3);

        
        Console.WriteLine("Загальний опір з'єднання: " + totalResistance + " Ом");
    }