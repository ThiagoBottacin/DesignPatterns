using DesignPatterns.Strategy;

namespace DesignPatterns.Chain_of_Responsibility.Requisicao_Web
{
    public class SemFormato : IFormato
    {
        public IFormato Proximo { get; set; }
        public string Formatar(Requisicao requisicao, ContaBancaria conta)
        {
            return "Formato Inválido";
        }
    }
}
