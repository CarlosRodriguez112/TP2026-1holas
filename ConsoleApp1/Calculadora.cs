public class Calculadora
{
    //Atributos
    public double Numero1 { get; set;}
    public double Numero2 { get; set; }
    //Constructor
    public Calculadora(double numero1, double numero2)
    {
        Numero1 = numero1;
        Numero2 = numero2;
    }
    //Metodos
    public void Sumar()
    {
        double resultado = Numero1 + Numero2;
        Console.WriteLine($"Suma: {resultado}");
    }
    public void Restar()
    {
        double resultado = Numero1 - Numero2;
        Console.WriteLine($"Resta: {resultado}");
    }
    public void Multiplicar()
    {
        double resultado = Numero1 * Numero2;
        Console.WriteLine($"Multiplicacion: {resultado}");
    }
    public void Dividir()
    {
        if (Numero2 ==0)
        {
            Console.WriteLine("Error: Division no posible");
        }
        else
        {
            double resultado = Numero2 / Numero1;
            Console.WriteLine($"Division: {resultado}");
        }
    }

}