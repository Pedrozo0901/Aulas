// Ler um vetor com 10 inteiros e mostrar os números na ordem direta e
// inversa a que foram lidos.

using System;

namespace aula_7;
class Exercicio1
{
    static void Teste()
    {
         int[] numeros = {1,2,3,4,5,6,7,8,9,10};
        
        Console.WriteLine("Ordem dos números:");
        for(int i = 0; i < 10; i++){
            Console.WriteLine(numeros[i]);
        }
        Console.WriteLine("Ordem inversa:");
        for(int j = 9; j >= 0; j--){
            Console.WriteLine(numeros[j]);
        }
        
    }
}