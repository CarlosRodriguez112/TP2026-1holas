public class PersonaL
{
    //Atributos

    public string Nombre { get; set; }
    public int Edad { get; set; }

    //Constructor

    public PersonaL(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {Nombre} \n Edad: {Edad}");
    }
}