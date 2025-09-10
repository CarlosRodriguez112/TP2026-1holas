// Programa principal de casteos

// Conversion implicita

int numero = 42;
double numDouble = numero;

Console.WriteLine(numDouble);

// Conversion explicita

double numDouble2 = 42.75;
int numEntero = (int)numDouble;

Console.WriteLine(numEntero);

//Con metodos

string texto = "123";
int numero3 = Convert.ToInt32(texto);

Console.WriteLine(numero3 + 1);

// Parse

string texto2 = "3.1416";
double numDouble3 = double.Parse(texto2);

Console.WriteLine(numDouble3);

// Try para evitar errores

string textos = "566";
int resultado;
bool exito = int.TryParse(textos, out resultado);

Console.WriteLine(exito);
Console.WriteLine(resultado);

// Casteo entre objetos y clases

Animal miAnimal = new Orangutan();
miAnimal.HacerSonido();
// miAnimal.SonidoOragutan();

//Down casting Padre -> Hijo
Orangutan miOragutan = (Orangutan)miAnimal;
miOragutan.SonidoOrangutan();

// Up casting

Animal otroAnimal = new Animal();
Orangutan otroOraguntan = (Orangutan)otroAnimal;

otroOraguntan.SonidoOrangutan();

// Conversion por tipos de referencia 

object obj = new Orangutan();
string cadena = obj as string;
Console.WriteLine(cadena);
public class Animal
{
    // Metodo
    public void HacerSonido()
    {
        Console.WriteLine("Sonido generado");
    }

}

public class Orangutan : Animal
{
    public void SonidoOrangutan()
    {
        Console.WriteLine("AH AH AH- AH AH AH");
    }
}