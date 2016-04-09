namespace Patterns.Adapter.Interfaces
{
    public interface ISurface
    {
        void CarregarImagem(string arquivo);

        void DesenharImagem(int largura, int altura, int posicaoX, int posicaoY);
    }
}
