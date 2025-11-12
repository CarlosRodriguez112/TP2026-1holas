//Programa principal

string ArchivoEstudiantes = "estudiantes.txt";
GestorEstudiantes gestor = new GestorEstudiantes(ArchivoEstudiantes);

//Crear lista de estudiantes de ejemplo
List<Estudiante> estudiantes = new List<Estudiante>
{ 
    new Estudiante { Id = 1, Nombre = "Juan Perez", Edad = 20, Calificacion = 8.5 },
    new Estudiante { Id = 2, Nombre = "Lucia Gomez", Edad = 22, Calificacion = 9.0 },
    new Estudiante { Id = 3, Nombre = "Mario Lopez", Edad = 18, Calificacion = 5.0 },
    new Estudiante { Id = 4, Nombre = "Samuel Estrada", Edad = 20, Calificacion = 6.5 },
    new Estudiante { Id = 5, Nombre = "Fernando Alfarado", Edad = 23, Calificacion = 10.0 }
};

//Guardar estudiantes en el archivo
Console.WriteLine("Guardando estudiantes...");
//gestor.GuardarEstudiante(estudiantes);

Console.WriteLine();
//Leer todos los estudiantes del archivo
Console.WriteLine("Leyendo estudiantes desde el archivo...");
List<Estudiante> estudiantesLeidos = gestor.LeerEstudiantes();
foreach (Estudiante estudiante in estudiantesLeidos)
{
    Console.WriteLine(estudiante.ToString());
}

//Buscar estudiante por Id (Secuencial)
Console.WriteLine();
Console.WriteLine("Buscando estudiante con Id = 3...");
Estudiante estudianteEncontrado = gestor.BuscarEstudiantePorId(3);
if (estudianteEncontrado != null)
{
    Console.WriteLine("Estudiante encontrado:");
    Console.WriteLine(estudianteEncontrado.ToString());
}

//clase estudiante

public class Estudiante
{
    //Atributos
    public int Id { get; set; }
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public double Calificacion { get; set; }

    //Metodo override de ToString
    public override string ToString()
    {
        return $"{Id}, {Nombre}, {Edad}, {Calificacion}";
    }
}

//Clase para manejar estudiantes

public class GestorEstudiantes
{
    private string rutaArchivo;

    //Contructor
    public GestorEstudiantes(string ruta)
    {
        rutaArchivo = ruta;
    }

    //Metodo parta guardar estudiante de forma secuencial
    public void GuardarEstudiante(List<Estudiante> estudiantes)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(rutaArchivo))
            {
                foreach (Estudiante estudiante in estudiantes)
                {
                    //Escribir cada propiedad separada por comas
                    writer.WriteLine(estudiante.ToString());
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al guardar estudiantes: {ex.Message}");
        }
    }

    //Metodo para leer todos los estudiantes del archivo
    public List<Estudiante> LeerEstudiantes()
    {
        List<Estudiante> estudiantes = new List<Estudiante>();
        try
        {
            if (File.Exists(rutaArchivo))
            {
                using (StreamReader reader = new StreamReader(rutaArchivo))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        // 001, Juan, 20, 7.5
                        //Dividir la linea por comas
                        string[] datos = linea.Split(',');
                        if (datos.Length == 4)
                        {
                            estudiantes.Add(new Estudiante
                            {
                                Id = int.Parse(datos[0]),
                                Nombre = datos[1],
                                Edad = int.Parse(datos[2]),
                                Calificacion = double.Parse(datos[3])
                            });
                        }
                    }
                }
                Console.WriteLine("Estudiantes leidos correctamente.");
            }
            else
            {
                Console.WriteLine("El archivo no existe. se devuelve una lista vacia");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al leer estudiantes: {ex.Message}");
        }
        return estudiantes;
    }

    //Buscar estudiante por Id
    public Estudiante BuscarEstudiantePorId(int id)
    {
        try
        {
            if (File.Exists(rutaArchivo))
            {
                using (StreamReader reader = new StreamReader(rutaArchivo))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        string[] datos = linea.Split(',');
                        if (int.Parse(datos[0]) == id)
                        {
                            return new Estudiante
                            {
                                Id = int.Parse(datos[0]),
                                Nombre = datos[1],
                                Edad = int.Parse(datos[2]),
                                Calificacion = double.Parse(datos[3])
                            };
                        }
                    }
                }
                Console.WriteLine("Estudiantes leidos correctamente.");
            }
            else
            {
                Console.WriteLine("El archivo no existe. se devuelve una lista vacia");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al leer estudiantes: {ex.Message}");
        }

        Console.WriteLine("Estudiante no encontrado.");
        return null;
    }
}
