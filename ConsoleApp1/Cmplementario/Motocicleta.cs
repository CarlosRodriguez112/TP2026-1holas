// Las motos

public class Moto : Vehiculo
{
    //Constructor
    public Moto(string marca, string modelo) : base(marca, modelo)
    {
        
    }
    //Meotodo sobreescrito
    public override void MostrarInfo()
    {
        Console.WriteLine($"Moto: {marca}, Marca: {modelo}, Velocidad Actual: {velocidadActual} km/h");
    }
}
