using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laboratorio_10_11_2015
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[20];
            Random ale = new Random();
            classVetor v = new classVetor();

            for (int i = 0; i < vetor.Length; i++) {
                vetor[i] = ale.Next(10);
                Console.WriteLine(vetor[i]);
            }
            Console.WriteLine("\nMenor valor: " + v.procura_menor(vetor));
            Console.WriteLine("Maior valor: " + v.procura_maior(vetor));

            Console.Write("\nDigite um número presente no vetor: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("\nO número " + numero + " apareceu primeiro na posição: " + v.primeira_posicao(vetor,numero));
            Console.WriteLine("Todas as posições do número " + numero);
            for (int j = 0; j < vetor.Length; j++) {
                Console.WriteLine(v.todas_posicoes(vetor, numero)[j]);
            }
            Console.ReadKey();
        }
    }
}
