using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoArea.src
{
    internal interface AreaFormas
    {
        double Retangulo(double b, double h);
        double Quadrado(double b, double h);
        double Triangulo(double b, double h);
    }
}
