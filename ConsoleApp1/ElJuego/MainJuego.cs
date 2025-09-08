// Programa principal del juego
try
{
    Console.WriteLine("Bienvenido al juego de combate de guerreros");

}

catch
{

}


static string ObtenerNombre()
{
    while (true)
    {
        try
        {
            Console.WriteLine("Ingresa el nombre del guerrero: ");
            string nombre = Console.ReadLine() ?? "".Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                throw new Exception("El nombre no puede estar vacio");
            }
            //Tarea TODO : Evitar que la cadena tenga numeros o caracteres especiales
            if (nombre.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c)))
            {
                throw new Exception("El nombre no puede contener numeros o caracteres especiales");
            }
            return nombre;
        }
        catch
        {
            Console.WriteLine("Error al ingresar el nombre. Intentelo de nuevo");
        }
    }
}


//Funcion para obtener selección de menú
static int ObtenerOpcion()
{
    while (true)
    {
        try
        {
            Console.WriteLine("Ingresa tu opcion: ");

            int opcion = int.Parse(Console.ReadLine() ?? "");
            if (opcion != 1 && opcion != 2)
            {
                throw new ArgumentException("Opcion no valida, debes ingresar 1 o 2");
            }
            return opcion;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}. Intentelo de nuevo");
        }
    }
}

//Seleccion de clase
static Guerrero SeleccionarClase(string nombre)
{
    while(true)
    {
        try
        {
            Console.WriteLine("Selecciona la clase de tu guerrero:");
            Console.WriteLine("1. Mago");
            Console.WriteLine("2. Arquero");
            Console.WriteLine("3. Guerrero Sombra");
            Console.WriteLine("4. Caballero");
            int opcion = int.Parse(Console.ReadLine() ?? "");

            return opcion switch
            {
                1 => new Mago(nombre),
                2 => new Arquero(nombre),
                3 => new GuerreroSombra(nombre),
                4 => new Caballero(nombre),
                _ => throw new ArgumentException("Opcion no valida"),
            };
        }
        catch (Exception ex)
        {
            throw new ArgumentException($"Error al seleccionar la clase: {ex.Message}");
        }
    }
}



// Funcion para generar al enemigo
static Guerrero GenerarEnemigo()
{
    string[] nombres = { "Goblin", "Orco", "Dragon", "Esqueleto", "Creeper" };
    string nombre = nombres[new Random().Next(nombres.Length)];

    int[] vidas = { 90, 100, 200, 150, 1000 };
    int vida = vidas[new Random().Next(vidas.Length)];

    int[] ataques = { 15, 27, 22, 30, 35 };
    int ataque = ataques[new Random().Next(ataques.Length)];

    return new Guerrero(nombre, vida, ataque);
}