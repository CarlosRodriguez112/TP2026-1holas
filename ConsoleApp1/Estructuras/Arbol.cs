// árbol

// N nodos
// N-1 aristas
// //Longitud  - Ruta de la cantidad de aristas que contiene

//Árbol binario
//Cada nodo tiene como máximo dos hijos

// -Datos nombre de persona
// -Hijo izquierdo: primer hijo
// -Hijo derecho: segundo hijo

//Clase para crear nodos en el árbol


//Recorrer árbol
//Preorden: Padre -> Hijo Izquierdo -> Hijo Derecho
//Inorden: Hijo Izquierdo -> Padre -> Hijo Derecho

//Postorden: Hijo Izquierdo -> Hijo Derecho -> Padre

var arbol = new ArbolBinario("Juan");
arbol.Raiz.InsertarHijo("Ana", true);
arbol.Raiz.InsertarHijo("Luis", false);

arbol.Raiz.HijoIzquierdo.InsertarHijo("Sofia", true);
arbol.Raiz.HijoIzquierdo.InsertarHijo("Pedro", false);

arbol.Raiz.HijoDerecho.InsertarHijo("Carlos", true);

Console.WriteLine("Estructura del árbol:");
arbol.ImprimirArbol(arbol.Raiz);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("[Preorden]");
arbol.RecorrerPreorden(arbol.Raiz);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("[Inorden]");
arbol.RecorrerInorden(arbol.Raiz);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("[PostOrden]");
arbol.RecorrerPostorden(arbol.Raiz);
Console.WriteLine();
Console.WriteLine();

public class NodoArbol
{
    public string Nombre { get; private set; }
    public NodoArbol HijoIzquierdo { get; private set; }
    public NodoArbol HijoDerecho { get; private set; }
    public NodoArbol(string nombre)
    {
        Nombre = nombre;
    }

    public void InsertarHijo(string nombreHijo, bool esHijoIzquierdo)
    {
        if(esHijoIzquierdo)
        {
            HijoIzquierdo = new NodoArbol(nombreHijo);
        }
        else
        {
            HijoDerecho = new NodoArbol(nombreHijo);
        }
    }
}


//Clase para contruir Árbol
public class ArbolBinario
{
    public NodoArbol Raiz { get; private set; }
    public ArbolBinario(string nombreRaiz)
    {
        Raiz = new NodoArbol(nombreRaiz);
    }

    public void ImprimirArbol(NodoArbol nodo, string prefijo = "", bool esUltimo = true)
    {
        if(nodo == null) return;

        Console.Write(prefijo);
        Console.Write(esUltimo ? "+--" : "|--"); 
        Console.WriteLine(nodo.Nombre);

        string nuevoPrefijo = prefijo + (esUltimo ? "     " : "│    ");

        if(nodo.HijoIzquierdo != null || nodo.HijoDerecho != null)
        {
            ImprimirArbol(nodo.HijoIzquierdo, nuevoPrefijo, nodo.HijoDerecho == null);
            ImprimirArbol(nodo.HijoDerecho, nuevoPrefijo, true);
        }
    }

    public void RecorrerPreorden(NodoArbol nodo, bool esPrimer = true)
    {
        if(nodo == null) return;
        
        if(esPrimer)
        {
            Console.WriteLine("--");
        }
        Console.WriteLine(nodo.Nombre);

        RecorrerPreorden(nodo.HijoIzquierdo, false);
        RecorrerPreorden(nodo.HijoDerecho, false);
    }

    public void RecorrerInorden(NodoArbol nodo, bool esPrimero = true)
    {
        if (nodo == null) return;

        RecorrerInorden(nodo.HijoIzquierdo, false);
        if (esPrimero)
        {
            Console.WriteLine("--");
        }
        Console.WriteLine(nodo.Nombre);

        RecorrerPreorden(nodo.HijoDerecho, false);
    }

    public void RecorrerPostorden(NodoArbol nodo, bool esPrimero = true)
    {
        if (nodo == null) return;

        RecorrerPostorden(nodo.HijoIzquierdo, false);
        RecorrerPostorden(nodo.HijoDerecho, false);
        if (esPrimero)
        {
            Console.WriteLine("--");
        }
        Console.WriteLine(nodo.Nombre);
    }
}

