//calculadora basica

Console.WriteLine("Ingresa el primer numero a operar:");
double numero1 = double.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Ingresa el primer numero a operar:");
double numero2 = double.Parse(Console.ReadLine() ?? "");


Console.WriteLine("¿Que calculadora desea usar:\n 1. Basica\n 2. Cientifica");
int tipoCalculadora = int.Parse(Console.ReadLine() ?? "");
switch(tipoCalculadora)
{
    case 1:
        Console.WriteLine("Calculadora Basica seleccionada");
        Calculadora calculadoraB = new Calculadora(numero1, numero2);

        //Seleccion de operaciones

        Console.WriteLine("Selecciona la operacion a realizar:");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");

        int opcionB = int.Parse(Console.ReadLine() ?? "");

        switch (opcionB)
        {
            case 1:
                calculadoraB.Sumar();
                break;
            case 2:
                calculadoraB.Restar();
                break;
            case 3:
                calculadoraB.Multiplicar();
                break;
            case 4:
                calculadoraB.Dividir();
                break;
            default:
                Console.WriteLine("Opcion no valida");
                break;
        }
        break;
    case 2:
        Console.WriteLine("Calculadora Cientifica seleccionada");
        CalculadoraCientifica calculadoraC = new CalculadoraCientifica(numero1, numero2);

        //Seleccion de operaciones

        Console.WriteLine("Selecciona la operacion a realizar:");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.WriteLine("5. Factorial");
        Console.WriteLine("6. Raiz Cuadrada");
        Console.WriteLine("7. Potencia");
        Console.WriteLine("8. Logartimo");

        int opcionC = int.Parse(Console.ReadLine() ?? "");

        switch (opcionC)
        {
            case 1:
                calculadoraC.Sumar();
                break;
            case 2:
                calculadoraC.Restar();
                break;
            case 3:
                calculadoraC.Multiplicar();
                break;
            case 4:
                calculadoraC.Dividir();
                break;
            case 5:
                calculadoraC.Factorial();
                break;
            case 6:
                calculadoraC.RaizCuadrada();
                break;
            case 7:
                calculadoraC.Potencia();
                break;
            case 8:
                calculadoraC.Logartimo();
                break;
            default:
                Console.WriteLine("Opcion no valida");
                break;
        }
        break;
    default:
        Console.WriteLine("Opcion no valida");
        break;


}