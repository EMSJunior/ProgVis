using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgVis2022Ativ2_EdsonJunior
{
    internal class Multiplicacao
    {
        public Double ValorA { get; set; }
        public Double ValorB { get; set; }

        public Double operar() { return ValorA * ValorB; }

        public override string ToString()
        {
            return $"ValorA: {ValorA}, Valor B: {ValorB}, Multiplicação: {operar()}";
        }
    }
}
