using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    static public class Exercicio12
    {
        static public void Imc()
        {
            Console.Write("Digite o seu sexo: ");
            var sexo = Console.ReadLine();

            Console.Write("Digite a sua altura: ");
            var altura = Convert.ToDouble(Console.ReadLine());

            var idealH = (72.7 * altura) - 58;
            var idealM = (62.1 * altura) - 44.7;

            if (sexo == "masculino" || sexo == "macho")
            {
                Console.WriteLine("O seu peso ideal é: " + idealH);
            }
            else
            {
                Console.WriteLine("O seu peso ideal é: " + idealM);
            }
        }
    }
}
