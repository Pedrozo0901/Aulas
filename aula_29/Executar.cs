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
            CurrentAccount account1 = new CurrentAccount(1, 1000.0, 1234);
            Customer customer = new Customer("João Silva", "Rua A, 123", 123456, 123, account1);

            ATM atm = new ATM("Farmacia São Leopoldo", bank);
            System.Console.WriteLine();
            bank.ManageATM(atm);

            atm.Identify(customer, 1234); 
            atm.Transactions(account1, 200.0, TypeTransaction.saque); 
            System.Console.WriteLine();
            atm.Transactions(account1, 300.0, TypeTransaction.deposito); 

            System.Console.WriteLine();

            Console.WriteLine($"Saldo final da conta 1: {account1.Balance}");
        }
    }
}
      