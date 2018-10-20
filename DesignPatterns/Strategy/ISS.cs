using DesignPatterns.Chain_of_Responsibility;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class ISS : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
