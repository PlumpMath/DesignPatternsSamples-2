using Patterns.AbstractFactory.Faturamentos;
using Patterns.AbstractFactory.Interfaces;

namespace Patterns.AbstractFactory.Factories
{
    public class FaturamentoPessoaJuridica : IFaturamentoFactory
    {
        public IFaturamentoLote ProcessarFaturamentoLote()
        {
            return new Faturamento640();
        }

        public IFaturamentoIndividual ProcessarFaturamentoIndividual()
        {
            return new Faturamento641();
        }
    }
}
