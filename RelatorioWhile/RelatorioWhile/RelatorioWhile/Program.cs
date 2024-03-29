﻿using System;

namespace relatorioWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\n- PROGRAMA PARA INFORMAR OS VALORES DE UMA LISTA");
            Console.WriteLine("- CLASSIFICAR POR ORDEM CRESCENTE E DECRESCENTE");
            Console.WriteLine("- INFORMAR O MAIOR E MENOR VALOR ");
            Console.WriteLine("- CALCULAR A MÉDIA E MORA");

            int id = 0;
            int qtd = 0;            
            double crescente = 0;
            double decrescente = 0;            
            double maior = 0;
            double menor = 0;
            double media = 0;
            double mora = 0;

            while (id <= 5)
            {
                Console.WriteLine("\n\n-----------------xxxxxxxxxxxxxxx------------------");
                Console.WriteLine("|1| Maior e Menor valor da lista.");
                Console.WriteLine("|2| Ordenar a lista de forma crescente.");
                Console.WriteLine("|3| Ordenar a lista de forma decrescente.");
                Console.WriteLine("|4| Calculo da Média + Mora.");
                Console.WriteLine("\n|5| Caso deseja finalizar.");
                Console.WriteLine("**************************************************");

                Console.Write("\nDigite a opção desejada: ");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("**************************************************");
                
                if (id == 1)
                {
                    double valor1 = 0;
                    Console.Write("Informe a quantidade de operações que deseja realizar: ");
                    qtd = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nDigite o valor da operação " + 1 + ": ");
                    valor1 = Convert.ToDouble(Console.ReadLine());
                    maior = valor1;
                    menor = valor1;                    

                    for (int i = 2; i <= qtd; i++)

                    {
                        Console.Write("Digite o valor da operação " + i + ": ");
                        valor1 = Convert.ToDouble(Console.ReadLine());
                    }                      

                    if (valor1 < menor)
                    {
                        menor = valor1;
                    }

                    if (valor1 > maior)
                    {
                        maior = valor1;
                    }

                    Console.WriteLine("\n-----------------xxxxxxxxxxxxxxx------------------");
                    Console.WriteLine("maior valor |" + maior + "|");
                    Console.WriteLine("menor valor |" + menor + "|");
                    Console.WriteLine("-----------------xxxxxxxxxxxxxxx------------------");
                    Console.Write("\n\n");
                    Console.ReadKey();
                    Console.Clear();
                }

                if (id == 2)
                {                    
                    Console.Write("Informe a quantidade de operações que deseja realizar: ");
                    qtd = Convert.ToInt32(Console.ReadLine());

                    double[] valor2 = new double[qtd];

                    for (int j = 1; j <= qtd; j++)
                    {
                        Console.Write("Digite o valor da operação " + j + ": ");
                        valor2[j] = Convert.ToDouble(Console.ReadLine());                        
                    }

                    

                    Console.WriteLine("\n-----------------xxxxxxxxxxxxxxx------------------");
                    Console.WriteLine("ORDEM CRESCENTE |" + crescente + "|");
                    Console.WriteLine("-----------------xxxxxxxxxxxxxxx------------------");
                    Console.Write("\n\n");
                    Console.ReadKey();
                    Console.Clear();
                }

                if (id == 3)
                {
                    double valor3 = 0;
                    Console.Write("Informe a quantidade de operações que deseja realizar: ");
                    qtd = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nDigite o valor da operação " + 1 + ": ");
                    valor3 = Convert.ToDouble(Console.ReadLine());

                    for (int k = 2; k <= qtd; k++)

                    {
                        Console.Write("Digite o valor da operação " + k + ": ");
                        valor3 = Convert.ToDouble(Console.ReadLine());
                    }                    

                    Console.WriteLine("\n-----------------xxxxxxxxxxxxxxx------------------");
                    Console.WriteLine("ORDEM DECRESCENTE |" + decrescente + "|");
                    Console.WriteLine("-----------------xxxxxxxxxxxxxxx------------------");
                    Console.Write("\n\n");
                    Console.ReadKey();
                    Console.Clear();
                }

                if (id == 4)
                {
                    double valor4 = 0;
                    Console.Write("Informe a quantidade de operações que deseja realizar: ");
                    qtd = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nDigite o valor da operação " + 1 + ": ");
                    valor4 = Convert.ToDouble(Console.ReadLine());

                    for (int l = 2; l <= qtd; l++)

                    {
                        Console.Write("Digite o valor da operação " + l + ": ");
                        valor4 = Convert.ToDouble(Console.ReadLine());
                    }                    

                    Console.WriteLine("\n-----------------xxxxxxxxxxxxxxx------------------");
                    Console.WriteLine("ORDEM CRESCENTE |" + crescente + "|");
                    Console.WriteLine("ORDEM DECRESCENTE |" + decrescente + "|");
                    Console.WriteLine("-----------------xxxxxxxxxxxxxxx------------------");
                    Console.Write("\n\n");
                    Console.ReadKey();
                    Console.Clear();                    
                }                

                if (id == 5)
                {
                    Console.WriteLine("\n-----------------xxxxxxxxxxxxxxx------------------");                    
                    Console.WriteLine("           APLICAÇÃO FINALIZADA COM SUCESSO!");
                    Console.WriteLine("-----------------xxxxxxxxxxxxxxx------------------");
                    Console.Write("\n\n");
                    Console.ReadKey();
                    break;
                }                
            }
        }
    }
}