namespace DesignPatterns.Strategy
{
    public class Conta
    {
        public string Nome { get; private set; }
        public int Numero { get; private set; }
        public string Agencia { get; private set; }
        public double Saldo { get; private set; }

        public Conta(string nome, int numero, string agencia, double saldoInicial)
        {
            Nome = nome;
            Numero = numero;
            Agencia = agencia;
            Saldo = saldoInicial;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }
    }
}
