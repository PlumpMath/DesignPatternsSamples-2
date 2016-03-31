using Patterns.AbstractFactory.Faturamentos;
using Patterns.AbstractFactory.Interfaces;

namespace Patterns.AbstractFactory.Factories
{
    public class FaturamentoPessoaFisica : IFaturamentoFactory
    {
        public IFaturamentoLote ProcessarFaturamentoLote()
        {
            return new Faturamento920();
        }

        public IFaturamentoIndividual ProcessarFaturamentoIndividual()
        {
            return new Faturamento921();
        }
    }
}
