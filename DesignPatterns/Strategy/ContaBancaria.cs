namespace DesignPatterns.Strategy
{
    public class ContaBancaria
    {
        public string NomeTitular { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string nomeTitular, double saldoInicial)
        {
            NomeTitular = nomeTitular;
            Saldo = saldoInicial;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }
    }
}
