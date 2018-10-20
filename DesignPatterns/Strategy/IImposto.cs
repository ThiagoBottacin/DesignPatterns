using DesignPatterns.Chain_of_Responsibility;

namespace DesignPatterns.Strategy
{
    public interface IImposto
    {
        double Calcular(Orcamento orcamento);
    }
}
