namespace Aula_18_exercicio
{
    public class Executar 
    {
        static void Main(string[] args)
        {
            Assalariado assalariado = new Assalariado("Felipe", "Pedrozo", "123.456.789.00", 1200.23);
            assalariado.ImprimirDados();
            System.Console.WriteLine(assalariado.Vencimento());  

            System.Console.WriteLine("");

            Comissionado comissionado = new Comissionado("Arthur", "Pereira Gomes", "563.476.139.00", 12, 500);
            comissionado.ImprimirDados();
            System.Console.WriteLine(comissionado.Vencimento()); 

            System.Console.WriteLine("");

            Horista horista = new Horista("Kaua", "Sabados", "843.126.209.00", 120, 8);
            horista.ImprimirDados();
            System.Console.WriteLine(horista.Vencimento()); 
        }
        
    }
}