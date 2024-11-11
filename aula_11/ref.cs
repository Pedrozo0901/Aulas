using System;

namespace Aula_11
{
    class Ref
    {

        static int Quadrado(int x)
        {
            return x*x;
        }

        static void QuadradoRef(ref int x)
        {
            x = x * x;
        }

        static int QuadradoOut(out int x)
        {
            x = 12;
            return x * x;
        }


        static void Teste()
        {
           
            int a = 10;
            System.Console.WriteLine(Quadrado(a));
            System.Console.WriteLine(a);
            QuadradoRef(ref a);
            System.Console.WriteLine(a);

            int c;

            System.Console.WriteLine(QuadradoOut(out c));

        }
    }
}