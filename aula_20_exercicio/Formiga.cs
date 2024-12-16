namespace aula_20_exercicio
{
    public class Formiga : Animal
    {
        public Formiga(int pernas) : base(pernas)
        {
            Pernas = pernas;
        }

        public void Come()
        {
            System.Console.WriteLine("Comendo: folha");
        }
    }
}