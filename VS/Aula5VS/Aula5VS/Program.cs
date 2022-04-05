using System;

namespace exemplo1BoazAula2Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Você concluiu o curso(sim ou não): ");
            string condicaoCursoConcluido = Console.ReadLine();

            Console.WriteLine("Quantos cursos você concluiu?: ");
            int condicaoQuantidadeCursoConcluido = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Você quitou o curso?(sim ou não): ");
            string condicaoQuitacao = Console.ReadLine();

            Console.WriteLine("Você todos os livros?(sim ou não): ");
            string condicaobiblioteca = Console.ReadLine();


            if (condicaoCursoConcluido == "sim" && condicaoQuantidadeCursoConcluido >= 25 &&
                condicaoQuitacao == "sim" && condicaobiblioteca == "sim")
            {
                Console.WriteLine("Candidato aprovado");
            }
            else
            {
                Console.WriteLine("Candidato reprovado");
            }
        }
    }
}
