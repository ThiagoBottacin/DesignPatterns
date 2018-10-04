using System;

namespace DesignPatterns.Strategy
{
    public class Moderado : IInvestimento
    {
        public double Investir(ContaBancaria conta)
        {
            var probabilidadeInvestimento = new Random().Next(101);
            var multiplicadorInvestimento = 0.0;

            // Valida a probabilidade de Investimento
            if (probabilidadeInvestimento <= 50)
            {
                multiplicadorInvestimento = 0.25;
            }
            else
            {
                multiplicadorInvestimento = 0.07;
            }

            return conta.Saldo * multiplicadorInvestimento;
        }
    }
}
