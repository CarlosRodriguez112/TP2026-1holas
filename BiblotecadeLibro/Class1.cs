namespace BiblotecadeLibro
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnioPublicacion { get; set; }


        public Libro(string titulo, string autor, int anio)
        {
            Titulo = titulo;
            Autor = autor;
            AnioPublicacion = anio;
        }
    }

    public class GestordeLibros
    {
        private List<Libro> libros = new List<Libro>();

        public void AgregarLibro(Libro libro)
        {
            libros.Add(libro);
        }

        public void EliminarLibro(string titulo)
        {
            libros.RemoveAll(t => t.Titulo == titulo);
        }

        public List<Libro> BuscarLibrosAutor(string autor)
        {
            return libros.FindAll(a => a.Autor == autor);
        }

        public void MostrarLibros()
        {
            foreach (Libro libro in libros)
            {
                Console.WriteLine($"Titulo: {libro.Titulo}, Autor: {libro.Autor}, Año: {libro.AnioPublicacion}");
            }
        }
    }

}
