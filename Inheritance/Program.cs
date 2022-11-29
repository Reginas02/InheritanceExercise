using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Bird Petie = new Bird()
            {
               Name = "Petie",
               Age = 85,
               legs = 2,
               HasFeathers = true,
               Wings = 2,
               Type = "parrot",
            };

              Console.WriteLine($"{Petie.Name} is a {Petie.Type} pet bird that is {Petie.Age}");
              Console.WriteLine();

            Reptile pet = new Reptile()
            {
               
              Name = "Drake",
              Age = 5,
              Environment = "Desert",
              isColdBlooded = true,
              HasScales = true,
              Defense = "spikes",

            
            };

            Console.WriteLine($"{pet.Name} is a bearded dragon that lives in {pet.Environment} he is {pet.Age} years old");







        }

               
    }
}
