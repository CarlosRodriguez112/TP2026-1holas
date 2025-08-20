Console.WriteLine("Hello world");


Console.WriteLine("Ingrese su numero natural: ");

int f = int.Parse(Console.ReadLine() ?? "");

if(f<0)
{
    Console.WriteLine("Tu numero es negativo, positivo por favor");
}
else
{
    for(int i=f-1; i>=1; i--)
    {
        f = f * i;
        
    }
    Console.WriteLine($"Factorial es: {f}");
}

