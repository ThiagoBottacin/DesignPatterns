using DesignPatterns.Strategy;
using System.Collections.Generic;

namespace DesignPatterns.Template_Method.Relatorio
{
    public abstract class Relatorio : IRelatorio
    {
        protected abstract void Cabecalho();
        protected abstract void Rodape();
        protected abstract void Corpo(IList<Conta> contas);

        public void Imprimir(IList<Conta> contas)
        {
            Cabecalho();
            Corpo(contas);
            Rodape();
        }
    }
}
