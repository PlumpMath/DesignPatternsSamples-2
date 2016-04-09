using Patterns.Adapter.Interfaces;

namespace Patterns.Adapter.Adapters
{
    public class ImagemSurfaceAdapter : ImagemSurfaceSdl, ISurface
    {
        public void CarregarImagem(string arquivo)
        {
            throw new System.NotImplementedException();
        }

        public void DesenharImagem(int largura, int altura, int posicaoX, int posicaoY)
        {
            throw new System.NotImplementedException();
        }
    }
}
