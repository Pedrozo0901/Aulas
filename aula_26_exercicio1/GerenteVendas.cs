using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_26_exercicio1
{
    public class GerenteVendas : Vendedor, iGerente
    {
        protected Regioes sRegiao;

        public GerenteVendas(double salario, double comissao, Regioes regiao) : base(salario, comissao)
        {
            dSalario = salario;
            dComissao = comissao;
            sRegiao = regiao;
        }

        public void autorizar()
        {
            System.Console.WriteLine("O gerente autorizou");
        }

        public bool concedeAumento(Empregado empregado)
        {
            if(empregado.getSalario() < 4000 && empregado.getLicencasPremioRecebidas() < 5)
            {
                return true;
            }
            else{
                return false;
            }
        }

        public bool autorizaLicenca(Empregado empregado)
        {
            if(empregado.getLicencasPremioRecebidas() > 5){
                return false;
            }
            else
            {
                return true;
            }
        }

        public override double getSalario()
        {
            return dSalario + dComissao;
        }

        public Regioes getRegiao()
        {
            return sRegiao;
        }
    }
}