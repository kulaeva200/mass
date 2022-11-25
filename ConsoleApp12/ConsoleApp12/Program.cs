using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine()); 
            int result;
            if (n > 123)
                result = (n - 123) * 3; 
            else
                result = 123 - n; 
            Console.WriteLine(result);
        }
    }
}
