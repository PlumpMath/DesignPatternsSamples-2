using Patterns.AbstractFactory.Faturamentos;
using Patterns.AbstractFactory.Interfaces;

namespace Patterns.AbstractFactory.Factories
{
    /// <summary>
    /// Classe responsável por realizar o faturamento de pessoa física
    /// </summary>
    public class FaturamentoPessoaFisica : IFaturamentoFactory
    {
        /// <summary>
        /// Método responsável por realizar o faturamento de pessoas físicas em lote
        /// </summary>
        public IFaturamentoLote ProcessarFaturamentoLote()
        {
            return new Faturamento920();
        }

        /// <summary>
        /// Método responsável por realizar o faturamento de pessoas físicas individualmente
        /// </summary>
        public IFaturamentoIndividual ProcessarFaturamentoIndividual()
        {
            return new Faturamento921();
        }
    }
}
