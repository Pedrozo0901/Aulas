using System;

namespace aula_8
{
    class exercicio2
    {
        static void Teste()
        {
            int[,] matriz = new int [4,4] {
                {1,2,3,4},
                {5,6,7,8},
                {9,10,11,12},
                {13,14,15,16}
            };

            int[] soma = new int[4];
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    soma[i] += matriz[i,j];
                }
            }

            for(int i = 0; i < 4; i++)
            {
                System.Console.WriteLine(soma[i]);
            }
            
        }
    }
}