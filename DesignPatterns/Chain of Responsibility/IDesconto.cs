namespace DesignPatterns.Chain_of_Responsibility
{
    public interface IDesconto
    {
        IDesconto Proximo { get; set; }

        double Descontar(Orcamento orcamento);
    }
}
