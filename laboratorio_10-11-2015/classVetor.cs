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
            for (int i = 0; i < v.Length; i++) {
                if (v[i] < menor) {
                    menor = v[i];
                }
            }
            return menor;
        }
        public int procura_maior(int[] v) {
            int maior = 0;
            for (int i = 0; i < v.Length; i++) {
                if (v[i] > maior) {
                    maior = v[i];
                }
            }
            return maior;
        }
        public int primeira_posicao(int[] v, int num) {
            int posicao = 0;
            for (int i = 0; i < v.Length; i++) {
                if (num == v[i]) {
                    posicao = i;
                    i = v.Length;
                }
            }
            return posicao;
        }
        public int[] todas_posicoes(int[] v, int num) {
            int[] posicao = new int[20];
            for (int i = 0; i < v.Length; i++) {
                if (num == v[i])
                {
                    posicao[i] = i;
                }
            }
            return posicao;
        }
    }
}
