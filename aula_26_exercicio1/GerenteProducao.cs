using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_26_exercicio1
{
    public class GerenteProducao : Empregado, iGerente
    {
        public void autorizar()
        {
            System.Console.WriteLine("O gerente de produção aprovou");
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

        public override double getSalario()
        {
            return dSalario;
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
    }
}