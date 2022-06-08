namespace AlgoritmosCS
{
    //Essa classe contém algoritmos de ordenação por inserção
    class Insertion
    {
        public static void InsertionSort(double[] unsortedList)
        {
            int i = 1; //index do elemento que será movido para trás
            int j = 1; //index do elemento que tentará ser trocado
            double temp = 0; //variável temporária utilizada para efetuar trocas

            //Vai do index 1 até o final da lista
            while (i < unsortedList.Length)
            {
                j = i;//seta o index do item atual da lista para nossa variável j
                      //Enquanto houver um número maior à esquerda e não tivermos passado
                      //cada elemento, em seguida, troque nosso elemento atual uma posição para trás


                while (j > 0 && unsortedList[j - 1] > unsortedList[j])
                {
                    //as proximas 3 linhas irão trocar j e j-1
                    temp = unsortedList[j]; //seta o j na variável temporária
                    unsortedList[j] = unsortedList[j - 1];
                    unsortedList[j - 1] = temp; //move j para j-1
                    j--; //decremento para comparar o próximo elemento para a esquerda

                }
                i++; //mover para o próximo elemento para inserir para trás na lista

            }
        }
    }
}
