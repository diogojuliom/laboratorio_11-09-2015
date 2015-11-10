using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laboratorio_10_11_2015
{
    class classVetor
    {
        public int procura_menor(int[] v) {
            int menor = 11;
            try
            {
                for (int i = 0; i < v.Length; i++)
                {
                    if (v[i] < menor)
                    {
                        menor = v[i];
                    }
                }
            }
            catch (IndexOutOfRangeException erro)
            {
                Console.WriteLine(erro.Message);
            }
            return menor;
        }
        public int procura_maior(int[] v) {
            int maior = 0;
            try
            {
                for (int i = 0; i < v.Length; i++)
                {
                    if (v[i] > maior)
                    {
                        maior = v[i];
                    }
                }
            }
            catch (IndexOutOfRangeException erro)
            {
                Console.WriteLine(erro.Message);
            }
            return maior;
        }
        public int primeira_posicao(int[] v, int num) {
            int posicao = 0;
            try
            {
                for (int i = 0; i < v.Length; i++)
                {
                    if (num == v[i])
                    {
                        posicao = i;
                        i = v.Length;
                    }
                }
            }
            catch (IndexOutOfRangeException erro)
            {
                Console.WriteLine(erro.Message);
            }
            return posicao;
        }
        public int[] todas_posicoes(int[] v, int num) {
            int[] posicao = new int[v.Length];
            try
            {
                for (int i = 0; i < v.Length; i++)
                {
                    if (num == v[i])
                    {
                        posicao[i] = i;
                    }
                    else
                    {
                        posicao[i] = -1;
                    }
                }
            }
            catch (IndexOutOfRangeException erro)
            {
                Console.WriteLine(erro.Message);
            }
            return posicao;
        }
        public int total(int[] v, int num) {
            int total = 0;
            try
            {
                for (int i = 0; i < v.Length; i++)
                {
                    if (num == v[i])
                    {
                        total++;
                    }
                }
            }
            catch (IndexOutOfRangeException erro)
            {
                Console.WriteLine(erro.Message);
            }
            return total;
        }
    }
}
