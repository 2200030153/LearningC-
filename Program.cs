using System;

namespace LearningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print Hello, World!
            Console.WriteLine("Hello, World!");

            // Variables and Data Types
            int age = 19;
            double height = 5.2;
            string name = "Thota Arshitha";
            bool isStudent = true;

            // Print variables
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Is Student: {isStudent}");

            // Control Structures
            if (age > 18)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a minor.");
            }

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Count: {i}");
            }

            // Basic Object-Oriented Programming
            Person person = new Person(name, age, height, isStudent);
            person.Introduce();

            Console.ReadKey();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public bool IsStudent { get; set; }

        public Person(string name, int age, double height, bool isStudent)
        {
            Name = name;
            Age = age;
            Height = height;
            IsStudent = isStudent;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, {Age} years old, {Height} feet tall, and it's {IsStudent} that I'm a student.");
        }
    }
}
