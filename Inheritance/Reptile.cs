using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            Legs = 5;
            BodySize = "MegaBig";
            MaleOrFemale = "Male";
            Age = 400;
        }







        public bool HasClaws {  get; set; }
        public bool HasScales { get; set; }
        public int Weight { get; set; }
        public string ColdBlooded { get; set; }

        public void Details()
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"HasClaws: {HasClaws}");
            Console.WriteLine($"HasScales: {HasScales}");
            Console.WriteLine($"Weight: {Weight}Pounds");
            Console.WriteLine($"ColdBlooded: {ColdBlooded}");
            Console.WriteLine($"Legs: {Legs}");
            Console.WriteLine($"Male or Female: {MaleOrFemale}");
            Console.WriteLine($"BodySize: {BodySize}");
            Console.WriteLine($"Age: {Age}");

        }



    }
}
