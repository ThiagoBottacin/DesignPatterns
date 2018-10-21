using System.Collections.Generic;
using DesignPatterns.Strategy;

namespace DesignPatterns.Template_Method.Relatorio
{
    public interface IRelatorio
    {
        void Imprimir(IList<Conta> contas);
    }
}