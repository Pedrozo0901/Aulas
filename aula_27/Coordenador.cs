using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aulas.aula_27
{
    public class Coordenador : Funcionario
    {
        public override void Salario(int salario)
        {
            System.Console.WriteLine("Salário base: " + salario * 1.2);
        }

        public sealed override void Trabalhar()
        {
            System.Console.WriteLine("Coordenando...");
        }
    }
}