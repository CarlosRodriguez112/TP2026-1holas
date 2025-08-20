public class Calculadora
{
    //Atributos
    public double Numero1 { get; set; }
    public double Numero2 { get; set; }
    //Atributo privado
    private double Resultado;
    private string Mensaje = "Mensaje privado";

    //Constructor
    public Calculadora(double numero1, double numero2)
    {
        Numero1 = numero1;
        Numero2 = numero2;
    }
    //Metodos
    public virtual double Sumar()
    {
        Resultado = Numero1 + Numero2;
        Console.WriteLine($"Suma: {Resultado}");
        return Resultado;
    }
    //Sobrecarga de funcion sumar

    public double Sumar(double num3)
    {
        Resultado = Numero1 + Numero2 + num3;
        Console.WriteLine($"Suma: {Resultado}");
        return Resultado;
    }
    public double Sumar(double num3, double num4)
    {
        Resultado = Numero1 + Numero2 + num3 + num4;
        Console.WriteLine($"Suma: {Resultado}");
        return Resultado;
    }

    //Sobrecarga del operador +

    public static Calculadora operator + (Calculadora c1, Calculadora c2)
        {
        return new Calculadora(c1.Numero1 + c2.Numero1, c1.Numero2 + c2.Numero2); 
        }


    public void Restar()
    {
        Resultado = Numero1 - Numero2;
        Console.WriteLine($"Resta: {Resultado}");
    }
    public void Multiplicar()
    {
        Resultado = Numero1 * Numero2;
        Console.WriteLine($"Multiplicacion: {Resultado}");
    }
    public void Dividir()
    {
        if (Numero2 ==0)
        {
            Console.WriteLine("Error: Division no posible");
        }
        else
        {
            Resultado = Numero2 / Numero1;
            Console.WriteLine($"Division: {Resultado}");
        }
    }
    //Metodo privado
    protected String MostrarMensaje()
    {
        Console.WriteLine("Mensaje desde metodo privado");
        return Mensaje;
    }

    //Metodo para acceder a metodo protegido

    
}