using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosCS
{
	//Essa classe contém algoritmos de ordenação por troca
    class Swap
    {
		public static int[] BubbleSort(int[] vetor)
		{
			int tamanho = vetor.Length;
			int comparacoes = 0;
			int trocas = 0;
			for (int i = tamanho - 1; i >= 1; i--)
			{
				for (int j = 0; j < i; j++)
				{
					comparacoes++;
					if (vetor[j] > vetor[j + 1])
					{
						int aux = vetor[j];
						vetor[j] = vetor[j + 1];
						vetor[j + 1] = aux;
						trocas++;
					}
				}
			}
			return vetor;
		}
	}
}
