using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
   public class ShapeFactory
    {
        public Shape getShape(string shapeType)
        {
            if (shapeType == null) return null;
            if (shapeType.ToUpper().Equals("CIRCLE")) return new Circle();
            if (shapeType.ToUpper().Equals("RECTANGLE")) return new Rectangle();
            if (shapeType.ToUpper().Equals("SQUARE")) return new Square();
            return null;
        }
    }
}
