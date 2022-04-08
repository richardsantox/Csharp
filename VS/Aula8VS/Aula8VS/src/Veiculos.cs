using System;

namespace Aula8VS.src
{
    public class Veiculos
    {
        public string Nome { get; set; }
        public string Cor { get; set; }
        public string Tipo { get; set; }
        public int QuantidadeRodas { get; set; }

        public Veiculos()
        {

        }

        public Veiculos(string _nome, string _cor, string _tipo, int _qtdsRodas)
        {
            Nome = _nome;
            Cor = _cor;
            Tipo = _tipo;
            QuantidadeRodas = _qtdsRodas;
        }


        public void Andar()
        {
            Console.WriteLine("Veículo andando: Vrummmm");
        }
        
        public void Freiar()
        {
            Console.WriteLine("Veículo parando: Eeeepa");
        }
        public void Ligar()
        {
            Console.WriteLine("Veiculo ligando");
        }
    }
}