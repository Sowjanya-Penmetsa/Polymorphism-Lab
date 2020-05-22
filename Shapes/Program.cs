using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10,15);
            Console.WriteLine(rect.CalculateArea());
            Console.WriteLine(rect.CalculatePerimeter());
            Console.WriteLine(rect.Draw());

            Circle cir = new Circle(10);
            Console.WriteLine(cir.CalculateArea());
            Console.WriteLine(cir.CalculatePerimeter());
            Console.WriteLine(cir.Draw());
        }
    }
}
