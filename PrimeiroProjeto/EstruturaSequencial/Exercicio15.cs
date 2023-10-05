using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    static public class Exercicio15
    {
        public const double ImpostoDeRenda = 0.11;
        public const double Inss = 0.08;
        public const double Sindicato = 0.05;

        static public void CalculoDescontosSalarial()
        {
            Console.Write("Digite o valor da sua hora de trabalho: ");
            var hora = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite quantas horas você trabalhou esse mês: ");
            var horasTrabalhadas = Convert.ToInt32(Console.ReadLine());

            var salarioBruto = hora * horasTrabalhadas;
            var descontoInss = salarioBruto * Inss;
            var descontoSindicato = salarioBruto * Sindicato;
            var descontoIR = salarioBruto * ImpostoDeRenda;
            var salarioLiquido = salarioBruto - (ImpostoDeRenda * salarioBruto) - Inss - Sindicato;

            Console.WriteLine("Salario bruto: R$" + salarioBruto);
            Console.WriteLine("IR (11%): R$" + descontoIR);
            Console.WriteLine("INSS: R$" + descontoInss);
            Console.WriteLine("Sindicato: R$" + descontoSindicato);
            Console.WriteLine("Salario liquido: R$" + salarioLiquido);
        }
    }
}
