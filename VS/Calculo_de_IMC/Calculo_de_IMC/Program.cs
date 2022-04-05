using System;

namespace Calculo_de_IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual o seu peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual é a sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            if (imc < 18.5) 
            {
                Console.WriteLine("Sua situação " + nome + ": Abaixo do peso"); 
            }
            else if (imc < 25)
            {
                Console.WriteLine("Sua situação " + nome + ": peso normal");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Sua situação " + nome + ": Sobrepeso");
            }
            else 
            {
                Console.WriteLine("Sua situação " + nome + ": Obesidade");
            }
        }
    }
}
