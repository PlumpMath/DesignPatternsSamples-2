using Patterns.AbstractFactory.Faturamentos;
using Patterns.AbstractFactory.Interfaces;

namespace Patterns.AbstractFactory.Factories
{
    /// <summary>
    /// Classe responsável por realizar o faturamento de pessoa jurídica
    /// </summary>
    public class FaturamentoPessoaJuridica : IFaturamentoFactory
    {
        /// <summary>
        /// Método responsável por realizar o faturamento de pessoas jurídicas em lote
        /// </summary>
        public IFaturamentoLote ProcessarFaturamentoLote()
        {
            return new Faturamento640();
        }

        /// <summary>
        /// Método responsável por realizar o faturamento de pessoas jurídicas em individualmente
        /// </summary>
        public IFaturamentoIndividual ProcessarFaturamentoIndividual()
        {
            return new Faturamento641();
        }
    }
}
