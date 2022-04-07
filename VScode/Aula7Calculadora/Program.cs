using System;

namespace Aula7Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
         
            bool convertido;
            
            do 
            {
                Console.WriteLine("Digite o Primeiro numero: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o operador: ");
                string operador = Console.ReadLine();

                Console.WriteLine("Digite o Segundo numero: ");
                int num2 = int.Parse(Console.ReadLine());

                switch (operador)
                {
                    case "+":
                        Console.WriteLine("Resultado: " + Somar(num1, num2));
                        break;
                    case "-":
                        Console.WriteLine("Resultado: " + Subtrair (num1, num2));
                        break;
                    case "*":
                        Console.WriteLine("Resultado: " + Multiplicar (num1, num2));
                        break;
                    case "/":
                        Console.WriteLine("Resultado: " + Dividir (num1, num2));
                        break;
                    default:
                        Console.WriteLine("Operador invalido");
                        break;
                }


                Console.WriteLine("Deseja continuar? (sim ou nao): ");
                string interruptor =  Console.ReadLine();

                    if(interruptor == "sim")
                    {   
                        interruptor = "true";
                    }
                    else
                    {
                        interruptor = "false";
                    }

                Boolean.TryParse(interruptor , out convertido);
                Console.WriteLine("");



            } while ( convertido );
        }




        public static string Somar (int num1, int num2)
        {
            return (num1 + num2).ToString();
        }

         public static string Subtrair (int num1, int num2)
        {
            return (num1 - num2).ToString();
        }

         public static string Multiplicar (int num1, int num2)
        {
            return (num1 * num2).ToString();
        }

         public static string Dividir (int num1, int num2)
        {
            if(valorDividendoMenorOuIgualQueZero(num2))
            {
                return "Não é possivel dividir por zero ou menor que zero";
            }
            
                return(num1 / num2).ToString();
            //FUnção
            bool valorDividendoMenorOuIgualQueZero(int num2)
            {
                if (num2 <= 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
