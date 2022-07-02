using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgVis2022Ativ2_EdsonJunior
{
    internal class Usuario
    {
        public String Nome { get; set; }
        public String Email { get; set; }
        public DateTime Nascimento { get; set; }
        public Int64 idade;
        public Credencial cLuis { get; set; }


        public override string ToString()
        {
            DateTime Hoje = DateTime.Now;
            idade = Hoje.Year - Nascimento.Year;
            if(Nascimento.DayOfYear > Hoje.DayOfYear)
            {
                idade -= 1;
            }

            Credencial cLuis = new Credencial
            {
                identificacao = "luis.guisso",
                senha = "asdf123"
            };
            this.cLuis = cLuis;
            cLuis.Autenticar();

            return $"Nome: {Nome}, Email: {Email}, Nascimento: {Nascimento:dd/MM/yyyy}, Idade: {idade}, Identificação: {cLuis.identificacao}, Ativo: {cLuis.Ativo}";
        }
    }
}
