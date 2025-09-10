// Programa principal del juego
try
{
    Console.WriteLine("Bienvenido al juego de combate de guerreros");

    string nombreJugador = ObtenerNombre();

    //Seleccion de clase de guerrero
    Guerrero jugador = SeleccionarClase(nombreJugador);
    Guerrero enemigo = GenerarEnemigo();

    Console.WriteLine($"Te enfrentaras contra {enemigo.Nombre}");

    while (jugador.Vida > 0 && enemigo.Vida > 0)
    {
        MostrarEstado(jugador, enemigo);
        int opcion = ObtenerOpcion();

        if (opcion == 1)
        {
            jugador.Atacar(enemigo);
        }
        else if (opcion == 2)
        {
            int proba = new Random().Next(0, 100);
            if (proba < 50)
            {
                Console.WriteLine($"La fusion falló y perdiste vida");
                jugador.RecibirDanio((int) (jugador.Vida * 0.1f));
            }
            else
            {
                jugador = jugador + enemigo;
                Console.WriteLine($"La fusion salio bien eres un nuevo guerrero {jugador.Nombre}");
            }
        }
        else
        {
            throw new ArgumentException("Opción no valida");
        }
    }
    if (enemigo.Vida > 0)
    {
        enemigo.Atacar(jugador);
    }

    Console.WriteLine(jugador.Vida > 0 ? "Haz ganado!!" : "Perdiste...");
}

catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}


finally
{
    Console.WriteLine("Gracias por jugar"); 
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

//Funcion mostrar el estado
static void MostrarEstado(Guerrero jugador, Guerrero enemigo)
{
    Console.WriteLine($"Tu vida: {jugador.Vida} | La vida del enemigo: {enemigo.Vida}");
    Console.WriteLine("1. Atacar");
    Console.WriteLine("2. Fusionar con el enemigo");

}