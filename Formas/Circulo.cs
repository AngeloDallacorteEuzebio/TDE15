using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    public class Circulo : FormaGeometrica
    {
        public double Raio {  get; set; }
        public Circulo(double raio)
        {
            Raio = raio;
        }
        public override double CalcularArea()
        {
            return Math.PI * (Raio * Raio);
        }
        public override double CalcularPerimetro()
        {
            return (Math.PI * 2) * Raio;
        }
    }
}
