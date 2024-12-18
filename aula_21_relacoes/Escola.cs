namespace aula_21_relacoes
{
    public class Escola
    {
        private Aluno estudante;
        private Professor professor;

        // Construtor da escola
        // Que vai mostrar a relação e a composição

        public Escola(string nomeEsudante)
        {
            // Aqui que muda, pois a escola vai ter um aluno como
            // parte dela, então vai ser uma relação de composição
            estudante = new Aluno(nomeEsudante);
        }

        // Método para Agregação (que recebe de forma externa)
        // o professor

        public void ContratarProfessor(Professor professor)
        {
            this.professor = professor;
        }

        // Mostrar informações
        public void MostrarInfo()
        {
            System.Console.WriteLine($"Nome do Aluno: {estudante.Nome}");
            System.Console.WriteLine($"Nome do professor: {professor.Nome}");
            professor.Ensinar();
        }
    }
}