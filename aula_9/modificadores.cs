using System;

namespace Aul_9
{
    public class Modificadores
    {
        public int soma(int a, int b){
            return a + b;
        }
        public int subtracao(int a, int b){
            return a - b;
        }
        static void Teste()
        {
            Modificadores m = new Modificadores();
            System.Console.WriteLine(m.soma(10,20));

        }
    }
}