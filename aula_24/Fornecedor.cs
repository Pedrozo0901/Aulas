using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_24
{
    public class Fornecedor
    {
        public string Nome {get; set;}
        public Endereco Endereco {get; set;}
        public string CNPJ {get; set;}
        public bool Recorrente {get; set;}
        public double Desconto {get; set;}

        public double CalcularDesconto(double valor)
        {
            if(Recorrente)
            {
                return valor * Desconto;
            }
            return 0;
        }
    }
}