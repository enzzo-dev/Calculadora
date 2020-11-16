using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
                        Console.WriteLine("Qual operação você deseja fazer? Soma, Subtração, Multiplicação e Divisão");
            string operacao = Console.ReadLine();
            System.Console.WriteLine("Digite o 1° Número: ");
            float num1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o 2° Número: ");
            float num2 = float.Parse(Console.ReadLine());
            float resultados = 0;

            switch(operacao){
                case "Soma" :
                      resultados = num1 + num2;
                break;

                case "Subtração":
                     resultados = num1 - num2;
                break;

                case "Multiplicação" :
                     resultados = num1 * num2;
                break;        

                case "Divisão":
                    resultados = num1 / num2;
                break;

                default:
                    System.Console.WriteLine("Operação Inválida: ");
                break;        
            }

            System.Console.WriteLine($"O resultado da {operacao} entre {num1} e {num2}. E o resultado é: {resultados} ");

        
        }
    }
}
