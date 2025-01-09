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
            try
            {
                customer.VerifyPassword(senha);
                Console.WriteLine($"Cliente identificado no ATM localizado em {Location}");
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }

        public void Transactions(Account account, double amount, string type)
        {
            try
            {
                if (type == "deposito")
                {
                    account.Deposit(amount);
                }
                if (type == "saque")
                {
                    account.Withdraw(amount);
                }
                else{
                    throw new DomainException("Tipo de transação inválido!");
                }  
                Console.WriteLine($"Transação de {type} no valor de {amount} realizada com sucesso.");  
                                   
            }            
            catch (DomainException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }

            
        }
    }   
}