using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Utils
{
    //Moto implementa Ishape
    public class Square : ConcreteShapeCreator, IShape
    {
        public void Draw() => Console.WriteLine($"Sei su Square, hai creato un quadrato.");
    }
}