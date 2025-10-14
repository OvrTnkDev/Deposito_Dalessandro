using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Utils
{
    //Moto implementa Ishape
    public class Circle : ConcreteShapeCreator, IShape
    {
        public override IShape CreateShape()
        {
            return new Circle();
        }
        public void Draw() => Console.WriteLine($"Sei su Circle, hai creato un cerchio.");
    }
}