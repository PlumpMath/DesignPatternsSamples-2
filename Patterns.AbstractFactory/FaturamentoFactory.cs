namespace Patterns.AbstractFactory.Faturamento
{
    internal abstract class FaturamentoFactory
    {
        public abstract void ProcessarFaturamentoLote();
        public abstract void ProcessarFaturamentoIndividual();
    }
}
