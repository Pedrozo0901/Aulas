namespace aula_25_enum
{
    public enum Estado
    {
        namespace Aula_21_OO.Desafio_3

        SP,
        RJ,
        MG,
        BA
    }

    public class EstecaoEstado {
        public static string GetDescricao(Estado estado) {
            switch (estado) {
                case Estado.SP:
                    return "São Paulo";
                case Estado.RJ:
                    return "Rio de Janeiro";
                case Estado.MG:
                    return "Minas Gerains";
                case Estado.BA:
                    return "Bahia";
                default:
                return "Estado não encontrado";
            }
        }

    }

    public class Regiao
    {
        public string[] Regioes = new string[] { "Sul", "Sudeste", "Centro-Oeste", "Norte", "Nordeste"};

        public string GetRegiao(Estado estado)
        {
            return estado switch
            {
                Estado.SP => Regioes[1],
                Estado.RJ => Regioes[1],
                Estado.MG => Regioes[1],
                Estado.BA => Regioes[4],
                _ => "Região não encontrada"
            }
        }
    }

}