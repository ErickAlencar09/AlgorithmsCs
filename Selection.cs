using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosCS
{
	//Essa classe contém algoritmos de ordenação por seleção
    class Selection
    {
		public static int[] SelectionSort(int[] vetor)
		{
			int min, aux;
			for (int i = 0; i < vetor.Length - 1; i++)
			{
				min = i;
				for (int j = i + 1; j < vetor.Length; j++)
					if (vetor[j] < vetor[min])
						min = j;

				if (min != i)
				{
					aux = vetor[min];
					vetor[min] = vetor[i];
					vetor[i] = aux;
				}
			}
			return vetor;
		}
	}
}
