using System;
namespace Lab6
{  
    class Program
    {
        public static double CalcAllShapesArea(Shape[] shapes) 
        {
            double totalArea = 0;
            for(int i=0;i<shapes.Length;i++)
            {
                totalArea += shapes[i].CalcArea();

            }
            return totalArea;
        
        }
        public static void ShapesDetails(Shape[] shapes)
        {
            
            for (int i = 0; i < shapes.Length; i++)
            {
                shapes[i].Draw();

            }
            

        }
        public static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
            {
                new Circle(){Radius=30,Color="red"},
                new Circle(){Radius=30,Color="green"},
                new Rectangle(20,30){Color="blue"},
                new Square(60){ Color="yellow"},
                new Triangle(100,200){ Color="fazkoz"}
               
            };
            Double totalArea= CalcAllShapesArea(shapes);
            Console.WriteLine(totalArea);
            ShapesDetails(shapes);
            Console.ReadKey();
        }

    }
}