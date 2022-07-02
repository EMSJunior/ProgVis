using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgVis2022Ativ2_EdsonJunior
{
    internal class AreaQuadrado
    {
        public Double Lado { get; set; }

        public Double CalcularArea() { return Lado * Lado; }

        public override string ToString()
        {
            return ($"Lado: {Lado}, Area: {CalcularArea()}");
        }
    }
}
