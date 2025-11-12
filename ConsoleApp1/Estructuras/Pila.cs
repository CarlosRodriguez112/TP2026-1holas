//Pilas
//Una pila es una estructura de datos que sigue el principio LIFO (Last In, First Out),
//Solo puedes acceder al elemento superior de la pila.
//No permite busquedas

//Crear
Stack<string> pila = new Stack<string>();

//Apilar (push)
pila.Push("Primero");
pila.Push("Segundo");
pila.Push("Tercero");

foreach (string s in pila)
{
    Console.WriteLine(s);
}
//Desapilar (PoP)
string ultima = pila.Pop();  //Devuelve el valor y elimina de la pila
Console.WriteLine("Pop del ultimo elemento");
foreach (string s in pila)
{
    Console.WriteLine(s);
}

string superior = pila.Peek(); //Ve el elemento sin eliminar

Console.WriteLine("Peek del ultimo elemento");
foreach (string s in pila)
{
    Console.WriteLine(s);
}
