using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    static public class Exercicio08
    {
        static public void SalarioMes()
        {
            Console.Write("Digite quanto você ganha por hora: ");
            var salario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o número de horas trabalhadas no mês: ");
            var horas = Convert.ToDouble(Console.ReadLine());

            var salarioTotal = salario * horas;

            Console.WriteLine("O seu salario mensal é: " + salarioTotal);
        }

    }
}
