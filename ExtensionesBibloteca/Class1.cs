using BiblotecadeLibro;

namespace ExtensionesBibloteca
{
    public static class LibroExtensiones
    {
        public static string InformacionLibro(this Libro libro)
        {
            return $"Título: {libro.Titulo} ({libro.AnioPublicacion}) - Autor: {libro.Autor}";
        }   

        public static bool EsLibroClasico(this Libro libro)
        {
            return (DateTime.Now.Year - libro.AnioPublicacion) > 50;
        }
    }
}
