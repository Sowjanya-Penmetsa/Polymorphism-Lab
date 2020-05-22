using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
       public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }
        
        
        public override double CalculatePerimeter()
        {
            return 2 * 3.14 * radius;
            
        }
        public override double CalculateArea()
        {
            return 3.14 * radius * radius;
        }
        public override string Draw()
        {
            return base.Draw() +":"+ "Circle";
        }
    }
}
