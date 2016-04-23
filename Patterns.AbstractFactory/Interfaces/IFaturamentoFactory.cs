namespace Patterns.AbstractFactory.Interfaces
{
    /// <summary>
    /// Interface responsável por definir quais faturamentos serão implementados
    /// </summary>
    public interface IFaturamentoFactory
    {
        /// <summary>
        /// Método responsável por Processar o faturamento das notas de diversos clientes
        /// </summary>
        /// <returns>Retorna um tipo de faturamento coletivo</returns>
        IFaturamentoLote ProcessarFaturamentoLote();

        /// <summary>
        /// Método responsável por Processar o faturamento das notas de um cliente específico
        /// </summary>
        /// <returns>Retorna um tipo de faturamento individual</returns>
        IFaturamentoIndividual ProcessarFaturamentoIndividual();
    }
}
