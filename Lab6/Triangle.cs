using System;


namespace Lab6
{
    class Triangle:Shape
    {
        public float Dim1 { get; set; }
        public float Dim2 { get; set; }
        public float Dim3 { get; set; }
        public float Base { get; set; }
        public float Height { get; set; }
        double area;
        public Triangle(float dim1,float dim2,float dim3)
        {
            Dim1 = dim1;
            Dim2 = dim2;
            Dim3 = dim3;
            double s =  (Dim1 + Dim2 + Dim3) / 2;
            area = Math.Sqrt(s * (s - Dim1) * (s - Dim2) * (s - Dim3));

        }
        public Triangle(float _base, float _height)
        {
            Base = _base;
            Height = _height;
            area = 0.5*Base*Height;

        }
        public override double CalcArea()
        {
            
            return area;
        }
    }
}
