using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de milhas marítimas: ");
            double milhas = Convert.ToDouble(Console.ReadLine());

            Conversor conversor = new Conversor();
            double quilometros = conversor.ConverterMilhasParaQuilometros(milhas);

            Console.WriteLine($"{milhas} milhas marítimas equivalem a {quilometros} quilômetros.");
        }
    }
}
