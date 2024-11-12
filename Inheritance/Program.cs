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
            var baldEagle = new Bird();
            baldEagle.Age = 10;
            baldEagle.WingSpan = 8;
            baldEagle.DoesFly = true;
            baldEagle.AmericasMascot = true;
            baldEagle.Legs = 2;
            baldEagle.HasFur = true;
            baldEagle.Name = "Garry";
            baldEagle.Color = "Brown";
            Console.WriteLine($"{baldEagle.Name} is a {baldEagle.Color} Bald Eagle thats {baldEagle.Age} years old with a {baldEagle.WingSpan} foot wingspan. And {baldEagle.Name} has {baldEagle.Legs} legs, its" +
                $"{baldEagle.DoesFly} that they fly all around america as its {baldEagle.AmericasMascot} American Mascot. Its {baldEagle.HasFur} color on its head is white. ");
            Console.WriteLine();
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var snake = new Reptile();
            snake.Scales = "scaley";
            snake.IsColdBlooded = "Cold Blooded";
            snake.IsVenomous = "venomous";
            snake.PlaysVideoGames = false;
            snake.Legs = 0;
            snake.HasFur = false;
            snake.Name = "George";
            snake.Age = 60;
            Console.WriteLine($"{snake.Name} is a {snake.Scales} {snake.IsVenomous} snake that has {snake.Legs} legs, and is {snake.IsColdBlooded} and its age is {snake.Age} years old." +
                $" It is {snake.PlaysVideoGames};" +
                $"snakes do not play video games and its also {snake.HasFur} that they have Fur.");

        }
    }
}
