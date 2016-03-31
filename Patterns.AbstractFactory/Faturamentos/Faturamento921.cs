using Patterns.AbstractFactory.Interfaces;

namespace Patterns.AbstractFactory.Faturamentos
{
    public class Faturamento921 : IFaturamentoIndividual
    {
        public string GerarFaturasIndividual()
        {
            return "Fatura gerada para o cliente João da Silva.";
        }
    }
}
