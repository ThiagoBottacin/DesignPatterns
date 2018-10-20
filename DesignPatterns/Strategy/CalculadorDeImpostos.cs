using DesignPatterns.Chain_of_Responsibility;
using System;

namespace DesignPatterns.Strategy
{
    public class CalculadorDeImpostos
    {
        public void RealizarCalculo(Orcamento orcamento, IImposto imposto)
        {
            double valorCalculado =
             imposto.Calcular(orcamento);

            Console.WriteLine(valorCalculado);
        }
    }
}
