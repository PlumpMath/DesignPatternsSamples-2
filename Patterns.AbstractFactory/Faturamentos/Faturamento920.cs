using System;
using Patterns.AbstractFactory.Interfaces;

namespace Patterns.AbstractFactory.Faturamentos
{
    public class Faturamento920 : IFaturamentoLote
    {
        public String GerarFaturasLote()
        {
            return "Faturas geradas com sucesso para 500 clientes.";
        }
    }
}
