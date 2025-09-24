using BiblotecadeLibro;
using ExtensionesBibloteca;
using ValidacionesBilioteca;

GestordeLibros gestordeLibros = new GestordeLibros();
// Agregar libro
gestordeLibros.AgregarLibro(new Libro("Los de abajo", "Mariano Azuela", 869));
gestordeLibros.AgregarLibro(new Libro("Cien años de soledad", "Garcia Marquez", 1967));
gestordeLibros.AgregarLibro(new Libro("Don quijote", "Miguel Cervantes", 1605));
gestordeLibros.AgregarLibro(new Libro("El gato negro", "Edgar Allan Poe", 1843));
gestordeLibros.AgregarLibro(new Libro("Cien años de soledad", "Garcia Marquez", 2000));


//Mostrar Libros
Console.WriteLine("Libros disponibles:");
gestordeLibros.MostrarLibros();

//Eliminiar libro
Console.WriteLine("Escribe el titulo a descartar:");
string titulo = Console.ReadLine() ?? "";

gestordeLibros.EliminarLibro(titulo);

//Buscar libro por autor
Console.WriteLine("Escribe el autor a buscar:");
string autor = Console.ReadLine() ?? "";

List <Libro> librosAutor = gestordeLibros.BuscarLibrosAutor(autor);   
foreach (var libro in librosAutor)
{
    Console.WriteLine(libro.Titulo);
}


//Usar metodo de extension
var libro1 = gestordeLibros.BuscarLibrosAutor("Edgar Allan Poe")[0];
Console.WriteLine("Informacion del libro: ");
Console.WriteLine(libro1.InformacionLibro());

Console.WriteLine("Es libro antiguo: " + libro1.EsLibroClasico());

//Metodos de validacion

Console.WriteLine("Validaciones: ");
Console.WriteLine("Es un año valido: " + Validaciones.EsTituloValido(libro1.AnioPublicacion));
Console.WriteLine("Es un titulo valido: " + Validaciones.EsTituloValido(libro1.Titulo));