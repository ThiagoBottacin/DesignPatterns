using DesignPatterns.Chain_of_Responsibility.Requisicao_Web;
using DesignPatterns.Strategy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTest.Chain_of_Responsability.Requisicao_Web
{
    [TestClass]
    public class ConversorRespostaRequisicaoTest
    {
        private ConversorRespostaRequisicao conversorResposta;
        private Requisicao requisicao;
        private Conta conta;

        [TestInitialize]
        public void Initialize()
        {
            conversorResposta = new ConversorRespostaRequisicao();
            conta = new Conta("Thiago Bottacin", 123, "123-6", 500.0);
        }

        [TestMethod]
        public void Formato_XML_Test()
        {
            requisicao = new Requisicao(Formato.XML);

            string retorno = conversorResposta.FormatarResposta(requisicao, conta);

            Assert.IsTrue(!string.IsNullOrEmpty(retorno));
        }

        [TestMethod]
        public void Formato_CSV_Test()
        {
            requisicao = new Requisicao(Formato.CSV);

            string retorno = conversorResposta.FormatarResposta(requisicao, conta);

            Assert.IsTrue(!string.IsNullOrEmpty(retorno));
        }

        [TestMethod]
        public void Formato_Porcento_Test()
        {
            requisicao = new Requisicao(Formato.PORCENTO);

            string retorno = conversorResposta.FormatarResposta(requisicao, conta);

            Assert.IsTrue(!string.IsNullOrEmpty(retorno));
        }
    }
}
