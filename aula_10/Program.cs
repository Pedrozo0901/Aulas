using System;

namespace Aula_10
{
    class Program
    {

        static int ParImpar(double num)
        {
            if(num % 2 == 0)
            {
                return 0;
            } else
            {
                return 1;
            }

        }

        static void double Pi()
        {
          System.Console.WriteLine("3.14");
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite um número: ");
            double num = double.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Número é: " + ParImpar(num));

            System.Console.WriteLine(Pi());
        }
    }
}