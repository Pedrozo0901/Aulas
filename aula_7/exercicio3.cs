// 3. Ler uma matriz 4 x 4 e calcular a soma do maior com o menor elemento
// da matriz.

using System;

namespace aula_7;
class exercicio3
{
    static void Teste()
    {
        int[,] matriz = new int[4,4];
        Random r = new Random();
        
        for(int i = 0; i < 4;i++)
        {
            for(int j = 0; i < 4; i++)
            {
                matriz[i,j] = r.Next(10);
            }
        }
        int maiorNum = matriz[0,0];
        int menorNum = matriz[0,0];
        
        for(int j =0; j < 4; j++)
        {
            for(int y =0; y < 4; y++)
            {
                if(matriz[j,y] > maiorNum)
                {
                    maiorNum = matriz[j,y];
                }
                if(matriz[j,y] < menorNum)
                {
                    menorNum = matriz[j,y];
                }
            }
        }
        Console.WriteLine($"A soma do maior e menor é: {maiorNum + menorNum}");
    }
    
}