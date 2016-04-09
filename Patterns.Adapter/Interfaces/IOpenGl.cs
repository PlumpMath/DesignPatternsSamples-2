namespace Patterns.Adapter.Interfaces
{
    public interface IOpenGl
    {
        void CarregarImagem(string arquivo);

        void DesenharImagem(int posicaoX, int posicaoY);
    }
}
