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
        public List<Account> Accounts { get; set; } = new List<Account>();

        public Customer(string name, string address, int cardNumber, int pin)
        {
            Name = name;
            Address = address;
            CardNumber = cardNumber;
            Pin = pin;
        }

        public void VerifyPassword(int senha)
        {
            foreach (var account in Accounts)
            {
                if (account.Pin == senha)
                {
                    Console.WriteLine($"Seja bem-vindo sr(a) {Name}");
                    return;
                }
            }

            throw new DomainException("Senha incorreta!");
        }
    }
}