using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // Calculadora

        Inicio: // label
            Console.Clear();

            Console.WriteLine("CALCULADORA");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Digite o Primeirop número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Escolha a operação ( + - x / ): ");
            char operacao = char.Parse(Console.ReadLine());


            Console.Write("Digite o Segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            

            
            // Variavel para armazenar o resultado da operação

            double resultado = 0; 

            switch(operacao)
            {
                default:
                    Console.WriteLine("Erro opção inválida.");
                    break;

                case '+':
                    resultado = num1 + num2;
                    Console.WriteLine("O número da soma é:" + resultado);
                    break;

                case '-':
                    resultado = num1 - num2;
                    Console.WriteLine("O resultado da subtração é: " + resultado);
                    break;

                case 'x':
                case 'X':
                    resultado = num1 * num2;
                    Console.WriteLine("O resultado da multiplicação é: " + resultado);
                    break;

                case '/':

                    if(num2 == 0)
                    {
                        Console.WriteLine("Não é pssivél dividir por 0.");
                    }
                     
                        resultado = num1 / num2;
                        Console.WriteLine("O resultado da divisão é: " + resultado);
                        break;
                    
            }

                    Console.Write("Continuar Calculando (s / n): ");
                    string op = Console.ReadLine(); 

                    if(op == "s" || op == "S")
                    {
                        goto Inicio;
                    }
            
                    Console.ReadKey();

        }
    }
}
