//calculadora basica

Console.WriteLine("Ingresa el primer numero a operar:");
double numero1 = double.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Ingresa el primer numero a operar:");
double numero2 = double.Parse(Console.ReadLine() ?? "");


Calculadora calculadora1 = new Calculadora(numero1, numero2);
Calculadora calculadora2 = new Calculadora(1, 2);
Calculadora sumaCalcu = calculadora1 + calculadora2;

Console.WriteLine($"Suma de calculadoras : {sumaCalcu.Numero1} {sumaCalcu.Numero2}");

/*
//Bandera
//Seleccion de calculadora
Console.WriteLine("Selecciona la calculadora a utilizar: \n1- Calculadora basica\n2- Calculadora Cientifica");
int opCalculadora = int.Parse(Console.ReadLine() ?? "");
switch(opCalculadora)
{
    case 1:
        //Instanciar objeto calculadora
        Console.WriteLine("Calculadora basica seleccionada");
        Calculadora calculadoraB = new Calculadora(numero1, numero2);

        //Seleccion de operaciones
=======

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

        

        int opcion = int.Parse(Console.ReadLine() ?? "");

        switch (opcion)
        {
            case 1:
                calculadoraB.Sumar();
                calculadoraB.Sumar(5);
                calculadoraB.Sumar(6, 6);

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

        Console.WriteLine("Caluculadora cientifica seleccionada");
        //Instansear objeto calculadora cientifica
        CalculadoraCientifica calculadoraC = new CalculadoraCientifica(numero1, numero2);
        //Seleccion de operaciones

        Console.WriteLine("Calculadora Cientifica seleccionada");
        CalculadoraCientifica calculadoraC = new CalculadoraCientifica(numero1, numero2);

        //Seleccion de operaciones


        Console.WriteLine("Selecciona la operacion a realizar:");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.WriteLine("5. Factorial");
        Console.WriteLine("6. Raiz cuadrada");
        Console.WriteLine("7. Logaritmo");
        calculadoraC.MensajeCalculadora(); 
        int opcionc = int.Parse(Console.ReadLine() ?? "");

        switch (opcionc)
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

                Console.WriteLine($"Resultado: {calculadoraC.Factorial()}");
                break;
            case 6:
                Console.WriteLine($"Resultado: {calculadoraC.RaizCuadrada()}");
                break;
            case 7:
                Console.WriteLine($"Resultado: {calculadoraC.Logaritmo()}");

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


*/



}

