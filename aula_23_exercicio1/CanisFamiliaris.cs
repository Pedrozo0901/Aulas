using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_23_exercicio
{
    public class CanisFamiliaris : Canis
    {
        public string Nome {get;set;}

        public CanisFamiliaris(string nome)
        {
            Nome = nome;
        }
        public override string obterDescricao() => $"CanisFamiliaris -> {Nome}";
    }
}