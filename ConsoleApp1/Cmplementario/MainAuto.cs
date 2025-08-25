// programa principal de Auto

Auto auto1 = new Auto("Honda", "Civic");
auto1.MostrarInfo();

auto1.Acelerar(100);
Console.WriteLine($"El auto ha aceleró: {auto1.VelocidadActual} km/h");

auto1.Acelerar();
Console.WriteLine($"El auto ha aceleró: {auto1.VelocidadActual} km/h");


auto1.Frenar(20);
Console.WriteLine($"El auto frenado: {auto1.VelocidadActual} km/h");




Moto moto1 = new Moto("Yamaha", "MT-07");
moto1.MostrarInfo();

moto1.Acelerar(-50);
Console.WriteLine($"La moto ha aceleró: {moto1.VelocidadActual} km/h");

moto1.Frenar(20);
Console.WriteLine($"La moto frenado: {moto1.VelocidadActual} km/h");


if (auto1 > moto1)
{
    Console.WriteLine($"El numero {auto1} es mayor que {moto1}");
}
else if (auto1 < moto1)
{
    Console.WriteLine($"El numero {auto1} es menor que {moto1}");
}
else if (auto1 == moto1)
{
    Console.WriteLine($"El numero {auto1} es igual que {moto1}");
}