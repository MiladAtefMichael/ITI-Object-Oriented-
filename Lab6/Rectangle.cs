using System;


namespace Lab6
{
    class Rectangle:Shape
    {
        public float Dim1 { get; set; }
        public float Dim2 { get; set; }
       public  Rectangle(float dim1, float dim2)
        {
            Dim1 = dim1;
            Dim2 = dim2;
        }
        public override double CalcArea()
        {
            double area = Dim1*Dim2;
            return area;
        }
    }
}
