using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Введіть рядок: ");
        string input = Console.ReadLine();

        
        int count_r = input.Count(c => c == 'r' || c == 'R');
        int count_k = input.Count(c => c == 'k' || c == 'K');
        int count_t = input.Count(c => c == 't' || c == 'T');

        
        Console.WriteLine("Кількість 'r' у рядку: " + count_r);
        Console.WriteLine("Кількість 'k' у рядку: " + count_k);
        Console.WriteLine("Кількість 't' у рядку: " + count_t);
    }
}
