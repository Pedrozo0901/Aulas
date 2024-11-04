using System;

namespace aula_8
{
    class exercicio4
    {
        static void Teste()
        {
            int[,] matriz = new int[,] {
                {1,2,3,4},
                {5,6,7,8},
                {9,10,11,12},
                {13,14,16,17}
            };

            int diagonalPrincipal = 0;
            int diagonalSecundaria = 0;

            for(int i = 0; i < 4; i++)
            {
                diagonalPrincipal += matriz[i,i];
            }

            for(int i = 3; i > 0; i--)
            {
                diagonalSecundaria += matriz[i,i];
            }

            System.Console.WriteLine($"soma da matriz principal: {diagonalPrincipal} \n soma da matriz principal: {diagonalSecundaria}");
        }
    }
}