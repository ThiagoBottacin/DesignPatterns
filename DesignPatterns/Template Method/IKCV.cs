using System.Linq;
using DesignPatterns.Chain_of_Responsibility;

namespace DesignPatterns.Template_Method
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && PossuiItemMaiorQue100(orcamento);
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        private bool PossuiItemMaiorQue100(Orcamento orcamento)
        {
            return orcamento.Itens.Any(i => i.Valor > 100);
        }
    }
}
