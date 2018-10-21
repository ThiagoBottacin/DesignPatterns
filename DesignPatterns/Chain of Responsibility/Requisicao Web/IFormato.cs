using DesignPatterns.Strategy;

namespace DesignPatterns.Chain_of_Responsibility.Requisicao_Web
{
    public interface IFormato
    {
        //IFormato Proximo { get; set; }

        string Formatar(Requisicao requisicao, Conta conta);
    }
}
