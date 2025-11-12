//Programa principal

// Crear intancia del gestor de productos

GestorProductos gestor = new GestorProductos();

// Actividad 1: Implementar las estructuras de datos
Console.WriteLine("=== Actividad 1: Estructura de datos ===");

//Agregar productos
gestor.AgregarProducto(new Producto
{
    Id = 3,
    Nombre = "Laptop",
    CodigoBarra = "123456",
    Categoria = "Electronica",
    Precio = 300,
    Stock = 10
});

gestor.AgregarProducto(new Producto
{
    Id = 16,
    Nombre = "Mouse",
    CodigoBarra = "7890123",
    Categoria = "Electronica",
    Precio = 100,
    Stock = 8
});

gestor.AgregarProducto(new Producto
{
    Id = 1,
    Nombre = "Chicles",
    CodigoBarra = "159263",
    Categoria = "Dulces",
    Precio = 2,
    Stock = 50
});

gestor.AgregarProducto(new Producto
{
    Id = 6,
    Nombre = "Manzanas",
    CodigoBarra = "7845963",
    Categoria = "Frutas",
    Precio = 10,
    Stock = 20
});

//Mostrar inventario
gestor.MostrarInventario();

//Mostrar productos por categoria
gestor.MostrarProductosPorCategoria("Electronica");

//Obtener lista de productos}
//List<Producto> nuevaLista = gestor.ObtenerListaProductos();

//Buscar producto por codigo de barras  //DICCIONARIO
Console.WriteLine("Buscando producto con codigo de barras '7845963':");
Producto productoEncontrado = gestor.BuscarPorCodigo("7845963");
Console.WriteLine(productoEncontrado != null ? productoEncontrado.ToString() : "Producto no encontrado.");

//Existe producto
Console.WriteLine("Verificando existencia del producto con codigo de barras '159263':");
Console.WriteLine($"El producto con codigo 159263: {gestor.ExixteProducto("159263")}");
Console.WriteLine($"El producto con codigo 265892: {gestor.ExixteProducto("265892")}");

//Eliminar producto
Console.WriteLine("Eliminando producto con codigo de barras '159263':");
Console.WriteLine($"El producto con codigo 159263 fue eliminado: {gestor.EliminarProducto("159263")}");


//Mostrar inventario actualizado
gestor.MostrarInventario();

Console.WriteLine();
// Actividad 2: Implementar algoritmos de ordenamiento
Console.WriteLine("\n=== Actividad 2: Algoritmos de ordenamiento ===");

//Crear copia de la lista para ordenamiento
//Obtener lista de productos}
List<Producto> nuevaLista = gestor.ObtenerListaProductos();

//Ordenamiento por QuickSort 
Console.WriteLine("Ordenamiento por precio (QuickSort):");
OrdenadorSimplificado.QuickSortporPrecio(nuevaLista);
ImprimirListaProductos(nuevaLista);

//Ordenamiento por Nombre (MergeSort)
Console.WriteLine("Ordenamiento por Nombre (MergeSort):");
List<Producto> productosOrdenadosporNombre = OrdenadorSimplificado.MergeSortPorNombre(new List<Producto>(gestor.ObtenerListaProductos()));
ImprimirListaProductos(nuevaLista);

Console.WriteLine();
// Actividad 3: Implementar algoritmos de busqueda
Console.WriteLine("\n=== Actividad 3: Algoritmos de busqueda ===");

//Ordenar por Id para busqueda binaria
List<Producto> productosparaBusqueda = new List<Producto>(gestor.ObtenerListaProductos());
OrdenadorSimplificado.QuickSortporId(productosparaBusqueda);

//Busqueda binaria por Id
Console.WriteLine("Busqueda binaria por Id (ID = 16):");
var (productoBIN, iteracionesBinaria) = BuscadorSimplificado.BusquedaBinaria(productosparaBusqueda, 16);
Console.WriteLine($"Resultado: {(productoBIN != null ? productoBIN.ToString() : "Producto no encontrado.")}, Iteraciones: {iteracionesBinaria}");

