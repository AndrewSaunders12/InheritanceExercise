using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {

        public Bird()
        {
            Legs = 2;
            MaleOrFemale = "Male";
            BodySize = "Small";
            Age = 40;

        }

        public string BeakSize { get; set; }
        public int  WingSpan { get; set; }
        public int Height {  get; set; }
        public string Color {  get; set; }



        public void Details()
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"Wing Span: {10}inches");
            Console.WriteLine($"{Color}");
            Console.WriteLine($"Height: {Height}inches");
            Console.WriteLine($"BeakSize: {BeakSize}");
            Console.WriteLine($"Legs: {Legs}");
            Console.WriteLine($"Male or Female: {MaleOrFemale}");
            Console.WriteLine($"BodySize: {BodySize}");
            Console.WriteLine($"Age: {Age}");

        }




















    }
}
