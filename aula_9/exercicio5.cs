using System;

namespace aula_9
{
    class Exercicio
    {

        private int[,] Rotaciona90(int[,] matriz)
        {
            int[,] rotacionado = new int[4, 4];
            
            for (int i = 0; i < 4; i++)
            { 
                int contador = 0;
                for (int y = 3; y >= 0; y--)
                {
                    rotacionado[i, contador] = matriz[y, i];
                    contador++;
                }
            }

            return rotacionado;
        }


        public void ExibirRotacao(int[,] matriz)
        {
            int[,] matrizRotacionada = Rotaciona90(matriz);
            
            for (int i = 0; i < matrizRotacionada.GetLength(0); i++)
            {
                for (int j = 0; j < matrizRotacionada.GetLength(1); j++)
                {
                    Console.Write(matrizRotacionada[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        
        static void Main(string[] args)
        {
            Exercicio exercicio = new Exercicio();

            int[,] matriz = new int[,] {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12},
                {13, 14, 15, 16}
            };

            exercicio.ExibirRotacao(matriz);
        }
    }
}
