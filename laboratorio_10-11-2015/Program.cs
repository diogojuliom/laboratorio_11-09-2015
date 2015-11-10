using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace laboratorio_10_11_2015
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[20];
            Random ale = new Random();
            classVetor v = new classVetor();
            int numero = 0;

            try
            {
                for (int i = 0; i < vetor.Length; i++)
                {
                    vetor[i] = ale.Next(10);
                    Console.Write(vetor[i] + " ");
                }
            }
            catch (IndexOutOfRangeException erro) {
                Console.WriteLine(erro.Message);
            }


            //Thread 1
                //Menor valor
                Console.WriteLine("\n\nMenor valor: " + v.procura_menor(vetor));
                //Maior valor
                Console.WriteLine("Maior valor: " + v.procura_maior(vetor));

                try
                {
                    Console.Write("\nDigite um número presente no vetor: ");
                    numero = int.Parse(Console.ReadLine());
                }
                catch (FormatException erro) {
                    Console.WriteLine(erro.Message);
                }

            //Thread 2
                //Priemira posição do numero
                Console.WriteLine("\nO número " + numero + " apareceu primeiro na posição: " + v.primeira_posicao(vetor,numero));

            //Thread 3
                //Todas as posições do número
                Console.WriteLine("\nTodas as posições do número " + numero);
                try
                {
                    for (int j = 0; j < vetor.Length; j++)
                    {
                        if (v.todas_posicoes(vetor, numero)[j] == -1)
                        {
                            Console.Write("");
                        }
                        else
                        {
                            Console.Write(v.todas_posicoes(vetor, numero)[j] + " ");
                        }
                    }
                }
                catch (IndexOutOfRangeException erro) {
                    Console.WriteLine(erro.Message);
                }

            //Thread 4
                //Quantidade de vezes que o numero apareceu
                Console.WriteLine("\n\nO número " + numero + " apareceu " + v.total(vetor, numero) + " vezes");

            Console.ReadKey();
        }
    }
}
