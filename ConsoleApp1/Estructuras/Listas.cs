//Listas 
//Son dinamicas
List<int> numeros = new List<int>();
List<string> palabras = new List<string> { "Hola", "Mundo" };

//Agregar elementos
numeros.Add(10);
numeros.AddRange(new int[] { 30, 40, 50 });

//Acceso indice
int primerNumero = numeros[0];
Console.WriteLine("Primer numero: " + primerNumero);

//Insertar
numeros.Insert(1, 20);
Console.WriteLine(numeros[1]);
Console.WriteLine(numeros[2]);

//Eliminar
numeros.Remove(20); //Elimina la primera ocurrencia del valor 20
numeros.RemoveAt(3); //Elimina el elemento en el indice 3

//Buscar
bool existe = numeros.Contains(30); //True si el elemento existe
int indice = numeros.IndexOf(40); //Indice del primer elemento con valor 40
int mayor25 = numeros.Find(x => x > 25); //Primer elemento mayor a 25

List<int> mayores = numeros.FindAll(x => x > 25); //Todos los elementos mayores a 25


