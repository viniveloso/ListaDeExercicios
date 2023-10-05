using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    static public class Exercicio07
    {
        static public void DobroDoQuadrado()
        {
            Console.WriteLine("Digite o valor de um dos lados do quadrado: ");

            var quadrado = Convert.ToDouble(Console.ReadLine());

            var areaDoQuadrado = quadrado * quadrado * 2;

            Console.WriteLine("O valor da área é: " + areaDoQuadrado);
        }
    }
}
