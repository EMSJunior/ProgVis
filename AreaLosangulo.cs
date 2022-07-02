using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgVis2022Ativ2_EdsonJunior
{
    internal class AreaLosangulo
    {
        public Double DiagonalA { get; set; }
        public Double DiagonalB { get; set; }

        public Double CalcularArea() { return (DiagonalA * DiagonalB)/2; }

        public override string ToString()
        {
            return $"DiagonalA: {DiagonalA}, DiagonalB: {DiagonalB}, Area: {CalcularArea()}";
        }
    }
}
