using System;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Eric Arther");

            Console.WriteLine();

            Console.Write("First Number: ");
            int first1 = int.Parse(Console.ReadLine());
            Console.Write("Second Number: ");
            int second1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{first1} + {second1} = {first1 + second1}");

            Console.WriteLine();

            Console.Write("First Number: ");
            int first2 = int.Parse(Console.ReadLine());
            Console.Write("Second Number: ");
            int second2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{first2} / {second2} = {(double)first2 / (double)second2}");

            Console.WriteLine();

            Console.Write("First Number: ");
            int first3 = int.Parse(Console.ReadLine());
            Console.Write("Second Number: ");
            int second3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{first3} * {second3} = {first3 * second3}");

            Console.WriteLine();

            Console.Write("number: ");
            int number1 = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number1} * {i} = {number1 * i}");
            }

            Console.WriteLine();

            Console.Write("number: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"perimeter: {number2 * 2 * Math.PI}");
            Console.WriteLine($"area: {number2 * number2 * Math.PI}");

            Console.WriteLine();

            Console.Write("First Number: ");
            int first4 = int.Parse(Console.ReadLine());
            Console.Write("Second Number: ");
            int second4 = int.Parse(Console.ReadLine());
            Console.WriteLine($"first = {first4}, second = {second4}");
            int temp = first4;
            first4 = second4;
            second4 = temp;
            Console.WriteLine($"first = {first4}, second = {second4}");

            Console.WriteLine();
            Random random = new Random();

            for (int i = 0, ii = 1; i < 100; i++, ii++)
            {
                Console.Write($"{random.Next(1000, 10000)} ");
                if(ii == 10)
                {
                    Console.WriteLine();
                    ii = 0;
                }
            }

            Console.ReadLine();
        }
    }
}
