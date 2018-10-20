using System;
using DesignPatterns.Strategy;

namespace DesignPatterns.Chain_of_Responsibility.Requisicao_Web
{
    class FormatoPorcento : IFormato
    {
        public IFormato Proximo { get; private set; }

        public FormatoPorcento(IFormato proximo)
        {
            Proximo = proximo;
        }

        public FormatoPorcento()
        {
            Proximo = null;
        }

        public string Formatar(Requisicao requisicao, ContaBancaria conta)
        {
            if (requisicao.Formato == Formato.PORCENTO)
            {
                return $"{conta.NomeTitular}%{conta.Saldo:N}%";
            }

            return Proximo?.Formatar(requisicao, conta) ?? throw new Exception("Formato de resposta não encontrado");
        }
    }
}
