using System;

namespace Aula3VS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome: ");
            string nome  = Console.ReadLine();

            Console.WriteLine("Entre com sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nOi " + nome + "\nQue legal que vc tem " + idade + " anos de idade");

        }
    }
}
