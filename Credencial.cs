using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgVis2022Ativ2_EdsonJunior
{
    internal class Credencial
    {
        public String identificacao { get; set; }
        public String senha { private get; set; }
        public String Ativo { get; private set; }

        public Boolean Autenticar()
        {
            if (senha == "asdf123" && identificacao == "luis.guisso")
            {
                Ativo = "Ativo";
                return true;
            }
            else
            {
                Ativo = "Inativo";
                return false; 
            }

        }
    }
}
