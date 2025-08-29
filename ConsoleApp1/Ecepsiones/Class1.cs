int numero;

Console.WriteLine("Este programa solamente divide 10 entre un numero positivo y entero");


try
{
    numero = int.Parse(Console.ReadLine() ?? "");
    if (numero < 0)
    {
        throw new ArgumentException("El numero no puede ser negativo");
    }
    double division = 10 / numero;
    Console.WriteLine($"Resultado: {division}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("No se puede dividir entre cero");
}

catch (FormatException)
{
    Console.WriteLine("El numero ingresado no es valido");
}
catch (ArgumentException)
{
    Console.WriteLine("El numero no puede ser negativo");
}
catch (Exception ex)
{
    Console.WriteLine($"Error inesperado {ex.Message}");
}
finally
{
    Console.WriteLine("El programa termino");
}