using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    static public class Exercicio10
    {
        static public void TemperaturaC()
        {
            Console.Write("Digite a temperatura em Celsius: ");
            var C = Convert.ToDouble(Console.ReadLine());

            var F = (C * 9 / 5) + 32;
            Console.Write("A temperatura em Fahrenheit é: " + F);
        }
    }
}
