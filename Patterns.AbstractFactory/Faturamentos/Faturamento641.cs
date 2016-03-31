using Patterns.AbstractFactory.Interfaces;

namespace Patterns.AbstractFactory.Faturamentos
{
    public class Faturamento641 : IFaturamentoIndividual
    {
        public string GerarFaturasIndividual()
        {
            return "Fatura gerada para a empresa Bom Negócio Ltda.";
        }
    }
}
