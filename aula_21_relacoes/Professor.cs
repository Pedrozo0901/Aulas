namespace aula_21_relacoes
{
    public class Professor
    {
        // Classe professor, vai ser agregada com a 
        // o da escola, então vai ter relação de agregação

        public string Nome { get; set;}

        public Professor(string nome)
        {
            Nome = nome;
        }
        public void Ensinar()
        {
            System.Console.WriteLine($"Professor: {Nome}" );
        }
    }
}