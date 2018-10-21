using DesignPatterns.Chain_of_Responsibility;
using DesignPatterns.Strategy;
using DesignPatterns.Template_Method;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            CalularImpostoTemplateMethod();

            //CalcularDescontos();
        }

        private static void CalularImpostoTemplateMethod()
        {
            IImposto ikcv = new IKCV();
            IImposto icpp = new ICPP();
            IImposto ihit = new IHIT();
            Orcamento orcamento = new Orcamento(800.0);

            orcamento.AdicionaItem(new Item("CANETA", 400.0));
            orcamento.AdicionaItem(new Item("LAPIS", 200.0));
            orcamento.AdicionaItem(new Item("LAPIS", 200.0));

            var valorIkcv = ikcv.Calcular(orcamento);
            var valorIcpp = icpp.Calcular(orcamento);
            var valorIhit = ihit.Calcular(orcamento);

            Console.WriteLine($"Imposto IKCV: {valorIkcv} / Imposto ICPP: {valorIcpp} / Imposto IHIT: {valorIhit}");
            Console.ReadKey();
        }

        private static void CalcularDescontos()
        {
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(200.0);
            orcamento.AdicionaItem(new Item("CANETA", 100.0));
            orcamento.AdicionaItem(new Item("LAPIS", 100.0));

            double desconto = calculador.Calcular(orcamento);

            Console.WriteLine(desconto);
            Console.ReadKey();
        }
    }
}
