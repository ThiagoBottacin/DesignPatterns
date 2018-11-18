using DesignPatterns.Chain_of_Responsibility;
using DesignPatterns.Strategy;

namespace DesignPatterns.Decorator
{
    public abstract class Imposto : IImposto
    {
        public Imposto OutroImposto { get; set; }

        public Imposto()
        {
        }

        public Imposto(Imposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            return OutroImposto.Calcular(orcamento);
        }

        public abstract double Calcular(Orcamento orcamento);
    }
}
