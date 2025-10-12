using RobotLibrarydospuntocero;

try
{

    RobotMovil miRobot = new RobotMovil("RoboMax", 2.5f, 100, false);
    int opcion = -1;

    while (opcion != 0)
    {
        Console.WriteLine("\n--- CONTROL DEL ROBOT ---");
        Console.WriteLine("1. Encender robot");
        Console.WriteLine("2. Apagar robot");
        Console.WriteLine("3. Mostrar estado");
        Console.WriteLine("4. Verificar energía");
        Console.WriteLine("5. Recargar energía");
        Console.WriteLine("6. Mover adelante");
        Console.WriteLine("7. Mover atrás");
        Console.WriteLine("8. Giro por diferencia");
        Console.WriteLine("9. Giro por contrarrotación");
        Console.WriteLine("10. Detener robot");
        Console.WriteLine("11. Medir distancia");
        Console.WriteLine("12. Aumentar velocidad");
        Console.WriteLine("13. Reducir velocidad");
        Console.WriteLine("0. Salir");
        Console.Write("Seleccione una opción: ");

        opcion = int.Parse(Console.ReadLine() ?? "");
        Console.WriteLine();


        switch (opcion)
        {
            case 1:
                miRobot.Encender();
                break;
            case 2:
                miRobot.Apagar();
                break;
            case 3:
                miRobot.MostrarEstado();
                break;
            case 4:
                miRobot.VerificarEnergia();
                break;
            case 5:
                Console.Write("Ingrese cantidad de energía a recargar: ");
                if (int.TryParse(Console.ReadLine() ?? "", out int energia))
                {
                    miRobot.RecargarEnergia(energia);
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
                }
                break;
            case 6:
                if (miRobot.Estado)
                {
                    miRobot.Mover(miRobot.Velocidad, "adelante");
                    miRobot.ConsumirEnergia(5);
                }
                else
                {
                    Console.WriteLine("El robot está apagado. No se puede mover.");
                }
                break;
            case 7:
                if (miRobot.Estado)
                {
                    miRobot.Mover(miRobot.Velocidad, "atrás");
                    miRobot.ConsumirEnergia(5);
                }
                else
                {
                    Console.WriteLine("El robot está apagado. No se puede mover.");
                }
                break;
            case 8:
                if (miRobot.Estado)
                {
                    Console.Write("Ingrese dirección del giro (izquierda/derecha): ");
                    string direccion = Console.ReadLine() ?? "";
                    miRobot.GiroPorDiferencia(direccion);
                    miRobot.ConsumirEnergia(3);
                }
                else
                {
                    Console.WriteLine("El robot está apagado. No se puede girar.");
                }
                break;
            case 9:
                if (miRobot.Estado)
                {
                    Console.Write("Ingrese dirección del giro (izquierda/derecha): ");
                    string direccion = Console.ReadLine() ?? "";
                    miRobot.GiroPorDiferencia(direccion);
                    miRobot.ConsumirEnergia(4);
                }
                else
                {
                    Console.WriteLine("El robot está apagado. No se puede girar.");
                }
                break;
            case 10:
                miRobot.Detener();
                break;
            case 11:
                miRobot.ObtenerDistanciaSensor();
                break;
            case 12:
                if (miRobot.Estado)
                {
                    miRobot.AumentarVelocidad(5);
                    miRobot.ConsumirEnergia(2);
                }
                else
                {
                    Console.WriteLine("El robot está apagado. No se puede aumentar la velocidad.");
                }
                break;
            case 13:
                miRobot.ReducirVelocidad(10);
                break;
            case 0:
                Console.WriteLine("Saliendo del programa...");
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error inesperado: {ex.Message}");
}   