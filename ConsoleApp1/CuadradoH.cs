// Cuadrado hereda de rectangulo 
public class Cuadrado : Rectangulo
{
    //lado es tanto la base como la altura
    //Constructor propio para el cuadrado

    public Cuadrado(double lado) : base (lado, lado)
    {

    }

    //Metodos sobreescribir los heredaros de rectangulo
    public override double Area()
    {
        return Base * Base;
    }

    public override double Perimetro()
    {
        return 4 * Base;
    }
}