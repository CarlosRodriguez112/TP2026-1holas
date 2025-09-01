Lampara lampara1 = new Lampara("Lampara de mesa", 100);

lampara1.Encender();
lampara1.AjustarConsumo();
lampara1.AjustarIntensidad(2800);
lampara1.MostrarInfo();

Console.WriteLine("");

Ventilador ventilador1 = new Ventilador("Ventilador de techo", 100);
ventilador1.Encender();
ventilador1.AjustarConsumo(2500);
ventilador1.AjustarVelocidad(800);
ventilador1.MostrarInfo();

Console.WriteLine("");

if (ventilador1.Consumo > lampara1.Consumo)
{
    Console.WriteLine("El ventilador consume más que la lámpara.");
}
else if (ventilador1.Consumo < lampara1.Consumo)
{
    Console.WriteLine("La lámpara consume más que el ventilador.");
}
else if (ventilador1.Consumo == lampara1.Consumo)
{
    Console.WriteLine("Ambos dispositivos consumen lo mismo.");
}