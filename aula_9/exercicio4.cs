using System;

namespace aula_9
{
    class exercicio4
    {

        static string SomaDiagonal(int[,] matriz)
        {
            int somaDiagonal1 = 0;
            for(int i = 0; i < 3; i++)
            {
                somaDiagonal1 += matriz[i,i];
            }

            int somaDiagonal2 = 0;
            for(int j = 2; j > 0; j--)
            {
                somaDiagonal2 += matriz[j,j];
            }

            string resposta = ($"Soma da diagonal primaria: {somaDiagonal1}, da secundaria: {somaDiagonal2}");
            return resposta;
            
        }
        static void Teste()
        {
            int[,] matriz = new int [,] {
                {10,2,3},
                {4,20,6},
                {7,8,10}
            };

            System.Console.WriteLine(SomaDiagonal(matriz));
        }
    }
}