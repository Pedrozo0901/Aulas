using System;

namespace aula_7
{
public class Revisao_matriz
{
    public static void Main(string[] args)
    {
        int[,] matriz = new int[3, 3]{
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int[,] transposta = new int[3,3];

        for (int i = 0; i < transposta.GetLenght(0); i++)
        {
            for (int j = 0; j < transposta.GetLenght(1) ; j++)
            {
                transposta[j,i] = matriz[i,j];
            }
            System.Console.WriteLine();
        }

        for (int i = 0; i < transposta.GetLenght(0); i++)
        {
            for (int j = 0; j < transposta.GetLenght(1) ; j++)
            {
                System.Console.WriteLine(transposta[j,i] + " ");
            }
            System.Console.WriteLine();
        }
                
    }
}
}
