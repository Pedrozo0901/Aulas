using System;

namespace aula_9
{
    class exercicio2
    {
        public delegate int Operacao(int[,] Valores);

        static int SomaValores(int[,] matriz)
        {
            int soma = 0;
            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    soma += matriz[i,j];
                }
            }
            return soma;
        }
        static void Teste()
        {
            Operacao soma = new Operacao(SomaValores);

            int[,] matriz =  new int[4,4] {
                {1,2,3,4},
                {5,6,7,8},
                {9,10,11,12},
                {13,14,15,16}
            };


            System.Console.WriteLine(soma(matriz));

        }
    }
}