public class Dispositivos
{
    // Atributos 
    private string nombre;
    private bool encendido;
    private int consumo;


    // Propiedades publicas con control
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public bool Encendido
    {
        get { return encendido; }
        private set { encendido = value; }
    }
    public int Consumo
    {
        get { return consumo; }
        private set
        {
            if (value < 0)
            {
                consumo = 0;
            }
            else
            {
                consumo = value;
            }
        }
    }


    // Constructor

    public Dispositivos(string nombre, int consumo)
    {
        this.nombre = nombre;
        this.consumo = consumo;
        this.encendido = false;   //Encendido y apagado
    }

    public void Encender()
    {
        if (encendido == true)
        {
            Console.WriteLine($"{encendido} está encendido.");
        }
        else if (encendido == false)
        {
            Console.WriteLine($"{nombre} está apagada.");
        }
        
    }
    public void AjustarConsumo (int nuevoConsumo)
    {
        if (encendido == false)
        {
            Console.WriteLine($"No se puede ajustar el consumo mientras {nombre} está apagado.");
            Consumo = 0;
        }
        else if (encendido == true)
        {
            if (nuevoConsumo < 0)
            {
                Console.WriteLine($"El consumo no puede ser negativo");
            }
            else if (nuevoConsumo > 2040)
            {
                Consumo = 2040;
                Console.WriteLine($"El consumo de {nombre} se ha ajustado a {consumo} W.");
            }
            else
            {
                Consumo = nuevoConsumo;
                Console.WriteLine($"El consumo de {nombre} se ha ajustado a {consumo} W.");
            }
        }
        
    }

    public void AjustarConsumo()
    {
        Console.WriteLine($"El consumo de {nombre} es de {consumo} W.");
    }

    public virtual void MostrarInfo()
    {
        Console.WriteLine($"Dispositivo: {nombre}, Encendido: {encendido}, Consumo: {consumo} W");
    }

    public static bool operator > (Dispositivos d1, Dispositivos d2)
    {
        return d1.consumo > d2.consumo;
    }
    public static bool operator < (Dispositivos d1, Dispositivos d2)
    {
        return d1.consumo < d2.consumo;
    }
    public static bool operator != (Dispositivos d1, Dispositivos d2)
    {
        return d1.consumo != d2.consumo;
    }
    public static bool operator == (Dispositivos d1, Dispositivos d2)
    {
        return d1.consumo == d2.consumo;
    }
}