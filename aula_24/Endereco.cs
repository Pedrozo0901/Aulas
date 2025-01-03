using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_24
{
    public class Endereco
    {
        // Utilizando propriedades auto-implementados
        public string Rua {get; set;}
        public string Cidade {get; set;}
        public string Estado {get; set;}
        public int CEP {get; set;}

        public Endereco(string rua, string cidade, string estado, int cep)
        {
            Rua = rua;
            Cidade = cidade;
            Estado = estado;
            CEP = cep;
        }
    }
}