//Busqueda secuencial por Nombre
Console.WriteLine("Busqueda secuencial por Nombre (Nombre = 'Manzanas'):");
var (productoSEQ, iteracionesSecuencial) = BuscadorSimplificado.BusquedaSecuencialNombre(gestor.ObtenerListaProductos(), "Manzanas");
Console.WriteLine($"Resultado: {(productoSEQ != null ? productoSEQ.ToString() : "Producto no encontrado.")}, Iteraciones: {iteracionesSecuencial}");

//Comparacion de eficiencia
Console.WriteLine("\nComparacion de eficiencia:");
Console.WriteLine($"Busqueda Binaria Iteraciones: {iteracionesBinaria}");
Console.WriteLine($"Busqueda Secuencial Iteraciones: {iteracionesSecuencial}");
//Metodo auxiliar para imprimir lista
static void ImprimirListaProductos(List<Producto> productos)
{
    foreach (Producto p in productos)
    {
        Console.WriteLine(p.ToString());
    }
}

//Actividad  1
public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string CodigoBarra { get; set; } // Campo unico
    public string Categoria { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }

    public override string ToString()
    {
        return $"[{Id}] {CodigoBarra} - {Nombre} | ${Precio} Stock: {Stock} | ({Categoria}):";
    }

}

public class GestorProductos
{
    //LISTA: para mantener orden de inserción
    private List<Producto> listaProductos = new List<Producto>();

    //DICCIONARIO: busquedas
    private Dictionary<string, Producto> diccionarioporCodigo = new Dictionary<string, Producto>();

    public List<Producto> ObtenerListaProductos()
    {
        return new List<Producto>(listaProductos);
    }

    //Operaciones LISTA
    public void AgregarProducto(Producto p)
    {
        //Validar codigo de barras unico
        if (diccionarioporCodigo.ContainsKey(p.CodigoBarra))
        {
            throw new Exception("El codigo de barra ya existe.");
        }
        listaProductos.Add(p);
        diccionarioporCodigo[p.CodigoBarra] = p;
    }

    

    public void MostrarInventario()
    {
        Console.WriteLine("Inventario en orden de ingreso:");
        foreach (var item in listaProductos)
        {
            Console.WriteLine(item.ToString());
        }
    }

