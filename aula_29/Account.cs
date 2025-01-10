using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_29
{
    public abstract class Account
    {
        public int Number { get; set; }
        public double Balance { get; set; }
        public int Pin { get; set; }
        public List<ATMTransaction> Transactions { get; set; } = new List<ATMTransaction>();

        public Account(int number, double balance, int pin)
        {
            Number = number;
            Balance = balance;
            Pin = pin;
        }

        public virtual void Deposit(double amount)
        {
            try
            {
                if (amount <= 0)
                {
                    throw new DomainException("O valor do depósito deve ser positivo!");
                }
                Balance += amount;

                CreateTransaction("deposito", amount);
            }
            catch(DomainException e)
            {
                System.Console.WriteLine("Erro: " + e);
            }
            
        }

        public virtual void Withdraw(double amount)
        {
            try{
                if (amount <= 0 || amount > Balance)
                {
                    throw new DomainException("Saque inválido!");
                }
                Balance -= amount;

                CreateTransaction("saque", amount);
            }
            catch(DomainException e)
            {
                System.Console.WriteLine("Erro: " + e);
            }
        }

        public void CreateTransaction(string type, double amount)
        {
            ATMTransaction transaction = new ATMTransaction(Transactions.Count + 1, DateTime.Now,type, amount, Balance                 
            );

            Transactions.Add(transaction);
            Console.WriteLine($"Transação criada: {type}, Valor: {amount}, Saldo Atual: {Balance}");
        }

    }

    public class SavingAccount : Account
    {
        public SavingAccount(int number, double balance, int pin)
            : base(number, balance, pin) { }
    }

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