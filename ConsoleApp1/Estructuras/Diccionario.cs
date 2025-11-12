//Diccionario <Tkey, Tvalue>
//Cada llave tiene un valor asociado
// No mantienen un orden específico
// No mantienen orden de inserción

//Creación 
Dictionary<string, int> edades = new Dictionary<string, int>();

//agregar elementos

edades.Add("Ana", 25);
edades.Add("Juan", 30);

edades["Maria"] = 28; //Otra forma de agregar

//Acceso
int edadAna = edades["Ana"];
Console.WriteLine($"Edad de Ana: {edadAna}");

//verificar existencia

if(edades.ContainsKey("Carlos"))
{
    Console.WriteLine("Ana está en el diccionario");
}

//intentar obtener valor
if(edades.TryGetValue("Juan", out int edadJuane)) //Si existe, asigna el valor a edadJuan
{
    Console.WriteLine($"Edad de Juan: {edadJuane}");
}
else
{
    Console.WriteLine("Pedro no está en el diccionario");
}


//Recorrer diccionario

foreach(KeyValuePair <string, int> kvp in edades)
{
    Console.WriteLine($"{kvp.Key} : { kvp.Value}");
}

//Solo llaves
foreach(string nombre in edades.Keys)
{
    Console.WriteLine($"Nombre: {nombre}");
}

//Solo valores
foreach(int edad in edades.Values)
{
    Console.WriteLine($"Edad: {edad}");
}

//Eliminar elemento
edades.Remove("Ana");
foreach (int edad in edades.Values)
{
    Console.WriteLine($"Edad: {edad}");
}


Dictionary<string, int[]> codigos = new Dictionary<string, int[]>();