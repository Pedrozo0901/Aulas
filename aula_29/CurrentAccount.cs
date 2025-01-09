using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_29
{
    public class CurrentAccount : Account
    {
        public CurrentAccount(int number, double balance, int pin)
            : base(number, balance, pin) { }

        public override void Withdraw(double amount)
        {
            try{
                if (amount <= 0 || amount > Balance)
                {
                    throw new DomainException("Saldo insuficiente para saque!");
                }
                Balance -= amount;

                CreateTransaction("Saque", amount);
            }
            catch(DomainException e)
            {
                System.Console.WriteLine("Erro: " + e);
            }
            
        }
    }
}