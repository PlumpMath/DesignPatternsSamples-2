using Patterns.AbstractFactory.Interfaces;

namespace Patterns.AbstractFactory.Faturamentos
{
    public class Faturamento640 : IFaturamentoLote
    {
        public string GerarFaturasLote()
        {
            return "Faturas geradas para 10 empresas.";
        }
    }
}
