using System;

namespace Aula_11
{
    class Funcao_recursiva
    {
        static int Fatorial(int n)
        {
            if(n == 1)
            {
                return 1;
            } else
            {
                return n * Fatorial(n - 1);
            }
        }
        
        // fibonacci
        static int Fibonacci(int n)
        {
            if(n <= 1)          
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static int Fatorial2(int n)
        {
            int fatorial = 1;
            for(int i= 1; i <= n; i++)
            {
                fatorial *= i;
            }
            return fatorial;
        }

        static int Fibonacci2(int n)
        {
            int a = 0, b = 1, c = 1;
            for(int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
        static void Teste()
        {
            System.Console.WriteLine("Digite um numero:");
            int numero = int.Parse(System.Console.ReadLine());

            int resultado = Fibonacci(numero);

            System.Console.WriteLine("O fatoral de " + numero + " é " + Fatorial(numero));
            System.Console.WriteLine($"O resultado do fibonacci é: {resultado}");
            System.Console.WriteLine("O fatorial de: " +  numero + " é " + Fatorial2(numero));
        }
    }
}