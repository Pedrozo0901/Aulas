using System;
using System.Diagnostics;


namespace Aula_13
{
    class exercicio5
    {
        static int[] GerarArrayAleatorio(int tamanho)
        {
            Random random = new Random();
            int[] array = new int[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                array[i] = random.Next(1, 10001); // Números entre 1 e 10000
            }
            return array;
        }

        // Bubble Sort
        static void BubbleSort(int[] vetor)
        {
            int temp;
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                for (int j = 0; j < vetor.Length - i - 1; j++)
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        temp = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = temp;
                    }
                }
            }
        }

        // Selection Sort
        static void SelectionSort(int[] vetor)
        {
            int menor, aux;
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                menor = i;
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[j] < vetor[menor])
                    {
                        menor = j;
                    }
                }
                aux = vetor[i];
                vetor[i] = vetor[menor];
                vetor[menor] = aux;
            }
        }

        // Insertion Sort
        static void InsertionSort(int[] vetor)
        {
            int aux, j;
            for (int i = 1; i < vetor.Length; i++)
            {
                aux = vetor[i];
                j = i - 1;
                while (j >= 0 && vetor[j] > aux)
                {
                    vetor[j + 1] = vetor[j];
                    j--;
                }
                vetor[j + 1] = aux;
            }
        }

        static void Main(string[] args)
        {
            int tamanho = 1000;
            int[] array = GerarArrayAleatorio(tamanho);

            // Criar cópias do array para testar cada algoritmo
            int[] bubbleArray = (int[])array.Clone();
            int[] selectionArray = (int[])array.Clone();
            int[] insertionArray = (int[])array.Clone();

            // Medir o tempo de execução do Bubble Sort
            var stopwatch = Stopwatch.StartNew();
            BubbleSort(bubbleArray);
            stopwatch.Stop();
            long bubbleSortTime = stopwatch.ElapsedMilliseconds;

            // Medir o tempo de execução do Selection Sort
            stopwatch.Restart();
            SelectionSort(selectionArray);
            stopwatch.Stop();
            long selectionSortTime = stopwatch.ElapsedMilliseconds;

            // Medir o tempo de execução do Insertion Sort
            stopwatch.Restart();
            InsertionSort(insertionArray);
            stopwatch.Stop();
            long insertionSortTime = stopwatch.ElapsedMilliseconds;

            // Exibir os resultados
            Console.WriteLine($"Bubble Sort: {bubbleSortTime}ms");
            Console.WriteLine($"Selection Sort: {selectionSortTime}ms");
            Console.WriteLine($"Insertion Sort: {insertionSortTime}ms");

            // Determinar o melhor desempenho
            if (bubbleSortTime <= selectionSortTime && bubbleSortTime <= insertionSortTime)
            {
                Console.WriteLine("Melhor desempenho: Bubble Sort");
            }
            else if (selectionSortTime <= bubbleSortTime && selectionSortTime <= insertionSortTime)
            {
                Console.WriteLine("Melhor desempenho: Selection Sort");
            }
            else
            {
                Console.WriteLine("Melhor desempenho: Insertion Sort");
            }
        }
    }
}