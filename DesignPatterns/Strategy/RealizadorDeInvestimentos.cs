using System;

namespace DesignPatterns.Strategy
{
    public class RealizadorDeInvestimentos
    {

        public void RealizarInvestimento(ContaBancaria conta, IInvestimento investimento)
        {
            var valorInvestido = conta.Saldo;

            // Realiza investimento de acordo com o investimento escolhido
            var rendimentoBruto = investimento.Investir(conta);

            // Calcula lucros
            var rendimentoLiquido = rendimentoBruto * 0.75;
            var valorImposto = rendimentoBruto - rendimentoLiquido;

            // Credita rendimento do investimento com descontos na conta bancária
            conta.Saldo += rendimentoLiquido;

            // Exibe resultados
            Console.WriteLine($"--- Valor investido [{investimento.GetType().Name}]:\tR${valorInvestido}");
            Console.WriteLine($"--- Rendimento Bruto:\tR${rendimentoBruto}");
            Console.WriteLine($"--- Rendimento Liquido:\tR${rendimentoLiquido}");
            Console.WriteLine($"--- Impostos:\tR${valorImposto}");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine($"--- Saldo Atual:\tR${conta.Saldo}");
            Console.WriteLine();
        }
    }
}
