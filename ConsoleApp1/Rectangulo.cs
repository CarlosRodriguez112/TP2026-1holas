

public class Rectangulo
{
    //Atributos (lados)

    public double Base { get; set; }
    public double Altura { get; set; }

    public Rectangulo(double baseee, double altura)
    {
        Base = baseee;
        Altura = altura;

    }
    /*Contructor (Valor de lados)
    double baseee = double.Parse(Console.ReadLine() ?? "");
    double altura = double.Parse(Console.ReadLine() ?? "");
    Metodos (Mostrar el perimetro, mostrar area)*/
    public virtual double Area()
    {
        return Base * Altura;
        /*Console.Write("Area:");
        Console.WriteLine(area);*/
    }
    public virtual double Perimetro()
    {
        return (2 * Base) + (2 * Altura);
        /*Console.Write("Perimetro:");
        Console.WriteLine(perimetro);*/
    }
}