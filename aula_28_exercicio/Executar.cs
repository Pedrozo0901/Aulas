using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_28_exercicio
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta(1, "Felipe da Silva", 3000, 1500);

            conta.Depositar(10000);
            conta.getLimiteDeSaldo();
            conta.Depositar(10000);
            conta.getLimiteDeSaldo();
            conta.Depositar(10000);
            conta.getLimiteDeSaldo();

            conta.Saque(1200);
            conta.Saque(1600);
        }
    }
}