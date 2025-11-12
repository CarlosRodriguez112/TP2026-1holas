//Tupla
// No son estructuras, son una forma de agrupar datos heterogéneos
// Tamaño fijo
// Inmutables, no se pueden cambiar sus valores después de la creación
// Limitados a 8 elementos, para más se usan tuplas anidadas

// Tupla sin nombres

(string, int) persona1 = ("Ana", 25);

//Tupla con nombres

(string nombre, int edad) persona2 = (nombre: "Juan", edad: 30);


//Acceso a elementos
Console.WriteLine(persona1.Item1);
Console.WriteLine(persona2.nombre);


//Devolver tupla (metodo)
static (int, int) Dividir(int dividendo, int divisor)
{
    return (dividendo/divisor, dividendo%divisor);
}

var resultado = Dividir(10, 3);
Console.WriteLine($"Cociente: {resultado.Item1}, Residuo: {resultado.Item2}");

