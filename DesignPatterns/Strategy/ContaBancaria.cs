namespace DesignPatterns.Strategy
{
    public class ContaBancaria
    {
        public double Saldo { get; set; }

        public ContaBancaria(double saldoInicial)
        {
            Saldo = saldoInicial;
        }
    }
}