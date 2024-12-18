namespace aula_21_relacoes
{
    public class Executar
    {
        static void Main(string[] args)
        {
            // Criar um objeto do tipo escola
            Escola escola = new Escola("João");


            // Criar um objeto do tipo professor
            Professor professor = new Professor("Maria");

            // Contratar o professor
            escola.ContratarProfessor(professor);

            // Monstraar informações
            escola.MostrarInfo();
        }
    }
}