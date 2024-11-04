// Escreva um algoritmo que receba 10 números inteiro e positivos. Em
// seguida o algoritmos deverá mostrar o menor e o maior deles.

using System;

namespace Aula_6
{
    class exercicio1
    {
        static void Teste()
        {


            System.Console.WriteLine("Digite 10 numeros inteiros e positivos a seguir");


            int n1 = int.Parse(System.Console.ReadLine());
            int n2 = int.Parse(System.Console.ReadLine());
            int n3 = int.Parse(System.Console.ReadLine());
            int n4 = int.Parse(System.Console.ReadLine());
            int n5 = int.Parse(System.Console.ReadLine());
            int n6 = int.Parse(System.Console.ReadLine());
            int n7 = int.Parse(System.Console.ReadLine());
            int n8 = int.Parse(System.Console.ReadLine());
            int n9 = int.Parse(System.Console.ReadLine());
            int n10 = int.Parse(System.Console.ReadLine());

            int menor = 0;
            int maior = 0;


                // menor
                if((n1 < n2) && (n1 < n3) && (n1 < n4) && (n1 < n5) && (n1 < n6) && (n1 < n7) && (n1 < n8) && (n1 < n9) && (n1 < n10))
                {
                    menor = n1;
                } else if ((n2 < n1) && (n2 < n3) && (n2 < n4) && (n2 < n5) && (n2 < n6) && (n2 < n7) && (n2 < n8) && (n2 < n9) && (n2 < n10))
                {
                    menor = n2;
                } if((n3 < n1) && (n3 < n2) && (n3 < n4) && (n3 < n5) && (n3 < n6) && (n3 < n7) && (n3 < n8) && (n3 < n9) && (n3 < n10))
                {
                    menor = n3;
                } else if ((n4 < n1) && (n4 < n2) && (n4 < n3) && (n4 < n5) && (n4 < n6) && (n4 < n7) && (n4 < n8) && (n4 < n9) && (n4 < n10))
                {
                    menor = n4;
                } else if ((n5< n1) && (n5 < n2) && (n5 < n3) && (n5 < n4) && (n5 < n6) && (n5 < n7) && (n5 < n8) && (n5 < n9) && (n5 < n10))
                {
                    menor = n5;
                } else if ((n6< n1) && (n6 < n2) && (n6 < n3) && (n6 < n4) && (n6 < n5) && (n6 < n7) && (n6 < n8) && (n6 < n9) && (n6 < n10))
                {
                    menor = n6;
                } else if ((n7< n1) && (n7 < n2) && (n7 < n3) && (n7 < n4) && (n7 < n5) && (n7 < n6) && (n7 < n8) && (n7 < n9) && (n7 < n10))
                {
                    menor = n7;
                } else if ((n8< n1) && (n8 < n2) && (n8 < n3) && (n8 < n4) && (n8 < n5) && (n8 < n6) && (n8 < n7) && (n8 < n9) && (n8 < n10))
                {
                    menor = n8;
                } else if ((n9< n1) && (n9 < n2) && (n9 < n3) && (n9 < n4) && (n9 < n5) && (n9 < n6) && (n9 < n7) && (n9 < n8) && (n9 < n10))
                {
                    menor = n9;
                } else if ((n10< n1) && (n10 < n2) && (n10 < n3) && (n10 < n4) && (n10 < n5) && (n10 < n6) && (n10 < n7) && (n10 < n8) && (n10 < n9))
                {
                    menor = n10;
                } 

                // menor
                if((n1 > n2) && (n1 > n3) && (n1 > n4) && (n1 > n5) && (n1 > n6) && (n1 > n7) && (n1 > n8) && (n1 > n9) && (n1 > n10))
                {
                    maior = n1;
                } else if ((n2 > n1) && (n2 > n3) && (n2 > n4) && (n2 > n5) && (n2 > n6) && (n2 > n7) && (n2 > n8) && (n2 > n9) && (n2 > n10))
                {
                    maior = n2;
                } if((n3 > n1) && (n3 > n2) && (n3 > n4) && (n3 > n5) && (n3 > n6) && (n3 > n7) && (n3 > n8) && (n3 > n9) && (n3 > n10))
                {
                    maior = n3;
                } else if ((n4 > n1) && (n4 > n2) && (n4 > n3) && (n4 > n5) && (n4 > n6) && (n4 > n7) && (n4 > n8) && (n4 > n9) && (n4 > n10))
                {
                    maior = n4;
                } else if ((n5 > n1) && (n5 > n2) && (n5 > n3) && (n5 > n4) && (n5 > n6) && (n5 > n7) && (n5 > n8) && (n5 > n9) && (n5 > n10))
                {
                    maior = n5;
                } else if ((n6 > n1) && (n6 > n2) && (n6 > n3) && (n6 > n4) && (n6 > n5) && (n6 > n7) && (n6 > n8) && (n6 > n9) && (n6 > n10))
                {
                    maior = n6;
                } else if ((n7 > n1) && (n7 > n2) && (n7 > n3) && (n7 > n4) && (n7 > n5) && (n7 > n6) && (n7 > n8) && (n7 > n9) && (n7 > n10))
                {
                    maior = n7;
                } else if ((n8 > n1) && (n8 > n2) && (n8 > n3) && (n8 > n4) && (n8 > n5) && (n8 > n6) && (n8 > n7) && (n8 > n9) && (n8 > n10))
                {
                    maior = n8;
                } else if ((n9 > n1) && (n9 > n2) && (n9 > n3) && (n9 > n4) && (n9 > n5) && (n9 > n6) && (n9 > n7) && (n9 > n8) && (n9 > n10))
                {
                    maior = n9;
                } else if ((n10 > n1) && (n10 > n2) && (n10 > n3) && (n10 > n4) && (n10 > n5) && (n10 > n6) && (n10 > n7) && (n10 > n8) && (n10 > n9))
                {
                    maior = n10;
                } 


            System.Console.WriteLine($" O menor número foi {menor}");
            System.Console.WriteLine($" O maior número foi {maior}");

        } 
    }
}