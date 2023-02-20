using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractLab
{
    /// <summary>
    /// Abstract Lab
    /// </summary>
    /// <remarks>Author: Jamie Marie Espiritu </remarks>
    /// <remarks>Date: Feb 18, 2023</remarks>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the dog's name? ");

            Dog dog = new Dog();

            dog.Name = Console.ReadLine();
            dog.Colour = "brown";
            dog.Age = 1;

            Console.WriteLine("The dog's name is " + dog.Name +
                "\nThe dog's colour is " + dog.Colour +
                "\nThe dog's age is " + dog.Age);

            dog.Eat();

            Console.WriteLine("What is the cat's name?");

            Cat cat = new Cat();

            cat.Name = Console.ReadLine();
            cat.Colour = "black";
            cat.Age = 3;

            Console.WriteLine("The cat's name is " + cat.Name +
                "\nThe cat's colour is " + cat.Colour +
                "\nThe cat's age is " + cat.Age);

            cat.Eat();
        }
    }
}
