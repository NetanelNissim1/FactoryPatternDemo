using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapeFactory = new ShapeFactory();
            Shape shape1 = shapeFactory.getShape("CIRCLE");
            shape1.draw();

            Shape shape2 = shapeFactory.getShape("RECTANGLE");
            shape2.draw();

            Shape shape3 = shapeFactory.getShape("SQUARE"); 
            shape3.draw();
        }
    }
}
