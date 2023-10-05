using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    static public class Exercicio14
    {
        public const int valorMulta = 4;
        public const int pesoLimite = 50;

        /// <summary>
        /// Método que recebe o valor inteiro de um peixe e verifica se ele excede o valor limite,
        /// caso exceda será aplicado a multa
        /// </summary>
        static public void CalcularExcessoDePeso()
        {
            Console.WriteLine("Digite o peso do peixe: ");
            var peso = Convert.ToInt32(Console.ReadLine());

            var excesso = 0;
            var multa = 0;

            if (peso > pesoLimite)
            {
                excesso = peso - pesoLimite;
                multa = excesso * valorMulta;
            }

            Console.WriteLine("O valor excedido é: " + excesso);
            Console.Write("O valor da multa é: " + multa);

        }
    }
}
