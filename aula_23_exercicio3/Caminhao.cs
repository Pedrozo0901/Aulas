using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_23_exercicio3
{
    public class Caminhao : Veiculo
    {
        public int Eixos {get; set;}

        public Caminhao(int eixos)
        {
            Eixos = eixos;
        }

        public float CalcularAluguel()
        {
            if(Eixos == 1)
            {
                return 1200;
            }
            else if(Eixos == 2)
            {
                return 1900;
            }
            else if(Eixos == 3)
            {
                return 2400;
            }
            else
            {
                return 0;
            }
        }
    }
}