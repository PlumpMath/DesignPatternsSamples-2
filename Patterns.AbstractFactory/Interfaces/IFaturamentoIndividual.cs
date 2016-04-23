using System;

namespace Patterns.AbstractFactory.Interfaces
{
    /// <summary>
    /// Interface responsável por assinar o método de geração de faturas para apenas um cliente.
    /// </summary>
    public interface IFaturamentoIndividual
    {
        String GerarFaturasIndividual();
    }
}
