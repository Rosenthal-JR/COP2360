using System;
namespace Dog
{
    class Dog
    {
        public int Age;
        public string Breed;
        public string Name;
        public Dog()
        {
            Age = 10;
            Breed = "Pitbull";
            Name = "Dexter";
        }
    }
    class User_Input
    {
        static void Main(string[] args)
        {
            Dog Dog1 = new Dog();
            Console.Write("Please enter the Dog's Age in a number of years.");
            Console.WriteLine();
            Dog1.Age = int.Parse(Console.ReadLine());
            Console.Write("What breed is the dog?");
            Console.WriteLine();
            Dog1.Breed = Console.ReadLine();
            Console.Write("What is the dog's name?");
            Console.WriteLine();
            Dog1.Name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"{Dog1.Name} is a {Dog1.Breed} that is {Dog1.Age} years old");
        }
    }
}
