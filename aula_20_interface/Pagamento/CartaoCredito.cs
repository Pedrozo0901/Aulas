namespace aula_20_interface
{
    public class CartaoCredito : IPagamento, IAnuidade
    {
        public string NumeroCartao {get; set;}
        public DateTime DataVencimento { get; set;}
        public double ValorAnuidade { get; set;}

        // Construtor
        public CartaoCredito(string numeroCartao)
        {
            NumeroCartao = numeroCartao;
        }

        public CartaoCredito(string numeroCartao, DateTime dataVencimento, double valorAnuidade)
        {
            NumeroCartao = numeroCartao;
            DataVencimento = dataVencimento;
            ValorAnuidade = valorAnuidade;
        }

        public void RealizarPagamento(double valor)
        {
            System.Console.WriteLine($" O pagamento R$: {valor} realizado com sucesso com o cartap {NumeroCartao}");            
        }

        public void ExibirComprovante()
        {
            System.Console.WriteLine($"Comprovante de pagamento com cartão {NumeroCartao}");
        }

        // Importar a interface IAnuidade
        public DateTime CalcularDataVencimento()
        {
            return DateTime.Now.AddYears(1);
        }

        public double CalcularValorAnuidade()
        {
            return 100;
        }   
    }
}