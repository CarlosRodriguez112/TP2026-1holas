public class Suministro
{
    //Atributos
    public string Nombre { get; set; }
    public int Cantidad { get; set; }
    public int Prioridad { get; set; }
    //Constructor 
    public Suministro(string nombre, int cantidad, int prioridad)
    {
        Nombre = nombre;
        Cantidad = cantidad;
        Prioridad = prioridad;
    }
    //Sobre carga del constructor
    public Suministro(string nombre)
    {
        Nombre = nombre;
        Cantidad = 1;
        Prioridad = 2;
    }
    //Metodos
    public void MostrarInfo()
    {
        Console.WriteLine($"{Nombre}, {Cantidad}, {Prioridad}");
    }

}