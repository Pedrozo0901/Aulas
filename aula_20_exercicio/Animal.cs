namespace aula_20_exercicio
{
    public class Animal
    {
        protected int Pernas;

        public Animal(int pernas)
        {
            Pernas = pernas = 0;
        }

        public void Caminha()
        {
            System.Console.WriteLine("Caminhando");
        }

        public virtual void Come()
        {
            System.Console.WriteLine("Comendo");
        }
    }
}