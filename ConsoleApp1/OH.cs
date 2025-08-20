//Programa estructurado 
/*Console.WriteLine("Hello, World!");

Console.WriteLine("Ingresa el nombre de la pesona");
string nombre = Console.ReadLine() ?? "";

Console.WriteLine("Ingresa la edad");
int edad = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Ingrese su pais");
String pais = Console.ReadLine() ?? "";

// Mostrar los datos 
Console.WriteLine("Los datos de la persona son: ");
Console.WriteLine($"Nombre: {nombre}");
Console.WriteLine($"Edad: {edad}");
Console.WriteLine($"Pais: {pais}");
Programa orientado a objetos
Crear objetos de tipo persona
Persona.Pais = "Tierra";
Persona unEnteAlien = new Persona("Alien", 580);
Ejecutar el metodo de persona
unEnteAlien.MostrarDatos();
unEnteAlien.MostrarPais();

Persona humano = new Persona("Juan", 20);
humano.MostrarDatos();
Persona.MostrarPais();
humano.MostrarPais();
unEnteAlien.MostrarPais();
*/



Rectangulo rectangulo = new Rectangulo(10, 10);
double area = rectangulo.Area();
Console.WriteLine($"Area del rectangulo:{area}");
rectangulo.Perimetro();


Cuadrado cuadrado = new Cuadrado(9.5f);
Console.WriteLine($"Base de cuadrado: {cuadrado.Base}");
Console.WriteLine($"Altura de cuadrado: {cuadrado.Altura}");
Console.WriteLine($"Area del cuadrado: {cuadrado.Area}");
Console.WriteLine($"Perimetro del cuadrado: {cuadrado.Perimetro}");