using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_29
{
    public class ATMTransaction : IModify
    {
        public int TransactionId { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public double Amount { get; set; }
        public double PostBalance { get; set; }

        public ATMTransaction(int transactionId, DateTime date, string type, double amount, double postBalance)
        {
            TransactionId = transactionId;
            Date = date;
            Type = type;
            Amount = amount;
            PostBalance = postBalance;
        }
                
        public void Modify(double newAmount)
        {
            Amount = newAmount;
        }
    }
}