using System;
using System.Collections.Generic;
using DesignPatterns.Strategy;

namespace DesignPatterns.Template_Method.Relatorio
{
    public class RelatorioSimples : Relatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco ABC");   
        }

        protected override void Corpo(IList<Conta> contas)
        {
            foreach (Conta c in contas)
            {
                Console.WriteLine(c.Nome + " - " + c.Saldo);
            }
        }

        protected override void Rodape()
        {
            Console.WriteLine("(11) 9876-5432");
        }
    }
}
