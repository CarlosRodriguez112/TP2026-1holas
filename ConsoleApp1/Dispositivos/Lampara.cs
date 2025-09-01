public class Lampara : Dispositivos
{
    // Constructor
    public Lampara(string nombre, int consumo) : base(nombre, consumo)
    {

    }
    private int intensidad;

    public void LaClaseBase(string nombre, int consumo, int intensidad)
    {
        this.Nombre = nombre;
        this.AjustarConsumo(consumo);
        this.intensidad = intensidad;
    }

    public void AjustarIntensidad(int nuevaIntensidad)
    {
        if(Encendido == false)
        {
            Console.WriteLine("La lámpara está apagada. No se puede ajustar la intensidad.");
            return;
        }
        else if (Encendido == true)
        {
            if (nuevaIntensidad < 0)
            {
                nuevaIntensidad = 0;
            }
            else if (nuevaIntensidad > 2000)
            {
                intensidad = 2000;
                Console.WriteLine($"La intensidad de {Nombre} se ha ajustado a {intensidad} lm");
            }
            else
            {
                intensidad = nuevaIntensidad;
                Console.WriteLine($"La intensidad de {Nombre} se ha ajustado a {intensidad} lm");
            }
                
        }
            
    }
    public override void MostrarInfo()
    {
        Console.WriteLine($"Dispositivo: {Nombre}\n Consumo: {Consumo} W\n Intensidad: {intensidad} lm\n Estado: {(Encendido ? "Encendido" : "Apagado")}");
    }
}