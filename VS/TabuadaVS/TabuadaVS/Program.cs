using System;

namespace TabuadaVS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um numero para tabuada: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tabuada do: {num}");
            for (int y = 1; y <= 10; y++)
            {
                Console.WriteLine(num + "x" + y + " = " + num * y);
            }
            
        }
    }
}