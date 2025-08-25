public class Vehiculo
{

    //Atributos
    /*public string Marca { get; set; }
    public string Modelo { get; set; }
    public int VelocidadActual { get; set; } 
    */

    //Atributod pivados  -> No se modifiquen fuera de la clase

    protected string marca;
    protected string modelo;
    protected int velocidadActual;


    //Propiedades publicas con control


    public string Marca
    {
        get { return marca; }
        set { marca = value; }

    }
    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }
    public int VelocidadActual
    {
        get { return velocidadActual; }
        private set
        {
            if (velocidadActual < 0)
            {
                velocidadActual = 0;
            }
            else
            {
                velocidadActual = value;
            }
        }
    }

    // Constructor 

    public Vehiculo(string marca, string modelo)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.velocidadActual = 0;
    }


    // Metodos

    public void Acelerar(int incremento)
    {
        VelocidadActual += incremento;

    }
    //Sobrecarga del metodo sin parametros
    public void Acelerar()
    {
        VelocidadActual = velocidadActual + 10;

    }

    public void Frenar(int decremento)
    {
        VelocidadActual -= decremento;

    }
    public void Frenar()
    {
        VelocidadActual = velocidadActual - 10;

    }






    public virtual void MostrarInfo()
    {
        Console.WriteLine($"Vehiculo: {marca}, Marca: {modelo}, Velocidad Actual: {velocidadActual} km/h");
    }


    //Sobrecarga de operadores

    public static bool operator > (Vehiculo v1, Vehiculo v2)
        {
        return v1.VelocidadActual > v2.VelocidadActual;
        }

    public static bool operator < (Vehiculo v1, Vehiculo v2)
    {
        return v1.VelocidadActual < v2.VelocidadActual;
    }

    public static bool operator == (Vehiculo v1, Vehiculo v2)
    {
        return v1.VelocidadActual == v2.VelocidadActual;
    }

    public static bool operator != (Vehiculo v1, Vehiculo v2)
    {
        return v1.VelocidadActual != v2.VelocidadActual;
    }
}
