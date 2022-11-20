using System;




namespace relatorioWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\n- PROGRAMA PARA INFORMAR OS VALORES DE UMA LISTA");
            Console.WriteLine("- CLASSIFICAR POR ORDEM CRESCENTE E DECRESCENTE");
            Console.WriteLine("- INFORMAR O MAIOR E MENOR VALOR");
            Console.WriteLine("- CALCULAR A MÉDIA E MORA");

            int id = 0;
            int qtd = 0;
            int i = 0;
            double valor = 0;
            double maior = 0;
            double menor = 0;
            double media = 0;
            double mora = 0;


            while (id < 5)
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

                Console.Write("\nInforme a quantidade de operações que deseja realizar: ");
                qtd = Convert.ToInt32(Console.ReadLine());
                                 
                Console.Write("\nDigite o valor da operação " + 1 + ": ");
                valor = Convert.ToDouble(Console.ReadLine());
                maior = valor;
                menor = valor;
                i = 1;

                for (i = 2; i <= qtd; i++)
                {
                    Console.Write("Digite o valor da operação " + i + ": ");
                    valor = Convert.ToDouble(Console.ReadLine());
                }

                            
                                                
                if (id == 1)
                {


                    if (valor < menor)
                    {
                        menor = valor;
                    }

                    if (valor > maior)
                    {
                        maior = valor;
                    }
                }

                Console.WriteLine("\n-----------------xxxxxxxxxxxxxxx------------------");
                Console.WriteLine("MAIOR VALOR |" + maior + "|");
                Console.WriteLine("MENOR VALOR |" + menor + "|");
                Console.WriteLine("-----------------xxxxxxxxxxxxxxx------------------");
                Console.Write("\n\n");                
                Console.ReadKey();
                Console.Clear();


            }
        }
    }
}

