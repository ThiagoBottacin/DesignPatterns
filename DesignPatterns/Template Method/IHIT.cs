using System.Linq;
using DesignPatterns.Chain_of_Responsibility;

namespace DesignPatterns.Template_Method
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Itens.GroupBy(i => i.Nome).Any(x => x.Count() >= 2);
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100; 
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Itens.Count);
        }
    }
}
