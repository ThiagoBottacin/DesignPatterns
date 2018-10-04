using DesignPatterns.Strategy;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Investimentos
            Arrojado investimentoArrojado = new Arrojado();
            Moderado investimentoModerado = new Moderado();
            Conservador investimentoConservador = new Conservador();

            // Conta Bancária
            ContaBancaria conta = new ContaBancaria(100.0);

            // Realizador de Investimentos
            RealizadorDeInvestimentos realizadorInvestimentos = new RealizadorDeInvestimentos();

            // Realiza Investimentos
            realizadorInvestimentos.RealizarInvestimento(conta, investimentoConservador);
            realizadorInvestimentos.RealizarInvestimento(conta, investimentoModerado);
            realizadorInvestimentos.RealizarInvestimento(conta, investimentoArrojado);
        }
    }
}