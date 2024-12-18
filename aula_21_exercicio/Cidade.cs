using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_21_exercicio
{
    public class Cidade
    {
        public string Nome { get; set; }
        public Estado Estado { get; set; } // Associação com Estado

        public Cidade(string nome, Estado estado)
        {
            Nome = nome;
            Estado = estado;
        }
    }
}