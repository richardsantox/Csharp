using System;
using System.Collections.Generic;


namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Listaa");

            List<string> lista = new List<string>();

            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine("Entre com o nome: ");
                var nome = Console.ReadLine();
                lista.Add(nome);
            }

            Console.WriteLine("Lista");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Elemento: {lista[1]}");

            
            /*lista.Add("Yasmin");
            lista.Add("Karol");
            lista.Add("Correria");
            lista.Add("Kaique");

            foreach(string item in lista)
            {
                Console.WriteLine(item);
            }*/

        }
    }
}
