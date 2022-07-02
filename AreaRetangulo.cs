using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgVis2022Ativ2_EdsonJunior
{
    internal class AreaRetangulo
    {
        public Double LadoA { get; set; }
        public Double LadoB { get; set; }

        public double CalcularArea()
        {
            return LadoA * LadoB;
        }

        public override string ToString()
        {
            return($"Lado A: {LadoA}, Lado B: {LadoB}, Area: {CalcularArea()}");
        }
    }
}
