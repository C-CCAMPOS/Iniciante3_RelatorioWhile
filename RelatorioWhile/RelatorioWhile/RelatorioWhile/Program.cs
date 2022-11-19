using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace relatorioWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>>>>INFORME A ORDEM DA LISTA, MAIOR VALOR, MENOR VALOR OU CALCULO DA MÉDIA E MORA<<<<<");

            int id = 0;
            int inter = 0;
            double valor = 0;
            double maior = 0;
            double menor = 0;
            double media = 0;
            double mora = 0;

           while (id < 5)
            {
                Console.WriteLine("\n**************************************************");
                Console.WriteLine("\n\n1- Maior e Menor valor da lista.");
                Console.WriteLine("2- Ordenar a lista de forma crescente.");
                Console.WriteLine("3- Ordenar a lista de forma decrescente.");
                Console.WriteLine("4- Calculo da Média + Mora.");
                Console.WriteLine("\n\n5- Caso deseja finalizar.");
                
                Console.Write("\n\n\nDigite a opção desejada: ");
                id = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nDigite a quantidade de operações que deseja realizar: ");
                inter = Convert.ToInt32(Console.ReadLine());

                Console.Write("\n\n\n");

                for (int i = 1; i <= inter; i++)
                {
                    Console.Write("Digite o valor da operação " + i + ": ");
                    valor = Convert.ToDouble(Console.ReadLine());

                    if (id == 1)
                    {
                        Console.WriteLine("\n\nMaior Valor: ");
                        Console.WriteLine("Menor Valor: ");
                        Console.ReadKey();
                    }
                    if (id == 2)
                    {
                        Console.WriteLine("\n\nMaior Valor: ");
                        Console.WriteLine("Menor Valor: ");
                        Console.ReadKey();
                    }
                }
            }            
           
            
        }
    }
}
