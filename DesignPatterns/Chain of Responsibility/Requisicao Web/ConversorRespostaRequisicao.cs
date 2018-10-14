using DesignPatterns.Strategy;

namespace DesignPatterns.Chain_of_Responsibility.Requisicao_Web
{
    public class ConversorRespostaRequisicao
    {
        public string FormatarResposta(Requisicao requisicao, ContaBancaria conta)
        {
            IFormato formato1 = new FormatoXml();
            IFormato formato2 = new FormatoCsv();
            IFormato formato3 = new FormatoPorcento();
            IFormato formato4 = new SemFormato();

            formato1.Proximo = formato2;
            formato2.Proximo = formato3;
            formato3.Proximo = formato4;

            return formato1.Formatar(requisicao, conta);
        }
    }
}
