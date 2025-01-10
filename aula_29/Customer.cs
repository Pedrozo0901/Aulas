using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_29
{
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int CardNumber { get; set; }
        public int Pin { get; set; }
        public Account Account { get; set; }

        public Customer(string name, string address, int cardNumber, int pin, Account account)
        {
            Name = name;
            Address = address;
            CardNumber = cardNumber;
            Pin = pin;
            Account = account;
        }

        public void VerifyPassword(int senha)
        {
            try
            {
                if (Account.Pin != senha)
                {
                    throw new DomainException("Senha incorreta!");
                }
                Console.WriteLine($"Seja bem-vindo sr(a) {Name}\n");
                    return;
            }
            catch(DomainException e)
            {
                System.Console.WriteLine("Erro: " + e);
            }

            
        }
    }
}