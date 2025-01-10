using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_29
{
    public class ATM
    {
        public string Location { get; set; }
        public Bank ManagedBy { get; set; }

        public ATM(string location, Bank managedBy)
        {
            Location = location;
            ManagedBy = managedBy;
        }

        public void Identify(Customer customer, int senha)
        {
            customer.VerifyPassword(senha);
            Console.WriteLine($"Cliente identificado no caixa eletrônico localizado em {Location}");  
        }

        public void Transactions(Account account, double amount, TypeTransaction type)
        {
            try
            {
                if(type != TypeTransaction.deposito && type != TypeTransaction.saque)
                {
                    throw new DomainException("Tipo de transação inválido!");
                }
                if (type == TypeTransaction.deposito)
                {
                    account.Deposit(amount);
                }
                if (type == TypeTransaction.saque)
                {
                    account.Withdraw(amount);
                }
                Console.WriteLine($"Transação de {type} no valor de {amount} realizada com sucesso.");         
            }            
            catch(DomainException e)
            {
                System.Console.WriteLine("Erro: " + e);
            }
        }
    }   
}