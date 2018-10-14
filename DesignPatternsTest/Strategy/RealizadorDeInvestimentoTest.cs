using DesignPatterns.Strategy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DesignPatternsTest.Strategy
{
    [TestClass]
    public class RealizadorDeInvestimentoTest
    {
        [TestMethod]
        public void RealizarInvestimento_Test()
        {
            try
            {
                // Investimentos
                Arrojado investimentoArrojado = new Arrojado();
                Moderado investimentoModerado = new Moderado();
                Conservador investimentoConservador = new Conservador();

                // Conta Bancária
                ContaBancaria conta = new ContaBancaria("Thiago Bottacin", 100.0);

                // Realizador de Investimentos
                RealizadorDeInvestimentos realizadorInvestimentos = new RealizadorDeInvestimentos();

                // Realiza Investimentos
                realizadorInvestimentos.RealizarInvestimento(conta, investimentoConservador);
                realizadorInvestimentos.RealizarInvestimento(conta, investimentoModerado);
                realizadorInvestimentos.RealizarInvestimento(conta, investimentoArrojado);

                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {

                Assert.Fail(ex.Message);
            }
        }

        // TODO: Investimento Conservador
        [TestMethod]
        public void Investimento_Conservador_Test()
        {
        }

        // TODO: Investimento Moderado
        [TestMethod]
        public void Investimento_Moderado_Test()
        {
        }

        // TODO: Investimento Arrojado
        [TestMethod]
        public void Investimento_Arrojado_Test()
        {
        }
    }
}
