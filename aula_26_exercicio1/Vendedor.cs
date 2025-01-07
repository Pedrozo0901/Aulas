using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_26_exercicio1
{
    public class Vendedor : Empregado
    {
        protected double dComissao;

        public Vendedor(double salario, double comissao) : base(salario)
        {
            dSalario = salario;
            dComissao = comissao;
        }

        public override double getSalario()
        {
            return dSalario + dComissao;
        }

    }
}