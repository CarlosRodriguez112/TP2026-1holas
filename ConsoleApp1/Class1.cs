public class CalculadoraCientifica : Calculadora
{
    //Atributos
    //Constructor
    public CalculadoraCientifica(double numero1, double numero2) : base(numero1, numero2)
    {

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
}