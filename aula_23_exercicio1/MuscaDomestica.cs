using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_23_exercicio
{
    public class MuscaDomestica : Musca
    {
        public string Nome {get;set;}

        public MuscaDomestica(string nome)
        {
            Nome = nome;
        }
        public override string obterDescricao() => $"MuscaDomestica -> {Nome}";
    }
}