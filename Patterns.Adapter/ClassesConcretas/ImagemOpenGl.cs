using System;

namespace Patterns.Adapter
{
    public class ImagemOpenGl
    {
        public void GlCarregarImagem(string arquivo)
        {
            Console.WriteLine("Imagem " + arquivo + " carregada.");
        }

        public void GlDesenharImagem(int posicaoX, int posicaoY)
        {
            Console.WriteLine("OpenGL Image Desenhada");
        }
    }
}