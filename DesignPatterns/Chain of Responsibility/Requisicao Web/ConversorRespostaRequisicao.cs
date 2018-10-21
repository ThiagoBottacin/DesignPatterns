using DesignPatterns.Strategy;

namespace DesignPatterns.Chain_of_Responsibility.Requisicao_Web
{
    public class ConversorRespostaRequisicao
    {
        public string FormatarResposta(Requisicao requisicao, Conta conta)
        {
            IFormato formato1 = new FormatoXml(new FormatoCsv(new FormatoPorcento()));

            return formato1.Formatar(requisicao, conta);
        }
    }
}
