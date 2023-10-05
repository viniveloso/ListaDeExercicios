using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    static public class Exercicio16
    {
        public const double valorLata = 80;
        public const double valorGalao = 25;
        public const double valorFolga = 1.10;
        static public void LojaDeTintas()
        {
            Console.Write("Informe quantos metros quadrados gostaria de pintar: ");
            var metros = Convert.ToInt32(Console.ReadLine());

            double litrosASerUsado = (double)metros / 6;
            double quantidadeLatas = Math.Ceiling(litrosASerUsado / 18);
            double quantidadeGaloes = Math.Ceiling(litrosASerUsado / 3.6);
            double quantidadeMisturadaLatas = Math.Floor(litrosASerUsado / 18);
            double quantidadeMisturadaGaloes = Math.Ceiling(((litrosASerUsado % 18) * valorFolga) / 3.6);
            double valorTotalLatas;
            double valorTotalGaloes;
            double valorTotalMisturado;

            valorTotalLatas = quantidadeLatas * valorLata;
            valorTotalGaloes = quantidadeGaloes * valorGalao;
            valorTotalMisturado = (quantidadeMisturadaLatas * valorLata) + (quantidadeMisturadaGaloes * valorGalao);


            Console.WriteLine("A quantidade de latas de tintas a serem compradas é: " + quantidadeLatas);
            Console.WriteLine("Preço total: " + valorTotalLatas);

            Console.WriteLine("A quantidade de galoes de tintas a serem compradas é: " + quantidadeGaloes);
            Console.WriteLine("Preço total: " + valorTotalGaloes);

            Console.WriteLine("A quantidade de latas de tintas a serem compradas é: " + quantidadeMisturadaLatas + " E a quantidade de galoes é: " + quantidadeMisturadaGaloes);
            Console.WriteLine("Preço total: " + valorTotalMisturado);


        }
    }
}
