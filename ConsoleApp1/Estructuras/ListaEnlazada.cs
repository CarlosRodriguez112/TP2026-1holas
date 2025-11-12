//Lista enlazada
//Cada elemento tiene un valor y un puntero
// scanf("%i" ,&nombre);

/* List<T>(MemoriaContigua)[10][20][30][40][50]
    LinkedList <T> (enlazada)[10] -> [20] -> [30] -> [50] */

LinkedList<string> frutas = new LinkedList<string>();

//Agregar nodos
frutas.AddLast("Manzana");
frutas.AddLast("Fresa");
frutas.AddFirst("Platano");

//Recorrer mostrando conexiones

Console.WriteLine("Frutas en lista enlazada");
LinkedListNode<string> actual = frutas.First;

while (actual != null)
{
    string anterior = actual.Previous?.Value ?? "";
    string siguiente = actual.Next?.Value ?? "";

    Console.WriteLine($"[{anterior} <- {actual.Value} -> {siguiente}]");
    actual = actual.Next;
}


//Insertar elemento

LinkedListNode<string> nodoPlatano = frutas.Find("Platano");
frutas.AddBefore(nodoPlatano, "Sandia");
frutas.AddAfter(frutas.First, "Tuna");

//Eliminar un nodo
frutas.Remove("Manzana");
Console.WriteLine("Lista modificada");

LinkedListNode<string> actual2 = frutas.First;
while (actual2 != null)
{
    string anterior = actual2.Previous?.Value ?? "";
    string siguiente = actual2.Next?.Value ?? "";

    Console.WriteLine($"[{anterior} <- {actual2.Value} -> {siguiente}]");
    actual2 = actual2.Next;
}