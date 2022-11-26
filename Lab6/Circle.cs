using System;


namespace Lab6
{
    class Circle:Shape
    {
        public float Radius { get; set; }
        public override double CalcArea()
        {
            double area = Radius * Radius * 3.14;
            return area;
        }

    }
}
