// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Aula_16_OO_Heranca
// {
//     public class Executar
//     {
//         static void Main(string[] args)
//         {
//             // Instanciando um objeto do tipo Gerente
//             Gerente gerente = new Gerente("João", "123.456.789-00", 5000, "TI");
//             System.Console.WriteLine("Mostrar o salario do gerente: " + gerente.Salario);
//             System.Console.WriteLine("Mostrar a bonificação do gerente: " + gerente.GetBonificacao());
//             gerente.GerenciarEquipe();
//             gerente.ImprimirDados();

//             System.Console.WriteLine("");

//             Secretaria secretaria = new Secretaria("Maria", "154.236.459-01", 1800, "Almocherifado");
//             System.Console.WriteLine("Mostrar o salario da Secretaria: " + secretaria.Salario);
//             System.Console.WriteLine("Mostrar a bonificação da secretaria: " + secretaria.GetBonificacao());
//             secretaria.AtenderTelefone();
//             secretaria.ImprimirDados();

//             System.Console.WriteLine("");

//             Telefonista telefonista = new Telefonista("Maria", "154.236.459-01", 1800, "Sala 12");
//             System.Console.WriteLine("Mostrar o salario da telefonista: " + telefonista.Salario);
//             System.Console.WriteLine("Mostrar a bonificação da telefonista: " + telefonista.GetBonificacao());
//             telefonista.AtenderTelefone();
//             telefonista.ImprimirDados();
//         }
//     }
// }