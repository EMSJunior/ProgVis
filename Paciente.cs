using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgVis2022Ativ2_EdsonJunior
{
    public class Paciente
    {
        public String Nome { get; set; }
        public UInt64 cns { get; set; }

        public override String ToString()
        {
            return ($"Paciente: {Nome}, cns: " + cns.ToString("### #### #### ####."));
        }
    }
}
