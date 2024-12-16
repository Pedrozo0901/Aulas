namespace aula_20_interface.Espaco
{
    public class Circulo : IForma
    {
        // Propriedade Raio
        public double Raio {get; set;}

        // Construtor

        public Circulo(double raio)
        {
             Raio = raio;
        }

        // Implemtanção do metodo calcular area
        public double CalcularArea()
        {
            return Mah.PI * Math.Pow(Raio, 2);
        }

        public double CalcularPerimetro()
        {
            return 2* Math.PI * Raio;
        }

        public void ExibirInfrmacoes()
        {
            System.Console.WriteLine("Ciruclo");
            System.Console.WriteLine("Raio: " + Raio);
        }
    }
}