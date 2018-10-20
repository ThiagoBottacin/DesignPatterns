using System;
using DesignPatterns.Strategy;

namespace DesignPatterns.Chain_of_Responsibility.Requisicao_Web
{
    class FormatoCsv : IFormato
    {
        public IFormato Proximo { get; private set; }

        public FormatoCsv(IFormato proximo)
        {
            Proximo = proximo;
        }

        public FormatoCsv()
        {
            Proximo = null;
        }

        public string Formatar(Requisicao requisicao, ContaBancaria conta)
        {
            if (requisicao.Formato == Formato.CSV)
            {
                return $"{conta.NomeTitular};{conta.Saldo:N};";
            }

            return Proximo?.Formatar(requisicao, conta) ?? throw new Exception("Formato de resposta não encontrado");
        }
    }
}
