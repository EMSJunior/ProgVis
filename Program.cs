using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgVis2022Ativ2_EdsonJunior
{
    public class Program
    {
        public static void Main(String[] args)
        {
            ProcessarQuestao1();
            ProcessarQuestao2();
            ProcessarQuestao3();
            ProcessarQuestao4();
            ProcessarQuestao5();
            Console.ReadLine();
        }
        private static void ProcessarQuestao1()
        {
            Paciente p = new Paciente
            {
                Nome = "Beatriz Yana",
                cns = 227683387130006
            };
            Console.WriteLine($"♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥\n                    Questão 1:\n♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥\n\n{p}\n\n");

        }
        private static void ProcessarQuestao2()
        {
            Eletrodomestico E = new Eletrodomestico
            {
                codigo = 851796157395,
                Nome = "Refrigerador",
                Preco = 3253.12m
            };
            Console.WriteLine($"♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥\n                    Questão 2:\n♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥\n\n{E}\n\n");

        }
        private static void ProcessarQuestao3()
        {
            AreaCirculo circulo = new AreaCirculo
            {
                Raio = 2
            };

            AreaQuadrado quadrado = new AreaQuadrado
            {
                Lado = 2
            };

            AreaRetangulo retangulo = new AreaRetangulo
            {
                LadoA = 2,
                LadoB = 3
            };

            AreaLosangulo losangulo = new AreaLosangulo
            {
                DiagonalA = 2,
                DiagonalB = 3
            };

            Console.WriteLine($"♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥\n                    Questão 3:\n♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥\n\nCírculo: {circulo}\n\nQuadrado: {quadrado}\n\nRetângulo: {retangulo}\n\nLosângulo{losangulo}\n\n");
        }
        private static void ProcessarQuestao4()
        {
            Soma soma = new Soma
            {
                ValorA = 2.5,
                ValorB = -3
            };

            Subtracao sub = new Subtracao
            {
                ValorA = 2.5,
                ValorB = -3
            };

            Multiplicacao mult = new Multiplicacao
            {
                ValorA = 2.5,
                ValorB = -3
            };

            Divisao div = new Divisao
            {
                ValorA = 2.5,
                ValorB = -3
            };

            Console.WriteLine($"♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥\n                    Questão 4:\n♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥\n\n Soma: {soma}\n\nSubtração: {sub}\n\nMultiplicação: {mult}\n\nDivisão: {div}\n\n");

        }
        private static void ProcessarQuestao5()
        {

            Usuario user = new Usuario
            {
                Email = "luis.guisso@ifnmg.edu.br",
                Nome = "Luis Guisso",
                Nascimento = new DateTime(1982, 1, 1)
            };

            Console.WriteLine($"♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥\n                    Questão 5:\n♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥\n\n{user}");
        }
    }
}

