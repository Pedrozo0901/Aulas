using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aulas.aula_27
{
    public sealed class Gerente : Funcionario
    // sealed nõo pode sre herdado
    {
        public override void Salario(int salario)
        {
            System.Console.WriteLine("Salário base: " + salario * 1.5);
        }

        public override void Trabalhar()
        {
            System.Console.WriteLine("Gerenciando...");
        }
    }
}