namespace aula_19_fixacao
{
    public class Academia
    {
        public string Nome { get; set; }
        private double Mensalidade { get; set; } // Classe exteior com erro de acesso

        public Academia()
        {
        }

        public Academia(string nome, double mensalidade)
        {
            Nome = nome;
            Mensalidade = mensalidade;
        }
    }
}