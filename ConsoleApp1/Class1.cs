public class CalculadoraCientifica : Calculadora
{
    //Atributos
    //Constructor
    public CalculadoraCientifica(double numero1, double numero2) : base(numero1, numero2)
    {

    }
 

    public override double Sumar()
    {
        double suma = base.Sumar();
        Console.WriteLine($"Suma: {suma*2}");
        return suma;
    }

 
    //Metodos
    public int Factorial()
    {
        int f = 1;
        if (Numero1 < 0)
        {
            Console.WriteLine("No se puede calcular");
            return 0;
        }
 
        for(int i = 1; i<= Numero1; i++)
        {
            f = f * i;
        }
        return f;
    }


        for (int i = 1; i <= Numero1; i++)
        {
            f = f * i;
        }
        Console.WriteLine($"Factorial: {f}");
        return f;
    }
 
    public double RaizCuadrada()
    {
        if (Numero1 < 0)
        {
 
            Console.WriteLine("No se puede calcular la raiz cuadrada de un numero negativa");

            Console.WriteLine("No se puede calcular");
 
            return 0;
        }
        else
        {
 
            return Math.Sqrt(Numero1);
        }
    }

    public double Logaritmo()
    {
        if (Numero1 == 0)
        {
            Console.WriteLine("No se puede calcular el logaritmo de cero");
            return 0;
        }
        else if (Numero1 < 0)
        {
            Console.WriteLine("No se puede calcular el logaritmo de un numero negativo");
            return 0;
        }
        else
        {
            return Math.Log(Numero1);
        }
            
    }
    public void MensajeCalculadoraCientifica()
    {
        Console.WriteLine("Mensaje desde la calculadora cientifica");
    }
    public void MensajeCalculadora()
    {
        Console.WriteLine(MostrarMensaje());

            double resultado = Math.Sqrt(Numero1);
            Console.WriteLine($"Raiz Cuadrada: {resultado}");
            return resultado;
        }

    }
    public void Potencia()
    {
        double resultado = Math.Pow(Numero1, Numero2);
        Console.WriteLine($"Potencia: {resultado}");
    }
    public void Logartimo()
    {
        if (Numero1 <= 0)
        {
            Console.WriteLine("No se puede calcular");
        }
        else
        {
            double resultado = Math.Log10(Numero1);
            Console.WriteLine($"Logartimo: {resultado}");
        }
 
    }
}