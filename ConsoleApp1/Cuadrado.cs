

public class Cuadrado
{
    //Atributos (lados)

    public double Lado { get; set; }
    

    public Cuadrado(double lado1)
    {
        Lado = lado1;
        

    }
    /*Contructor (Valor de lados)
    double baseee = double.Parse(Console.ReadLine() ?? "");
    double altura = double.Parse(Console.ReadLine() ?? "");
    Metodos (Mostrar el perimetro, mostrar area)*/
    public virtual double Area()
    {
        return Lado * Lado;
        /*Console.Write("Area:");
        Console.WriteLine(area);*/
    }
    public virtual double Perimetro()
    {
        return 4 * Lado;
        /*Console.Write("Perimetro:");
        Console.WriteLine(perimetro);*/
    }
}