//Listas

//Crear una lista

List<int> numeros = new List<int>();
List<string> nombres = new List<string>();


//agregar elementos

numeros.Add(10);
numeros.Add(20);
numeros.Add(30);


//Acceder a elementos

int primerNumero = numeros[0];
Console.WriteLine("Primer numero: " + primerNumero);

numeros.Remove(10);
numeros.RemoveAt(1);

//Recorrer la lista

foreach (int numero in numeros)
{
    Console.WriteLine("Numero: " + numero);
}

