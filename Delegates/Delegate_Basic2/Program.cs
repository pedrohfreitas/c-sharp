using System;
using Delegate_Basic2.lib;

namespace Delegate_Basic2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Tela - Cadastro de Usuário: Tumb (Foto de Perfil)
            Foto foto1 = new Foto {Nome = "foto_perfil.jpg", TamanhoX = 1920, TamanhoY = 1080};
            FotoProcessador.filtros = new FotoFiltro().GerarThmb;
            FotoProcessador.Processador(foto1);

            //Tela - Cadastro de Produto: Colorir + TamanhoMedio
            Foto foto2 = new Foto {Nome = "foto_produto.jpg", TamanhoX = 1920, TamanhoY = 1080};
            FotoProcessador.filtros = new FotoFiltro().Colorir;
            FotoProcessador.filtros += new FotoFiltro().RedimensionarTamMedio;
            FotoProcessador.Processador(foto2);

            //Tela - Cadastro de Albuns - Retro: Preto e Branco
            Foto foto3 = new Foto {Nome = "foto_album.jpg", TamanhoX = 1920, TamanhoY = 1080};
            FotoProcessador.filtros = new FotoFiltro().PretoBranco;
            FotoProcessador.Processador(foto3);

            Console.ReadKey();
        }
    }
}
