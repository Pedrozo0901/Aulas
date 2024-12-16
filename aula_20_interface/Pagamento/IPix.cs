namespace aula_20_interface
{
    public class Pix : IPagamento
    {
        public string? ChavePix { get; set;}
        public string? NomeTitular { get; set; }
        public string? CPF { get; set; }
        public double Valor { get; set; }
        public DateTime DataPagamento { get; set;}

        // Construtor
        public Pix(string chavePix, string nomeTitular, string cpf, double valor, DateTime dataPagamento)
        {
            ChavePix = chavePix;
            NomeTitular = nomeTitular;
            CPF = cpf;
            Valor = valor;
            DataPagamento = dataPagamento;
        }

        public void RealizarPagamento(double valor)
        {
            Valor = valor;
            System.Console.WriteLine($"Pagamento realzado com sucesso! via Pix. {valor}");
        }

        public void ExibirComprovante()
        {
            System.Console.WriteLine("Comprovante de pagamento via Pix");
            System.Console.WriteLine("Chave Pix " + ChavePix);
        }
    }
}