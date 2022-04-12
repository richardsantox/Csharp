using System;
using System.Collections.Generic;
using Zoologico.src;

namespace Zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zoológio");

            List<Animal> animais = new List<Animal>(
                new Animal[]
                {
                    new Gato("gato Catel", "Cinza", "Felino"),
                    new Cachorro("cachorro Rodrigo", "Preto", "Canídio"),
                    new Cachorro("Cachorro Bueno", "Branco", "Canídio"),
                    new Gato("Gato Cavalcanti", "Marrom", "Felino"),
                    new Macaco("Jorge", "Amarelo", "Primata")
                }
            );

            foreach(Animal animal in animais)
            {
                if (animal.Classificacao == "Canídio")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("AU AU AU \n");
                }
                else if(animal.Classificacao == "Felino")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("Miauu \n");
                }else
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("Hu Hu HaHa \n");
                }
            }
        }
    }
}
