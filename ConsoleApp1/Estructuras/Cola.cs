//Cola (Queue)
//FIFO (First in, First out)
//Solo se puede acceder al primer elemento
//No permite la búsqueda

//Creación 
Queue<string> cola = new Queue<string>();

//Añadir elementos (Enqueue)
cola.Enqueue("Primero");
cola.Enqueue("Segundo");
cola.Enqueue("Tercero");

foreach (string s in cola)
{
    Console.WriteLine(s);
}

//Sacar elementos (Dequeue)

string primerElemento = cola.Dequeue(); //Devuelve el valor y elimina 
cola.Enqueue("Dequeue del primer elemento");
foreach (string s in cola)
{
    Console.WriteLine(s);
}



string frontal = cola.Peek(); // ve el elemento sin eliminar
cola.Enqueue("Peek del primer elemento");
foreach (string s in cola)
{
    Console.WriteLine(s);
}

//Verificacion si esta vacio
if(cola.Count() == 0)
{
    Console.WriteLine("Vacia");
}

cola.Clear();
if (cola.Count == 0)
{
    Console.WriteLine("Vacia");
}