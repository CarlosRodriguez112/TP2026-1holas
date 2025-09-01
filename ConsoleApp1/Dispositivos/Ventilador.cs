public class Ventilador : Dispositivos
{
    // Constructor
    public Ventilador(string nombre, int consumo) : base(nombre, consumo)
    {

    }
    private int Velocidad;

    public void LaClaseBase(string nombre, int consumoL, int velocidad)
    {
        this.Nombre = nombre;
        this.AjustarConsumo(consumoL);
        this.Velocidad = velocidad;
    }

    public void AjustarVelocidad(int nuevaVelocidad)
    {
        if (Encendido == false)
        {
            Console.WriteLine("La lámpara está apagada. No se puede ajustar la intensidad.");
            return;
        }
        else if (Encendido == true)
        {
            if (nuevaVelocidad < 0)
            {
                nuevaVelocidad = 0;
            }
            else if (nuevaVelocidad > 500)
            {
                Velocidad = 500;
                Console.WriteLine($"La velocidad de {Nombre} se ha ajustado a {Velocidad} rad/s");
            }
            else
            {
                Velocidad = nuevaVelocidad;
                Console.WriteLine($"La velocidad de {Nombre} se ha ajustado a {Velocidad} rad/s");
            }
            
        }
        
    }
    public override void MostrarInfo()
    {
        Console.WriteLine($"Dispositivo: {Nombre}\n Consumo: {Consumo} W\n Velocidad: {Velocidad} rad/s\n Estado: {(Encendido ? "Encendido" : "Apagado")}");
    }
}