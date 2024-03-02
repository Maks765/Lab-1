using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Введіть натуральне число n: ");
        int n;
        if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Введено некоректне число.");
            return;
        }

        
        string numberString = n.ToString();

        
        if (numberString.Length > 10 || (numberString.Length == 10 && numberString.CompareTo("2147483647") > 0))
        {
            Console.WriteLine("Переповнення! Неможливо поміняти порядок цифр.");
            return;
        }

        
        char[] charArray = numberString.ToCharArray();
        Array.Reverse(charArray);
        string reversedNumberString = new string(charArray);

        
        Console.WriteLine("Число з оберненим порядком цифр: " + reversedNumberString);
    }
}
