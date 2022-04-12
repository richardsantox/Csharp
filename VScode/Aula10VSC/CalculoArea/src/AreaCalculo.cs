using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoArea.src
{
    public class AreaCalculo : AreaFormas
    {
        public double Retangulo(double b, double h) 
        {
            return b * h;
        }
        public double Quadrado(double b, double h)
        {
            return b * h;
        }
        public double Triangulo(double b, double h)
        {
            return (b * h) / 2;
        }
    }
}
