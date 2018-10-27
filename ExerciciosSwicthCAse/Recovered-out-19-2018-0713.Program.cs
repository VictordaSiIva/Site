using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            double op, n1, n2, resultado;

            Console.WriteLine("Calculadora basica");
            Console.WriteLine("informe a operação \n 1- Adição \n 2- subtração \n 3- multiplicação \n 4- divisão");
            op = double.Parse(Console.ReadLine());

            Console.WriteLine("INforme o primeiro numero");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("INforme o segundo numero");
            n2 = double.Parse(Console.ReadLine());

          
                switch (op)
                {
                    case 1:

                        resultado = n1 + n2;

                        Console.WriteLine(" O resultado é: " + resultado);
                        break;

                    case 2:

                        resultado = n1 - n2;

                        Console.WriteLine(" O resultado é: " + resultado);
                        break;

                    case 3:

                        resultado = n1 * n2;

                        Console.WriteLine(" O resultado é: " + resultado);
                        break;

                    case 4:



                        if (n2 == 0)
                        {
                            Console.WriteLine("Impossivel dividir por 0");

                        }
                        else
                        {
                            resultado = n1 / n2;
                            Console.WriteLine(" O resultado é: " + resultado);
                        }


                        break;



                }
            

            Console.Read();
        }
    }
}
