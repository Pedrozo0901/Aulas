namespace aula_20_interface
{
    public interface IPagamento
    {
        void RealizarPagamento(double valor);   // Isso é implicitamente publico
        void ExibirComprovante();

    }
}