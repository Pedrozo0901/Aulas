using System;

namespace aula_8
{
    class exercicio5
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[,] {
                {1,2,3,4},
                {5,6,7,8},
                {9,10,11,12},
                {13,14,16,17}
            };

            int[,] rotacionado = new int[4,4];
            

            for(int i = 0; i < 4; i++)
            { 
                int contador = 0;
                for(int y = 3; y >= 0; y--)
                {
                    rotacionado[i,contador] = matriz[y,i];
                    contador++;
                }
                
            }

            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Console.Write(rotacionado[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}