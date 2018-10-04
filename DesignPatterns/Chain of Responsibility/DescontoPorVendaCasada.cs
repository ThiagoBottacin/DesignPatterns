using System.Linq;

namespace DesignPatterns.Chain_of_Responsibility
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Descontar(Orcamento orcamento)
        {
            // Valida se existe Lapis e Caneta nos itens do orcamento
            if (Existe("LAPIS", orcamento) && Existe("CANETA", orcamento))
            {
                return orcamento.Valor * 0.05;
            }
            else
            {
                return Proximo.Descontar(orcamento);
            }
        }

        private bool Existe(string nomeDoItem, Orcamento orcamento)
        {
            return orcamento.Itens.Any(i => i.Nome.Equals(nomeDoItem));
        }
    }
}
