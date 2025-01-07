using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_26_exercicio1
{
    public class Pessoa
    {
        protected string sName;

        public Pessoa()
        {

        }

        public Pessoa(string sname)
        {
            sName = sname;
        }

        public void setName(string name)
        {
            sName = name;
        }

        public string getName()
        {
            return sName;
        }
    }
}