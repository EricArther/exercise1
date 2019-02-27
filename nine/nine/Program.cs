using System;

namespace nine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose 1 to 3");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    One();
                    return;

                case 2:
                    Two();
                    return;

                case 3:
                    Three();
                    return;
            }

            Console.ReadLine();
        }

        public static void One()
        {
            Console.Write("First Number: ");
            int first1 = int.Parse(Console.ReadLine());
            Console.Write("Second Number: ");
            int second1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{first1} + {second1} = {first1 + second1}");
            //Console.ReadLine();
        }

        public static void Two()
        {
            Console.Write("First Number: ");
            int first1 = int.Parse(Console.ReadLine());
            Console.Write("Second Number: ");
            int second1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{first1} / {second1} = {first1 / second1}");
        }

        public static void Three()
        {
            Console.Write("First Number: ");
            int first1 = int.Parse(Console.ReadLine());
            Console.Write("Second Number: ");
            int second1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{first1} * {second1} = {first1 * second1}");
        }


    }
}
