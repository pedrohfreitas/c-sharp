namespace Delegate_Basic2.lib
{
    public class FotoProcessador
    {
        public delegate void FotoFiltroHandler(Foto foto);
        public static FotoFiltroHandler filtros;
        public static void Processador(Foto foto){

            filtros(foto);

            /* Tradicional */
            // var filtros = new FotoFiltro();
            // filtros.Colorir(foto);
            // filtros.PretoBranco(foto);
            // filtros.GerarThmb(foto);
            // filtros.RedimensionarTamMedio(foto);
        }
    }
}