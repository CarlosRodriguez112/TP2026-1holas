/*//Listas

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

*/


//Programa lista de Persona

List<int> numeros = new List<int>();
List<PersonaL> Lista = new List<PersonaL>();

Lista.Add(new PersonaL("Cesar", 18));
Lista.Add(new PersonaL("Julio", 50));
Lista.Add(new PersonaL("Antonio", 12));
Lista.Add(new PersonaL("Pedro", 15));
Lista.Add(new PersonaL("Luffy", 19));

foreach (PersonaL persona in Lista)
    if (persona.Edad >= 18)
    {
        persona.MostrarInfo();
    }
