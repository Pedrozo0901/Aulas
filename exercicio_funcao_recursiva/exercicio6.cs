// Faça um programa que calcule a média dos elementos de um vetor de inteiros.

// ######### meu código

// using System;

// namespace Exercicio_funcao_recursiva
// {
//     class Exercicio6
//     {
//         static int SomaVetor(int[] vetor, int tamanho)
//         {
//             int soma = 0;
//             if(tamanho == 0)
//             {
//                 return 0;
//             } else {
//                 return vetor[tamanho -1] += SomaVetor(vetor, tamanho -1);
//             }
//         }
//         static void Teste(string[] args)
//         {
//             int[] vetor = {4,5,6,7,8};
//             int tamanho = vetor.Length;
            
//             System.Console.WriteLine($"A média do vetor é: {SomaVetor(vetor, tamanho) / tamanho}");
//         }
//     }
// }

// ####### Códgio professor

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_10
{
    public class Exercicio6
    {
        static int Soma(int[] vetor, int index)
        {
            if (index < 0)
            {
                return 0;
            }
            return vetor[index] + Soma(vetor, index - 1);
        }

        // Fazer função que soma vetor e também calcula a média
        // static (int, double) SomaMediaVetor(int [] vetor, int index) 
        // {
        //     if (index < 0)
        //     {
        //         return (0, 0);
        //     }
        //     var (soma, media) = SomaMediaVetor(vetor, index - 1);
        //     return (vetor[index] + soma, (vetor[index] + soma) / (index + 1));
        //     // return (int, double)
        
        // }
        static (int, double) SomaMediaVetor(int[] vetor, int index, int tamanho)
        {
            if (index < 0)
                return (0, 0.0);

            // Chamada recursiva
            (int somaParcial, double _) = SomaMediaVetor(vetor, index - 1, tamanho);
            int somaTotal = somaParcial + vetor[index];

            double media = (double)somaTotal / tamanho;

            return (somaTotal, media);
        }
        static void Main()
        {
            // Console.WriteLine("Digite o tamanho do vetor: ");
            // int tamanho = int.Parse(Console.ReadLine());
            // int [] vetor = new int[tamanho];

            // for (int i = 0; i < tamanho; i++)
            // {
            //     Console.WriteLine("Digite o valor da posição " + i + ": ");
            //     vetor[i] = int.Parse(Console.ReadLine());
            // }

            // int soma = Soma(vetor, tamanho - 1);
            // double media = (double)soma / tamanho;
            // Console.WriteLine("A soma dos elementos do vetor é: " + soma);

            Console.Write("Digite o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());
            int[] vetor = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o elemento {i + 1}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            (int soma, double media) = SomaMediaVetor(vetor, tamanho - 1, tamanho);
            Console.WriteLine($"A soma dos elementos do vetor é: {soma}");
            Console.WriteLine($"A média dos elementos do vetor é: {media}");
        }
    }
}