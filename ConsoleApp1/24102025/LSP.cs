//Principio

//Si una clase B es hija de la clase A, entonces B se debe 
//Un uperCasting debe ser posible, es decir, se debe poder
//intento de upercasting
Rectangulo rectangulo = new Cuadrado();

rectangulo.Ancho = 4;
rectangulo.Alto = 5;

Console.WriteLine($"Área del rectángulo: {rectangulo.CalcularArea()}");

//Usando las clases con LSP

Forma rectanguloLSP = new RectanguloLSP { Ancho = 4, Alto = 5 };
Forma cuadrado = new CuadradoLSP { Lado = 2 };

ImprimirArea(rectanguloLSP);
ImprimirArea(cuadrado); 


static void ImprimirArea(Forma forma)
{
    Console.WriteLine($"Área: {forma.CalcularArea()}");
}

//Clase rectangulo
public class Rectangulo
{
    public virtual int Ancho { get; set; }
    public virtual int Alto { get; set; }
    public int CalcularArea()
    {
        return Ancho * Alto;
    }

}
public class Cuadrado : Rectangulo
{
    public override int Ancho { set { base.Ancho = value; } }
    public override int Alto { set { base.Alto = value; } }
}

//Respetando el principio LSP

public abstract class Forma
{
    public abstract int CalcularArea();
}

public class RectanguloLSP : Forma
{
    public int Ancho { get; set; }
    public int Alto { get; set; }
    public override int CalcularArea()
    {
        return Ancho * Alto;
    }
}

public class CuadradoLSP : Forma
{
    public int Lado { get; set; }
    public override int CalcularArea()
    {
        return Lado * Lado;
    }
}