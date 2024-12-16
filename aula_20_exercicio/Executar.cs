namespace aula_20_exercicio
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Formiga formiga = new Formiga(8);
            System.Console.WriteLine("A formiga está:");
            formiga.Come();

            System.Console.WriteLine();

            Peixe peixe = new Peixe(0, "Nemo");
            peixe.setNome("Nemo II");
            System.Console.WriteLine(peixe.getNome());
            peixe.Brinca();
            peixe.Come();
            
            System.Console.WriteLine();

            Cachorro cachorro = new Cachorro(3, "Pituco");
            cachorro.getNome();
            cachorro.setNome("Thor");
            System.Console.WriteLine(cachorro.getNome()); 
            cachorro.Brinca();
            

        }
        
    }
}