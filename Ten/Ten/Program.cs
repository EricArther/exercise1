using System;

namespace Ten
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[5];

            for (int i = 0; i < 5; i++)
            {
                animals[i] = new Animal();
                animals[i].id = i;

                Console.Write("Type: ");
                animals[i].type = Console.ReadLine();
                Console.Write("Name: ");
                animals[i].name = Console.ReadLine();
                Console.Write("Age: ");
                animals[i].age = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                animals[i].Display();
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        public class Animal
        {
            public string type;
            public string name;
            public int age;
            public int id;

            public void Display()
            {
                Console.WriteLine($"id  : {id}");
                Console.WriteLine($"type: {type}");
                Console.WriteLine($"name: {name}");
                Console.WriteLine($"age : {age}");
            }
        }
    }
}
