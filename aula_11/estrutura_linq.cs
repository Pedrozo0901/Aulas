using System;

namespace Aula_11
{
    class Estrutura_linq
    {
        static void teste()
        {
            int[] numeros = {1,2,3,4,5,6,7,8,9,10};

            var numerosImpares = numeros.Where(n => n % 2 != 0);

            foreach( var numero in numerosImpares)
            {
                System.Console.WriteLine(numero);
            }
        }
    }
}