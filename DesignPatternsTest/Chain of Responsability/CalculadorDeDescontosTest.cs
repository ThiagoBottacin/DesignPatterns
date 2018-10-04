using DesignPatterns.Chain_of_Responsibility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTest.Chain_of_Responsability
{
    [TestClass]
    public class CalculadorDeDescontosTest
    {
        [TestMethod]
        public void Calculo_Sem_Desconto_Test()
        {
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(500.0);
            orcamento.AdicionaItem(new Item("CANETA", 250.0));
            orcamento.AdicionaItem(new Item("LAPIS", 250.0));

            double desconto = calculador.Calcular(orcamento);

            Assert.AreEqual(0, desconto, "Não devem ser realizados descontos para esse orçamento.");
        }

        [TestMethod]
        public void Calculo_Desconto_Mais_De_Quinhentos_Reais_Test()
        {
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(550.0);
            orcamento.AdicionaItem(new Item("CANETA", 300.0));
            orcamento.AdicionaItem(new Item("LAPIS", 250.0));

            double desconto = calculador.Calcular(orcamento);

            Assert.AreEqual(orcamento.Valor * 0.07, desconto, "Deve ser realizado um desconto de (7%) para esse orçamento.");
        }

        [TestMethod]
        public void Calculo_Desconto_Mais_Que_Cinco_Itens_Test()
        {
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(300.0);
            orcamento.AdicionaItem(new Item("CANETA", 50.0));
            orcamento.AdicionaItem(new Item("LAPIS", 50.0));
            orcamento.AdicionaItem(new Item("CADERNO", 50.0));
            orcamento.AdicionaItem(new Item("BORRACHA", 50.0));
            orcamento.AdicionaItem(new Item("COLA", 50.0));
            orcamento.AdicionaItem(new Item("GIZ", 50.0));

            double desconto = calculador.Calcular(orcamento);

            Assert.AreEqual(orcamento.Valor * 0.1, desconto, "Deve ser realizado um desconto de (10%) para esse orçamento.");
        }
    }
}
