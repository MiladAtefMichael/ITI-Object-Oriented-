using System;

namespace Lab6
{
    abstract class Shape
    {
        
        public String Color { get; set; }
        abstract public double CalcArea();
        public void Draw()
        {
            Console.WriteLine($"shape is drawn with color {Color} and {CalcArea()}");
        }
    }
}
