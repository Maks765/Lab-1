using System;

class Program
{
    static void Main()
    {
       
        double x = 7.5; 
        double[] A = { 4.5, 6.8, 8.3, 9.1, 10.6 }; 
        
        double closestSum = double.MaxValue;
        double result1 = 0, result2 = 0;

        for (int i = 0; i < A.Length - 1; i++)
        {
            for (int j = i + 1; j < A.Length; j++)
            {
                
                double average = (A[i] + A[j]) / 2;

                
                if (Math.Abs(average - x) < Math.Abs(closestSum - x))
                {
                    closestSum = average;
                    result1 = A[i];
                    result2 = A[j];
                }
            }
        }

        
        Console.WriteLine("Найближче до {0} середнє арифметичне між {1} та {2}:", x, result1, result2);
        Console.WriteLine("Результат: " + closestSum);
    }
}
