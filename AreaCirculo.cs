using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgVis2022Ativ2_EdsonJunior
{
    internal class AreaCirculo
    {
        public Double Raio { get; set; }

        public Double CalcularArea() { return Raio * Math.PI * Math.PI; }

        public override string ToString()
        {
            return ($"Raio: {Raio}, Area: {CalcularArea()}");
        }
    }
}