    public void MostrarProductosPorCategoria(string categoria)
    {
        //Usamos lista recorridos secuenciales
        Console.WriteLine($"Productos en la categoria: {categoria}");
        foreach (var item in listaProductos)
        {
            if (item.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

    //Operaciones DICCIONARIO (Busquedas)
    public Producto BuscarPorCodigo(string codigoBarras)
    {
        return diccionarioporCodigo.TryGetValue(codigoBarras, out var producto) ? producto : null;
    }

    public bool ExixteProducto(string codigoBarras)
    {
        return diccionarioporCodigo.ContainsKey(codigoBarras);
    }

    public bool EliminarProducto(string codigoBarras)
    {
        if (diccionarioporCodigo.TryGetValue(codigoBarras, out var producto))
        {
            listaProductos.Remove(producto);
            diccionarioporCodigo.Remove(codigoBarras);
            return true;
        }
        return false;
    }
}



//Actividad 2 Ordenamiento
public class OrdenadorSimplificado
{
    public static void QuickSortporId(List<Producto> productos)
    {
        if (productos.Count <= 1)
            return;

        // 1- Seleccionar un elemento pivote (Ultimo elemento)
        Producto pivote = productos[productos.Count - 1];

        // 2- Reorganizar la lista con elementos menores y elementos mayores a la derecha
        var menores = new List<Producto>();
        var mayores = new List<Producto>();

        for (int i = 0; i < productos.Count - 1; i++)
        {
            if (productos[i].Id <= pivote.Id)
            { 
                menores.Add(productos[i]); 
            }
            else
            {
                mayores.Add(productos[i]);
            }
        }

        // 3- Recursivamente aplica el algoritmo a las sublistas formadas
        QuickSortporId(menores);
        QuickSortporId(mayores);

        // 4- Combina las sublistas para obtener la lista ordenada
        productos.Clear();
        productos.AddRange(menores);
        productos.Add(pivote);
        productos.AddRange(mayores);

    }


    public static void QuickSortporPrecio(List<Producto> productos)
    {
        if (productos.Count <= 1)
            return;

        // 1- Seleccionar un elemento pivote (Ultimo elemento)
        Producto pivote = productos[productos.Count - 1];

        // 2- Reorganizar la lista con elementos menores y elementos mayores a la derecha
        var menores = new List<Producto>();
        var mayores = new List<Producto>();

        for (int i = 0; i < productos.Count - 1; i++)
        {
            if (productos[i].Precio <= pivote.Id)
            {
                menores.Add(productos[i]);
            }
            else
            {
                mayores.Add(productos[i]);
            }
        }

        // 3- Recursivamente aplica el algoritmo a las sublistas formadas
        QuickSortporPrecio(menores);
        QuickSortporPrecio(mayores);

        // 4- Combina las sublistas para obtener la lista ordenada
        productos.Clear();
        productos.AddRange(menores);
        productos.Add(pivote);
        productos.AddRange(mayores);
    }


    //Ordenamiento por MergeSort
    public static List<Producto> MergeSortPorNombre(List<Producto> productos)
    {
        if (productos.Count <= 1)
            return productos;

        //1- Dividir la lista en dos partes (mitad)
        int mitad = productos.Count / 2;
        var izquierda = productos.GetRange(0, mitad);
        var derecha = productos.GetRange(mitad, productos.Count - mitad);

        //2- Repite proceso para cada mitad (Hasta tener solo un elemento)
        izquierda = MergeSortPorNombre(izquierda);
        derecha = MergeSortPorNombre(derecha);

        //3- Mezclar las mitades ordenadas
        //Mezclar
        return Mezclar(izquierda, derecha);
    }

    private static List<Producto> Mezclar(List<Producto> izquierda, List<Producto> derecha)
    {
        //Comparar el primer elemento de cada mitad
        // * El menor se coloca primero en la nueva lista

        var resultado = new List<Producto>();
        int i = 0, j = 0;

        //Comparar y agregar orden 
        while (i < izquierda.Count && j < derecha.Count)
        {
            if (string.Compare(izquierda[i].Nombre, derecha[j].Nombre) <= 0)
            {
                resultado.Add(izquierda[i++]);
            }
            else
            {
                resultado.Add(derecha[j++]);
            }
        }

        //Agregar elementos restantes
        while (i < izquierda.Count)
        {
            resultado.Add(izquierda[i++]);
        }

        while (j < derecha.Count)
        {
            resultado.Add(derecha[j++]);
        }
        return resultado;
    }
}



//Actividad 3 Busquedas
public class BuscadorSimplificado
{
    //Busqueda binaria (Lista ordenada por ID)
    public static (Producto, int) BusquedaBinaria(List<Producto> productos, int idBuscado) //Devuelve el producto y la cantidad de iteraciones
    {
        int inicio = 0;
        int fin = productos.Count - 1;
        int iteraciones = 0;
        
        //Parte de una lista ordenada
        //Divida en la mitad la lista
        //1- Calcular el punto medio
        
        while (inicio <= fin)
        {
            iteraciones++;

            //1- La mitad de la lista ordenada
            int medio = (inicio + fin) / 2;

            //2- Comprobar si encontramos el ID
            if (productos[medio].Id == idBuscado)
            {
                return (productos[medio], iteraciones);
            } 

            //3- Ajustar los limites de busqueda
            if (productos[medio].Id < idBuscado)
            {
                inicio = medio + 1; //Buscar en la mitad derecha
            }
            else
            {
                fin = medio - 1; //Buscar en la mitad izquierda
            }
        }
        return (null, iteraciones); //No encontrado
    }

    //Busqueda secuencial (Lista no ordenada)
    public static (Producto, int) BusquedaSecuencialNombre(List<Producto> productos, string nombreBuscado) //Devuelve el producto y la cantidad de iteraciones
    {
        int iteraciones = 0;

        //1- recorrer la lista uno por uno
        foreach (Producto producto in productos)
        {
            iteraciones++;

            //2- Comparar el nombre (sin distinguir mayusculas y minusculas)
            if (producto.Nombre.Equals(nombreBuscado, StringComparison.OrdinalIgnoreCase))
            {
                return (producto, iteraciones);
            }
        }
        return (null, iteraciones); //No encontrado
    }

}