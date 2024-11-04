using System;

namespace aula_8
{
    class exercicio3
    {
        static void Teste()
        {
            int[] vetor = new int[] {4,3,3,4};
            int[] inverso = new int[4]; 

            int contador = 3;
            for(int i = 0; i < 4; i++)
            {
                inverso[contador] = vetor[i];
                contador--;
            }
            for(int i = 0; i < 4;i++){
                System.Console.WriteLine(inverso[i]);
            }
            
            int contador2 = 0;
            for(int i = 0; i < 4; i++)
            {
                if(inverso[i] == vetor[i])
                {
                    contador2++;
                } 
            }

            if(contador2 == 4)
            {
                System.Console.WriteLine("É um palindromo!");
            } else{
                System.Console.WriteLine("Não é um palindromo!");
            }
        }
    }
}