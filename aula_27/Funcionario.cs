using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aulas.aula_27
{
    public class Funcionario
    {
        public string Nome {get; set;}

        public virtual void Salario(int salario)
        {
            System.Console.WriteLine("Salário base: " + salario);
        }

        public virtual void Trabalhar()
        {
            System.Console.WriteLine("Trabalhando...");
        }
    }
}