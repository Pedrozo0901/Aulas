using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_29
{
    public class Bank
    {
        public string Code { get; set; }
        public string Address { get; set; }
        public List<ATM> Atms { get; set; } 

        public Bank(string code, string address)
        {
            Code = code;
            Address = address;
            Atms = new List<ATM>();
        }

        public void ManageATM(ATM atm)
        {
            Atms.Add(atm);
            Console.WriteLine($"ATM adicionado e gerenciado pelo banco de código {Code}");
        }
    }
}