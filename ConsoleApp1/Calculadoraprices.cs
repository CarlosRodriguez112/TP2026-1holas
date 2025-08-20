//calculadora basica

Console.WriteLine("Ingresa el primer numero a operar:");
double numero1 = double.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Ingresa el primer numero a operar:");
double numero2 = double.Parse(Console.ReadLine() ?? "");

//Instanciar objeto calculadora

Calculadora calculadora = new Calculadora(numero1, numero2);

//Seleccion de operaciones

Console.WriteLine("Selecciona la operacion a realizar:");
Console.WriteLine("1. Sumar");
Console.WriteLine("2. Restar");
Console.WriteLine("3. Multiplicar");
Console.WriteLine("4. Dividir");

int opcion = int.Parse(Console.ReadLine() ?? "");

switch(opcion)
{
    case 1:
        calculadora.Sumar();
        break;
    case 2:
        calculadora.Restar();
        break;
    case 3:
        calculadora.Multiplicar();
        break;
    case 4:
        calculadora.Dividir();
        break;
    default:
        Console.WriteLine("Opcion no valida");
        break;
}

CalculadoraCientifica calculadoraCientifica = new CalculadoraCientifica(numero1, numero2);
