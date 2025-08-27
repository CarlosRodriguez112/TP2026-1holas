// Arreglos 
// Inicializacion 

int [] numeros = new int [3] ;


// Asignar valres a elementos 

numeros[0] = 1;
numeros[1] = 2;
numeros[2] = 3;
/*
for (int i=0; i<=2; i++)
{
    Console.WriteLine(numeros[i]);
}
*/

foreach (int numero in numeros)
{
    Console.WriteLine(numero); 
}

if (numeros[1] == 2)
{
    Console.WriteLine("El valor es 2");
}

// Obtener la longitud del arreglo 
Console.WriteLine(numeros.Length);

//Definicion implicita

int[] numeros2 = new int[10] { 4, 5, 6, 7, 8, 9, 1, 2, 3, 11 };

char[] vocales = new char[] { 'a', 'e', 'i', 'o', 'u' };


foreach (char vocal in vocales)
{
    Console.WriteLine(vocal);
}

bool[] estados = new bool[3];
estados[0] = true;
estados[1] = false;
estados[2] = false;

if (!estados[0])
{
    Console.WriteLine("Aqui hay un false");
}




//Ordenamiento de menor a mayor
Console.WriteLine("Arreglo desordenado");
foreach (int numero2 in numeros2)
{
    Console.WriteLine(numero2);
}

Array.Sort(numeros2);
Console.WriteLine("Arreglo ordenado");
foreach (int numero2 in numeros2)
{
    Console.WriteLine(numero2);
}


Array.Reverse(numeros2);
Console.WriteLine("Arreglo ordenado de mayor a menor");
foreach (int numero2 in numeros2)
{
    Console.WriteLine(numero2);
}


//busqueda por valor

Console.WriteLine(Array.BinarySearch(numeros2, 7));