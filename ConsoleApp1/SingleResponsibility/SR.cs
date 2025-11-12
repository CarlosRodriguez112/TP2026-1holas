//SOLID

//Viola el principio de responsabilidad única
public class Libro
{
    //Atributos, Primera responsabilidad
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Paginas { get; set; }

    //Responsabilidad almacenar datos, segunda responsabilidad
    public void GuardarBD()
    {
        //COdigo para la BD
        Console.WriteLine($"Guardando en la base de datos...");
    }

    //Responsabilidad generar reporte, tercera responsabilidad
    public void GenerarReporte(double calificacion)
    {
        Console.WriteLine($"Reporte para: {Titulo} por {Autor}, {calificacion}");
    }
}


//Ejemplo sin violar SR

public class LibroSR
{
    //Atributos, Primera responsabilidad
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Paginas { get; set; }

}

public class RepositorioLibros
{

    //Responsabilidad almacenar datos, segunda responsabilidad
    public void GuardarBD()
    {
        //Codigo para la BD
        Console.WriteLine($"Guardando en la base de datos...");
    }

}

public class GeneradorReportes
{
    //Responsabilidad generar reporte, tercera responsabilidad
    public void GenerarReporte(LibroSR libro, int calificacion)
    {
        Console.WriteLine($"Reporte para: {libro.Titulo} por {libro.Autor}, {calificacion}");
    }
}