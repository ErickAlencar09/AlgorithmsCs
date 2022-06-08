
namespace AlgoritmosCS
{
    class Program
    {
        static void Main(string[] args)           
        {
            /* double[] listaDesorganizada = { 10, 4, 8, 6, 7 };            
            for (int i = 0; i < listaDesorganizada.Length; i++)
            {
                Insertion.InsertionSort(listaDesorganizada);
                Console.Write($"{listaDesorganizada[i]} , ");
            }
            Console.WriteLine("\n");
            */

             int[] listaDesorganizada2 = { 20, 5, 1, 3, 10, 15, 2 };
            for(int i=0; i<listaDesorganizada2.Length; i++)
            {
                Swap.BubbleSort(listaDesorganizada2);
                Console.Write($"{listaDesorganizada2[i]} ,");
            } 

            /*
            int[] listaDesorganizada3 = { 9, 4, 8, 10, 1, 40, 30 };

            for (int i = 0; i<listaDesorganizada3.Length; i++)
            {
                Selection.SelectionSort(listaDesorganizada3);
                Console.Write($"{listaDesorganizada3[i]} ,");
            }
            */


        }
    }
}
