// El auto
public class Auto : Vehiculo
{
   // Contructor 

    public Auto(string marca, string modelo) : base(marca, modelo)
    {

    }


    //Modificar metodo del padre
    public override void MostrarInfo()
    {
        Console.WriteLine($"Vehiculo: {marca}, Marca: {modelo}, Velocidad Actual: {velocidadActual} km/h");
    }
}