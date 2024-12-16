namespace aula_20_relacoes.Agreacao
{
    public class Professor
    {
        public string Nome;

        public Professor(string nome)
        {
            Nome = nome;
        }

        public void ensinar()
        {
            System.Console.WriteLine("Professor "+ Nome + " está ensinando");
        }
    }
}