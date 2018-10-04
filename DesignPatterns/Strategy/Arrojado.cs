using System;

namespace DesignPatterns.Strategy
{
    public class Arrojado : IInvestimento
    {
        public double Investir(ContaBancaria conta)
        {
            var probabilidadeInvestimento = new Random().Next(101);
            var multiplicadorInvestimento = 0.0;

            // Valida a probabilidade de Investimento
            if (probabilidadeInvestimento >= 50)
            {
                multiplicadorInvestimento = 0.06;
            }
            else if (probabilidadeInvestimento >= 30)
            {
                multiplicadorInvestimento = 0.3;
            }
            else
            {
                multiplicadorInvestimento = 0.5;
            }

            return conta.Saldo * multiplicadorInvestimento;
        }
    }
}
