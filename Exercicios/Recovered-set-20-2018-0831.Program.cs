using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, resto;

          



            // exercicio 1

            Console.WriteLine("***** Exercicio 1 *****");

            Console.WriteLine("informe um numero");
            num1 = double.Parse(Console.ReadLine());

           

            if (num1 > 0)
            {
                Console.WriteLine("este numero é positivo");
            }
            else if (num1 == 0)
            {
                Console.WriteLine("Este numero é igual a 0");
            }

            else
            {
                Console.WriteLine("Este numero é negativo");
            }
            Console.WriteLine("");
            Console.WriteLine("pressione uma tecla para prosseguir");
            Console.ReadLine();

            // exercicio 2

            Console.WriteLine("***** Exercicio 2 *****");
           
            Console.WriteLine("Informe um numero");
            num2 = double.Parse(Console.ReadLine());

            resto = num2 % 2;

            if (resto == 0)
            {
                Console.WriteLine("Este numero é par");
            }
            else
            {
                Console.WriteLine("Este numero é Impar");
            }

            Console.Read();


        }
    }
}
