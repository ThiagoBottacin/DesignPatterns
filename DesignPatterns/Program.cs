using DesignPatterns.Chain_of_Responsibility;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
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
