using DesignPatterns.Chain_of_Responsibility;
using DesignPatterns.Decorator;

namespace DesignPatterns.Strategy
{
    public class ISS : Imposto
    {
        public ISS() : base() { }
        public ISS(Imposto outroImposto) : base(outroImposto) { }

        public override double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculoDoOutroImposto(orcamento);
        }
    }
}
