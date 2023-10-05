using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    static public class Exercicio11
    {
        static public void CalculoReal()
        {
            Console.Write("Digite o primeiro número inteiro: ");
            var num1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Digite o segundo número inteiro: ");
            var num2 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Digite o terceiro número real: ");
            var num3 = Convert.ToDouble(Console.ReadLine());

            var a = (num1 * 2 ) + (num2 / 2);
            Console.WriteLine("o produto do dobro do primeiro com metade do segundo: " + a);

            var b = (num1 * 3) + num3;
            Console.WriteLine("a soma do triplo do primeiro com o terceiro: " + b);

            var c = Math.Pow(num3, 3);
            Console.WriteLine("o terceiro elevado ao cubo: " + c);
        }
    }
}
