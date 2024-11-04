using System;

namespace aula_8
{
   class matriz_tridimensional
   {
        static void Teste()
        {
           int[,,] matriz3D = new int[2,2,2] {
                {
                    {1,2},
                    {3,4}
                },
                {
                    {5,6},
                    {7,8}
                }
            };

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j< 2; j++)
                {
                    for(int k = 0; k < 2; k++)
                    {
                        System.Console.WriteLine($"[{i},{j}, {k}] = {matriz3D[i,j,k]}");
                    }
                }
            }

            System.Console.WriteLine(matriz3D[1,1,1]);
            System.Console.WriteLine(matriz3D[0,0,0]);

            matriz3D[1,1,1] = 100;
            Console.WriteLine(matriz3D[1,1,1]);

            int soma= 0;
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j< 2; j++)
                {
                    for(int k = 0; k < 2; k++)
                    {
                        soma += matriz3D[i,j,k];
                    }
                }
            }
            System.Console.WriteLine(soma);
            System.Console.WriteLine("");

            // aceesar todos os eementos da matriz
            foreach(int item in matriz3D)
            {
                System.Console.WriteLine(item);
            }
        }
   }
    
}