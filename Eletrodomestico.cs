using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgVis2022Ativ2_EdsonJunior
{
    internal class Eletrodomestico
    {
        public long codigo { get; set; }
        public String Nome { get; set; }
        public Decimal Preco { get; set; }

        public override string ToString()
        {
            return ($"Codigo: {codigo.ToString("##-####-#####-#")}, Nome: {Nome}, Preço: {Preco.ToString("C")}");
        }
    }
}
