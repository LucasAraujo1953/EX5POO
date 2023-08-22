using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5POO
{
    internal class Conversor
    {
        const double MilhaMaritimaParaMetro = 1852; // 1 milha marítima em metros
        const double MetroParaQuilometro = 0.001;   // 1 metro em quilômetros

        public double ConverterMilhasParaQuilometros(double milhas)
        {
            double metros = milhas * MilhaMaritimaParaMetro;
            double quilometros = metros * MetroParaQuilometro;
            return quilometros;
        }
    }
}

