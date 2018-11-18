using DesignPatterns.Chain_of_Responsibility;
using DesignPatterns.Decorator;

namespace DesignPatterns.Template_Method
{
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
        public TemplateDeImpostoCondicional() : base() { }
        public TemplateDeImpostoCondicional(Imposto outroImposto) : base(outroImposto) { }

        public override double Calcular(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento) + CalculoDoOutroImposto(orcamento);
            }

            return MinimaTaxacao(orcamento);
        }

        protected abstract double MinimaTaxacao(Orcamento orcamento);

        protected abstract double MaximaTaxacao(Orcamento orcamento);

        protected abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
    }
}
