using DesignPatterns.Strategy;

namespace DesignPatterns.Chain_of_Responsibility.Requisicao_Web
{
    class FormatoCsv : IFormato
    {
        public IFormato Proximo { get; set; }
        public string Formatar(Requisicao requisicao, ContaBancaria conta)
        {
            if (requisicao.Formato == Formato.CSV)
            {
                return $"{conta.NomeTitular};{conta.Saldo:N};";
            }

            return Proximo.Formatar(requisicao, conta);
        }
    }
}
