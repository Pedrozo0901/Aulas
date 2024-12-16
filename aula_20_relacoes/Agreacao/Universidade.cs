namespace aula_20_relacoes.Agreacao
{
    public class Universidade
    {
        public Professor professor;

        public Universidade(Professor preofessor)
        {
            this.professor = professor;
        }
        
        public void realizarAula()
        {
            System.Console.WriteLine("Realizando aula...");
            professor.ensinar();
        }
    }

}