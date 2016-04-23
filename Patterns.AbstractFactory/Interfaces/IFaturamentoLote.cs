using System;

namespace Patterns.AbstractFactory.Interfaces
{
    /// <summary>
    /// Interface responsável por assinar o método de geração de faturas para diversos Clientes.
    /// </summary>
    public interface IFaturamentoLote
    {
        String GerarFaturasLote();
    }
}
