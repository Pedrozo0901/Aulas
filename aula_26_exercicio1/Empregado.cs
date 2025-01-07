using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_26_exercicio1
{
    public abstract class Empregado : Pessoa
    {
        protected double dSalario;
        protected double dSalarioMinimo = 240.00;
        protected int LicencasPremioRecebidas;

        public Empregado()
        {
        }

        public Empregado(double salario)
        {
            dSalario = salario;
        }

        public virtual double getSalario()
        {
            return dSalario;
        }

        public int getLicencasPremioRecebidas()
        {
            return LicencasPremioRecebidas;
        }

        public void setSalario(double dsalario)
        {
            dSalario = dsalario;
        }

        public void setLcencasPremioRecebidas(int licencasPremioRecebidas)
        {
            LicencasPremioRecebidas = licencasPremioRecebidas;
        }

    }
}