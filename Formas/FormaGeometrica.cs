using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    public abstract class FormaGeometrica
    {
        public abstract double CalcularArea();

        public abstract double CalcularPerimetro();

        public void Desenhar()
        {
            Console.WriteLine("Desenhando Formas");
        }


    } 
}
