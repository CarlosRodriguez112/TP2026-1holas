public class Inventario
{
    //Atributos
    private Suministro[] suministros;
    
    //Constructor
    public Inventario()
    {
        suministros = new Suministro[]
        {
            new Suministro("Comida", 5, 1),
            new Suministro("Agua", 10, 1),
            new Suministro("Ropa", 7, 2),
            new Suministro("Antibioticos", 0, 1),
            new Suministro("Herramientas"),
            new Suministro("Oxigeno"),
            new Suministro("Combustible")
        };
    }

    //Metodos 
    public void MostrarSuministros()
    {
        Console.WriteLine("Inventario actual: ");
        foreach (Suministro item in suministros)
        {
            item.MostrarInfo();
        }
    }

    public void BuscarSuministro(string nombre)
    {
        int indice = Array.FindIndex(suministros, itemB => itemB.Nombre.ToLower() == nombre.ToLower());
        if (indice >= 0)
        {
            Console.WriteLine($"{nombre} encontrado en la posicion {indice}");
        }
        else
        {
            Console.WriteLine($"{nombre} No se encontro en el inventario");
        }
    }

    //Ordenar suministros por nombre
    public void OrdenarPorNombre()
    {
        Array.Sort(suministros, (x, y) => x.Nombre.CompareTo(y.Nombre));
        Console.WriteLine("Inventario ordenado por nombre");
    }
    //Invertir el orden 
    public void InvertirOrden()
    {
        Array.Reverse(suministros);
        Console.WriteLine("Orden de los suministros invertidos");
    }

}