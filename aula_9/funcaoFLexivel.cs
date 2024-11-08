using System;

namespace Aul_9
{
    public class FuncaoFlexivel
    {

        public delegate int Operacao(int a, int b);

        // Expressão lambda

        static int Soma(int a, int b) => a + b;
        // sso é mesmo que isso aqui
        // static omt Soma(int a, it b){
        // return a + b;
        // }

        // juntar 2 função no delegate
        public delegate void Notificar();
        public static void EnviarEmail() => Console.WriteLine("Email enviado");
        public static void EnviarSMS() => Console.WriteLine("SMS enviado");
        static void Teste()
        {
            Operacao op = Soma;
            System.Console.WriteLine(op(3,2)); // 5

            // Atribuir dretamente a expressão lambda
            Operacao op2 = (int a, int b) => a * b;
            System.Console.WriteLine(op2(3,2)); // 6

            // metodos anonimos fora um das primeiras maneiras de criar função
            Func<int, int, int> op3 = delegate(int a, int b) { return a - b;};
            System.Console.WriteLine(op3(3,2));

            // delagee multicast
            Notificar notificar = EnviarEmail;
            notificar += EnviarSMS;
            notificar(); 
        }
    }
}