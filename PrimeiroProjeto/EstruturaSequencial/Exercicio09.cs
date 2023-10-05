using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    static public class Exercicio09
    {
        static public void Temperatura()
        {
            Console.Write("Digite a temperatura em Fahrenheit: ");
            var F = Convert.ToSingle(Console.ReadLine());

            var C = 5 * ((F - 32) / 9);
            Console.Write("A temperatura em Celsius é: " + C);
        }
    }
}
