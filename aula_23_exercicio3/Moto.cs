using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_23_exercicio3
{
    public class Moto
    {
        public int Cilindrada {get; set;}

        public Moto()
        {
            Cilindrada = 125;
        }

        public Moto(int cilindrada)
        {
            Cilindrada = cilindrada;
        }

        public float CalcularAluguel()
        {
            if(Cilindrada <= 125)
            {
                return 50;
            }
            else if(Cilindrada <= 300)
            {
                return 120;
            }
            else
            {
                return 180;
            }
        }
    }
}