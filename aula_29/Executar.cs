using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_29
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank("1", "Rua Spipe Calarge, 4330");

            Customer customer = new Customer("João Silva", "Rua A, 123", 123456, 1234);
            CurrentAccount account1 = new CurrentAccount(1, 1000.0, 1234);
            SavingAccount account2 = new SavingAccount(2, 500.0, 5678);

            customer.Accounts.Add(account1);
            customer.Accounts.Add(account2);

            ATM atm = new ATM("Farmacia São Leopoldo", bank);
            bank.ManageATM(atm);

            atm.Identify(customer, 1234); 
            atm.Transactions(account1, 200.0, "saque"); 
            atm.Transactions(account2, 300.0, "deposito"); 

            Console.WriteLine($"Saldo final da conta 1: {account1.Balance}");
            Console.WriteLine($"Saldo final da conta 2: {account2.Balance}");
        }
    }
}




        