namespace aula_20_interface
{
    public interface IAnuidade
    {
        // Função para calcular a data de vencimento
        DateTime CalcularDataVencimento();

        // Fução para calcular valor da anuidade
        double CalcularValorAnuidade();
    }
}