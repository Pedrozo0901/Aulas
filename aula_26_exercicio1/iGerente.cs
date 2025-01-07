using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_26_exercicio1
{
    public interface iGerente
    {
        public void autorizar();
        public bool concedeAumento(Empregado empregado);
        public bool autorizaLicenca(Empregado empregado);
    }
}