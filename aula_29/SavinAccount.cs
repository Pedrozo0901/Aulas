using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_29
{
    public class SavingAccount : Account
    {
        public SavingAccount(int number, double balance, int pin)
            : base(number, balance, pin) { }
    }
}