namespace aula_20_interface
{
    public interface IForma
    {
         double CalcularArea();
         double CalcularPerimetro();

         // Esse tipo de declaração de função
         void ExibirInfrmacoes()
         {
            System.Console.WriteLine("Área: " + CalcularArea());
            System.Console.WriteLine("Perímetro: " + CalcularPerimetro());
         }
    }
}