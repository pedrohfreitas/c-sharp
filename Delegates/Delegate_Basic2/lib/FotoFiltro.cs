using System;

namespace Delegate_Basic2.lib
{
    public class FotoFiltro
    {
        public void Colorir(Foto foto){
            Console.WriteLine("FotoFiltro > Colorir: " + foto.Nome);
        }

        public void PretoBranco(Foto foto){
            Console.WriteLine("FotoFiltro > PretoBranco: " + foto.Nome);
        }

        public void GerarThmb(Foto foto){
            Console.WriteLine("FotoFiltro > GerarThmb: " + foto.Nome);
        }

        public void RedimensionarTamMedio(Foto foto){
            Console.WriteLine("FotoFiltro > RedimensionarTamanhoMedio: " + foto.Nome);
        }
    }
}