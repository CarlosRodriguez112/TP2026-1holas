//Programa principal del inventario Mision Orion X

// Instanciar Invntario

Inventario inventario = new Inventario();
bool salir = false;

do
{
    Console.ForegroundColor = ConsoleColor.Green;

    Console.WriteLine("Menu de suministros de la mision Orion X:");
    Console.WriteLine("1. Agregar Suministros");
    Console.WriteLine("2. Buscar Suministros");
    Console.WriteLine("3. Eliminar Suministros");
    Console.WriteLine("4. Mostrar Suministro");
    Console.WriteLine("5. Limpiar Suministro");
    Console.WriteLine("6. Salir");

    int opcion = int.Parse(Console.ReadLine() ?? "");

    switch(opcion)
    {
        case 1:
            Console.Write("Escribe el nombre del suministro a agregar: ");
            string nombre = Console.ReadLine() ?? "";
            if (nombre != "")
            {
                Console.WriteLine("Quieres asignar cantidad y prioridad?");
                Console.WriteLine("1. Si \n 2. No");
                int opA = int.Parse(Console.ReadLine() ?? "");
                switch(opA)
                {
                    case 1:
                        Console.WriteLine("Escribe la cantidad: ");
                        int cantidad = int.Parse(Console.ReadLine() ?? "");

                        Console.WriteLine("Escribe la prioridad: ");
                        int prioridad = int.Parse(Console.ReadLine() ?? "");

                        inventario.AgregarSuministro(nombre, cantidad, prioridad);
                        break;
                    case 2:
                        inventario.AgregarSuministro(nombre);
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Nombre no valido");
            }
                break;
        case 2:
            Console.WriteLine("Escribe el nombre del suministro a buscar");
            string nombreB = Console.ReadLine() ?? "";
            inventario.BuscarSuministro(nombreB);
            break;
        case 3:
            Console.WriteLine("Escribe el nombre del suministro a eliminar");
            string nombreC = Console.ReadLine() ?? "";
            inventario.EliminarSuministro(nombreC);
            break;
        case 4:
            inventario.MostrarSuministros();
            break;
        case 5:
            inventario.VaciarInventario();
            break;
        case 6:
            salir = true;
            break;
        default:
            Console.WriteLine("NO");
            break;
    }
}
while (!salir);
