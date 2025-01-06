using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_25_exercicio
{
    public class Client
    {
        public string Name {get; set;}
        public string Email {get; set;}
        public Date BirthDate {get; set;}

        public Client(string name, string email, Date birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
    }
}