using Aula8VS.src;
using System;

namespace Aula8VS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Veiculos bmw = new Veiculos("X6", "Preta", "Carro", 4);
            Veiculos honda = new Veiculos("CG Start", "Azul", "Moto", 2);
            Veiculos rms = new Veiculos("Titanic", "Branco e Preto", "Navio", 0);
            Veiculos boeing = new Veiculos("XB-15", "Cinza", "Avião", 3);

            Console.WriteLine($"O veículo é o/a {bmw.Nome} de cor {bmw.Cor}, de tipo '{bmw.Tipo}'  e tem {bmw.QuantidadeRodas} rodas.");
            Console.WriteLine($"O veículo é o/a {honda.Nome} de cor {honda.Cor}, de tipo '{honda.Tipo}' e tem {honda.QuantidadeRodas} rodas.");
            Console.WriteLine($"O veículo é o/a {rms.Nome} de cor {rms.Cor}, de tipo '{rms.Tipo}' e tem {rms.QuantidadeRodas} rodas.");
            Console.WriteLine($"O veículo é o/a {boeing.Nome} de cor {boeing.Cor}, de tipo '{boeing.Tipo}' e tem {boeing.QuantidadeRodas} rodas.\n");

            Veiculos met = new Veiculos();
            met.Ligar();
            met.Andar();
            met.Freiar();

        }
    }
}
