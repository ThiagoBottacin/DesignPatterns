using DesignPatterns.Chain_of_Responsibility;
using DesignPatterns.Decorator;

namespace DesignPatterns.Strategy
{
    public class ICMS : Imposto
    {
        public ICMS() : base() { }
        public ICMS(Imposto outroImposto) : base(outroImposto) { }

        public override double Calcular(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.05) + 50.0 + CalculoDoOutroImposto(orcamento);
        }
    }
}
