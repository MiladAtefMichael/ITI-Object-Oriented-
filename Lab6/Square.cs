using System;


namespace Lab6
{
    class Square:Rectangle
    {
        public Square(float dim1) : base(dim1,dim1)
        {
        }
        public override double CalcArea()
        {
            double area=Dim1*Dim2;
            return area;
        }


    }
}
