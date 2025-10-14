using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Utils
{
    public abstract class ShapeCreator
    {
        // Crea Veicolo: restituisce un IShape
        public static IShape CreateShape(string type)
        {
            switch (type.ToLower())
            {
                case "circle":
                    return new Circle();
                case "square":
                    return new Square();
                default:
                    return null;
            }
        }
    }
}