namespace aula_20_exercicio
{
    public class Cachorro : Animal, AnimalDeEstimacao
    {
        private string _nome;

        public Cachorro(int pernas, string nome) : base(pernas)
        {
            Pernas = pernas;
            _nome = nome;
        }

        public string getNome()
        {
            return _nome;
        }

        public void setNome(string nome)
        {
            _nome = nome;
        }

        public void Brinca()
        {
            System.Console.WriteLine(_nome + " está brincando");
        }

        public void Come()
        {
            System.Console.WriteLine("Comendo: Ração pedigree");
        }
    }
}