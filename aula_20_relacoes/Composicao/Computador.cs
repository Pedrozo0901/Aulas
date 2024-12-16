namespace aula_20_relacoes.Composicao
{
    public class Computador
    {
        public Processador processador;

        public Computador()
        {
            processador = new Processador;
        }

        void iniciar()
        {
            Console.WriteLine("Iniciando...");
            processador.processar();
        }

        
    }
}

// a composição é quando a classe principal contem partes essenciais que não pode existir sem ela