using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aulas.aula_27
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            f.Salario(1000);
            f.Trabalhar();

            Coordenador c = new Coordenador();
            c.Salario(1000);
            c.Trabalhar();

            Gerente g = new Gerente();
            g.Salario(1000);
        }
    }
}