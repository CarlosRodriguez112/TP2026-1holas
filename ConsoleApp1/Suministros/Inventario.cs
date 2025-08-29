using System.Globalization;

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



    //Vaciar el inventario

    public void VaciarInventario()
    {
        Array.Clear(suministros, 0, suministros.Length);
        Console.WriteLine("El inventario ha sido vaciado");
        Console.WriteLine($"Longitud del inventario: {suministros.Length}");
    }



    //Agregar suministro 3 parametros

    public void AgregarSuministro(string nombre, int cantidad, int prioridad)
    {
        int indice = Array.FindIndex(suministros, itemB => itemB.Nombre.ToLower() == nombre.ToLower());
        if (indice >= 0)
        {
            Console.WriteLine($"Ya existe y {nombre} encontrado en la posicion {indice}");
        }
        else
        {
            Array.Resize(ref suministros, suministros.Length + 1);
            suministros[suministros.Length - 1] = new Suministro(nombre, cantidad, prioridad);
            Console.WriteLine($"{nombre} Ha sido agregado al inventario");
        }
    }


    //Agregar suministro unicamente con nombre
    public void AgregarSuministro(string nombre)
    {
        AgregarSuministro(nombre, 1, 2);
    }

    //Eliminar suministro

    public void EliminarSuministro(string nombre)
    {
        int indice = Array.FindIndex(suministros, itemB => itemB.Nombre.ToLower() == nombre.ToLower());
        if (indice >= 0)
        {
            for (int i= indice; i < suministros.Length - 1; i++)
            {
                suministros[i] = suministros[i + 1];
            }

            Array.Resize(ref suministros, suministros.Length - 1);
            Console.WriteLine($"{nombre} se elimno");
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else
        {
            Console.WriteLine($"{nombre} no esta en el inventario");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }
    }
}