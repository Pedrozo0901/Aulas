namespace aula_17_desafio
{
    public class Cobra : Animal
    {
        public bool Venenosa; 

        public Cobra(bool vivo, bool venenosa) : base(vivo)
        {
            this.Venenosa = venenosa;
        }

        public void Alimento(string alimento){
            System.Console.WriteLine("Comendo: " + alimento);
        }

        public void setVenenosa(bool venenosa)
        {
            this.Venenosa = venenosa;
        }

        public void ExibirDados()
        {
            System.Console.WriteLine("Animal: Cobra");
            System.Console.WriteLine("Vivo: " + this.Vivo);
            System.Console.WriteLine("Venenosa: " + this.Venenosa);
        }
    }

}