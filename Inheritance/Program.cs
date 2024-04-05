using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes
            var blackBird = new Bird()
            {

                BeakSize = "5 inches",
                WingSpan = 18,
                Height = 20,
                Color = "Black",


            };

            var ingwana = new Reptile()
            {
                HasClaws = true,
                HasScales = true,
                Weight = 15,
                ColdBlooded = "Yes",
                Legs = 4,
                BodySize = "Large",
                MaleOrFemale = "Female",
                Age = 5


            };
            blackBird.Details();
            ingwana.Details();
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
        }
    }
}
