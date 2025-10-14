using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Utils
{
    public abstract class ConcreteShapeCreator
    {
        public abstract IShape CreateShape();

        public void AnOperation()
        {
            // Creazione dello shape
            IShape shape = CreateShape();
            shape.Draw();
        }
    }
}