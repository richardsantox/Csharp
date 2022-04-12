using System;
using CalculoArea.src;

namespace CalculoArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de áreas");

            AreaFormas _objeto = new AreaCalculo();

            Console.WriteLine($"Area de um quadrado de base 10 e lado 10 ( b*h ): {_objeto.Quadrado(10, 10)}");
            Console.WriteLine($"Area de um retângulo de base 20 e lado 10 ( b*h ): {_objeto.Retangulo(20, 10)}");
            Console.WriteLine($"Area de um triângulo de base 30 e lado 20 ( (b*h) / 2 ): {_objeto.Triangulo(30, 20)}");
        }
    }
}
