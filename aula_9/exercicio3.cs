using System;

namespace aula_9
{
    class exercicio3
    {

        static string Palindromo(int[] vetor)
        {
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

            string resposta = "";
            if(contador2 == 4)
            {
                resposta = "É um palindromo!";
            } else{
                resposta = "Não é um palindromo!";
            }
            return resposta;
        }
        static void Teste()
        {
            int[] vetor = {4,2,2,4};

            System.Console.WriteLine(Palindromo(vetor));
        }
    }
}