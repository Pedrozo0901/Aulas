using System;

namespace Aula_11
{
    class Recursao
    {
        static int[] ObterPares(int[] vetor, int indice = 0) {
            if(indice >= vetor.Length)
            {
                return new int[0];
            } 
            
            // Chama recursivamene os pares restantes no vetor
            int[] paresRestantes = ObterPares(vetor, indice + 1);
            
            if(vetor[indice] % 2 == 0)
            {
                int[] resultado = new int[paresRestantes.Length + 1];
                resultado[0] = vetor[indice];
                paresRestantes.CopyTo(resultado, 1);
                return resultado;
            }
            else
            {
                return paresRestantes;
            }
        }

        static void Main(string[] args)
        {
            int[] vetor = {1,2,3,4,5,6,7,8,9,10};
            int[] pares = ObterPares(vetor);

            foreach(var num in pares)
            {
                System.Console.WriteLine(num);
            }
        }
    }
}