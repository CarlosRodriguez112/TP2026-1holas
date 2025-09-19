using System.Globalization;

public class Libro
{
    //Atributos 
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Genero { get; set; }

    protected List<int> Calificaciones;

    //Constructor

    public Libro (string titulo, string autor, string genero)
    {
        Titulo = titulo;
        Autor = autor;
        Genero = genero;
        Calificaciones = new List<int>();
    }

    // metodos
    public void Calificar(int nota)
    {
        if (nota < 1 || nota > 5)
        {
            throw new ArgumentException("La calificacion debe estar entre 1 y 5.");
        }
        Calificaciones.Add(nota);
    }
    //Sobrecarga de metodos
    public void Calificar(int nota, string comentario)
    {
        Console.WriteLine($"Comentario: {comentario}");
        Calificar(nota);
    }

    public double ObtenerPromedio()
    {
        if (Calificaciones.Count == 0)
        {
            return 0;
        }
        double suma = 0;
        foreach (var calificacion in Calificaciones)
        {
            suma += calificacion;
        }
        return suma / Calificaciones.Count;
    }
    public int ObtenerCantidadVotos()
    {
        return Calificaciones.Count;
    }
}



// Subclases para diferentes categorias de libros

public class  LibroFiccion : Libro
{
    public LibroFiccion(string titulo, string autor, string genero) : base(titulo, autor, genero) { }
}


public class LibroTecnico : Libro
{
    public LibroTecnico(string titulo, string autor, string genero) : base(titulo, autor, genero) { }
}



//Interfaz para la seleccion de estrategia de recomendacion

interface IRecomendable
{
    Libro ObtenerMejorLibro(List<Libro> libros);
}
//Estrategia basada en el promedio de calificaciones
public class RecomendacionPorPromedio : IRecomendable
{
    public Libro ObtenerMejorLibro(List<Libro> libros)
    {
        Libro mejorLibro = null;
        double mejorpromedio = -1;

        foreach (var libro in libros)
        {
            double promedio = libro.ObtenerPromedio();

            if (promedio > mejorpromedio)
            {
                mejorpromedio = promedio;
                mejorLibro = libro;
            }
        }
        return mejorLibro;
    }
}


// estrategia basada en la cantidad de votos
public class RecomendacionPorVotos : IRecomendable
{
    public Libro ObtenerMejorLibro(List<Libro> libros)
    {
        Libro mejorLibro = null;
        int maxVotos = -1;

        foreach (var libro in libros)
        {
            int votos = libro.ObtenerCantidadVotos();
            if (votos > maxVotos)
            {
                maxVotos = votos;
                mejorLibro = libro;
            }
        }
        return mejorLibro;
    }
}






// Clase para libreria

public class Libreria
{
    private List<Libro> libros = new List<Libro>();
    private IRecomendable estrategiarecomendiacion = new RecomendacionPorPromedio();
    private readonly string[] generoFiccion = { "Ciencia Ficcion", "Fantasia", "Romance", "Misterio", "Horror", "Novela" };
    private readonly string[] generoTecnico = { "Programacion", "ED", "Termodinamica", "MecanicaFluidos", "Diccionario", "Negocios" };
    //metodos de mi libreria
    public void AgregarLibro(string titulo, string autor, string genero)
    {
        if (generoFiccion.Contains(genero))
        {
            libros.Add(new LibroFiccion(titulo, autor, genero));
        }
        else if (generoFiccion.Contains(genero))
        {
            libros.Add(new LibroTecnico(titulo, autor, genero));
        }
        else
        {
            throw new ArgumentException("Genero no reconocido.");
        }
    }

    public void CalificarLibro(string titulo, int nota)
    {
        Libro libroEncontrado = null;
        foreach (var libro in libros)
        {
            if (libro.Titulo == titulo)
            {
                libroEncontrado = libro;
                break;
            }
        }

        if (libroEncontrado == null)
        {
            throw new KeyNotFoundException("Libro no encontrado.");
        }
        else if (libroEncontrado != null)
        {
            libroEncontrado.Calificar(nota);
        }
    }
    
    //Sobrecarga de calificar libro
    public void CalificarLibro(string titulo, int nota, string comentario)
    {
        Libro libroEncontrado = null;
        foreach (var libro in libros)
        {
            if (libro.Titulo == titulo)
            {
                libroEncontrado = libro;
                break;
            }
        }

        if (libroEncontrado == null)
        {
            throw new KeyNotFoundException("Libro no encontrado.");
        }
        else if (libroEncontrado != null)
        {
            libroEncontrado.Calificar(nota, comentario);
        }
    }

    //Criterio de calificacion
    public void CambiarCriterio(string criterio)
    {
        if (criterio == "PROMEDIO")
        {
            estrategiarecomendiacion = new RecomendacionPorPromedio();
        }
        else if (criterio == "VOTOS")
        {
            estrategiarecomendiacion = new RecomendacionPorPromedio();
        }
        else
        {
            throw new ArgumentException("Criterio no reconocido.");
        }
    }

    //Mejor libro

}