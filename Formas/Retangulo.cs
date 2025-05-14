using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    public class Retangulo : FormaGeometrica
    {

        public double Altura { get; set; }

        public double Lagura { get; set; }

        public override double CalcularArea()
        {
            return Altura * Lagura;
        }
        public override double CalcularPerimetro()
        {
            return 2 * (Lagura + Altura);
        }
    }
}
