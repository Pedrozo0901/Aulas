using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_33
{
    public class Matriz
    {
        
        static void SomarLinhas(int[,] matriz, int n, int m)
        {
            string path = @"C:\Users\feliperibeiro\Documents\Aulas\Aulas\aula_33\csv\resposta.csv";
            using(StreamWriter sw = new StreamWriter(path, append: false))
            {
                if (n == 0 || m == 0)
                {
                    sw.WriteLine("A matriz está vazia."); 
                }

                string resultado = "";

                for (int i = 0; i < n; i++)
                {
                    int soma = 0;
                    for (int j = 0; j < m; j++)
                    {
                        soma += matriz[i, j];
                    }
                    resultado += $"Soma da linha: {i + 1}: {soma}\n";
                }
                sw.WriteLine(resultado);
                sw.WriteLine();
            }
            
        }



        static void SomarColunas(int[,] matriz, int n, int m)
        {
            string path = @"C:\Users\feliperibeiro\Documents\Aulas\Aulas\aula_33\csv\resposta.csv";
            using(StreamWriter sw = new StreamWriter(path, append: false))
            {
                if (n == 0 || m == 0)
                    sw.WriteLine("A matriz está vazia.");

                string resultado = "";

                for (int i = 0; i < n; i++)
                {
                    int soma = 0;
                    for (int j = 0; j < m; j++)
                    {
                        soma += matriz[j, i];
                    }
                    resultado += $"Soma da coluna: {i + 1}: {soma}\n";
                }
                sw.WriteLine(resultado);
            }
            
           
        }


        static void TransporMatriz(int[,] matriz, int n, int m)
        {
            string path = @"C:\Users\feliperibeiro\Documents\Aulas\Aulas\aula_33\csv\resposta.csv";
            int[,] matrizTransposta = new int[n,m];
            using(StreamWriter sw = new StreamWriter(path, append: false))
            {              
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        matrizTransposta[j,i] = matriz[i,j]; 
                    }
                }
               
                sw.WriteLine("Matriz transposta:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        sw.Write($"{matrizTransposta[i,j]} "); 
                    }
                    sw.WriteLine("");
                }
               
            }
            
        }




        static void Main(string[] args)
        {
            int n;
            int m;

            System.Console.WriteLine("Escreva abaixo o tamanho da matriz.");
            System.Console.WriteLine("Digite o número de linhas:");
            n = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o número de colunas:");
            m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n,m];

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int y = 0; y < m; y++)
                {
                    matriz[i,y] = random.Next(1,101);
                }
            }

            System.Console.WriteLine();

            Console.WriteLine("Matriz:");
            System.Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{matriz[i, j],4}");
                }
                Console.WriteLine();
            }
            System.Console.WriteLine();

            int comando;
            System.Console.WriteLine("Qual operação deseja realizar?");
            System.Console.WriteLine();

            System.Console.WriteLine("0. Parar\n1. Soma das linhas\n2. Soma das Colunas\n3. Transpor a Matriz");
            comando = int.Parse(Console.ReadLine());
            System.Console.WriteLine();
            
            do
            {
                if(comando == 1)
                {
                    SomarLinhas(matriz, n, m);
                }
                else if(comando == 2)
                {
                    SomarColunas(matriz, n, m);
                }
                else if(comando == 3)
                {
                    TransporMatriz(matriz, n, m);
                }
                comando = 0;
                System.Console.WriteLine("0. Parar\n1. Soma das linhas\n2. Soma das Colunas\n3. Transpor a Matriz");
                comando = int.Parse(Console.ReadLine());
                System.Console.WriteLine();
            }
            while(comando != 0);
        }
    }
}