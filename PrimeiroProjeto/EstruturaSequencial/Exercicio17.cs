using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    static public class Exercicio17
    {
        static public void Download()
        {
            Console.WriteLine("Qual o tamanho do arquivo para download (em MB): ");
            var tamanhoArquivo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual a velocidade da sua internet (em Mbps): ");
            var velocidadeInternet = Convert.ToDouble(Console.ReadLine());

            TimeSpan tempoDownload = TimeSpan.FromMinutes(tamanhoArquivo / velocidadeInternet);

            Console.WriteLine("O Downloand vai demorar: " + tempoDownload);
        }
    }
}
