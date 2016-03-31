namespace Patterns.AbstractFactory.Interfaces
{
    public interface IFaturamentoFactory
    {
        IFaturamentoLote ProcessarFaturamentoLote();
        IFaturamentoIndividual ProcessarFaturamentoIndividual();
    }
}
