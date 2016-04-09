using Patterns.Adapter.Interfaces;

namespace Patterns.Adapter.Adapters
{
    public class ImagemOpenGlAdapter : ImagemOpenGl, IOpenGl
    {
        public void CarregarImagem(string arquivo)
        {
            throw new System.NotImplementedException();
        }

        public void DesenharImagem(int posicaoX, int posicaoY)
        {
            throw new System.NotImplementedException();
        }
    }
}
