// Programa principal 
List<IDispositivoInteligente> dispotivos = new List<IDispositivoInteligente>
{
    new Lamparal(),
    new Ventiladord(),
    new Altavoz()
};

//Encender todos los dispositivos

Console.WriteLine("Encendiendo todos los dispositivos:");
foreach(var dispositivo in dispotivos)
{
    dispositivo.Encender();
    dispositivo.MostrarEstado();
}


//Interactuar con los dispositvos
Console.WriteLine("Ajustar configuraciones ...");
((Lamparal)dispotivos[0]).AjustarBrillo(80);
((Ventiladord)dispotivos[1]).AjustarVelocidad(30);
((Altavoz)dispotivos[2]).ReproducirMusica("Rich girl");

//Mostrar estado actual
Console.WriteLine("Estado actualizado...");
foreach (var dispositivo in dispotivos)
{
    dispositivo.MostrarEstado();
}
Console.WriteLine("");
//Apagar dispositivos
Console.WriteLine("Apagando todos los dispositivos:");
foreach (var dispositivo in dispotivos)
{
    dispositivo.Apagar();
    dispositivo.MostrarEstado();
}

Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("Encendiendo todos los dispositivos:");
foreach (var dispositivo in dispotivos)
{
    dispositivo.Encender();
    dispositivo.MostrarEstado();
}

Console.WriteLine("");
//Interfaz
interface IDispositivoInteligente
{
    void Encender();
    void Apagar();
    void MostrarEstado();
}
// Clases

public class Lamparal : IDispositivoInteligente
{
    // Atributos
    private bool encencidad = false;
    private int brillo = 50;

    //Metodos
    public void Encender()
    {
        encencidad = true;
        Console.WriteLine("La lampara esta encendida");
    }
    public void Apagar()
    {
        encencidad = false;
        Console.WriteLine("La lampara esta apagada");
        
    }
    public void MostrarEstado()
    {
        
        Console.WriteLine($"lampara - Estado: {(encencidad ? "Encendida" : "Apagada")}, Brillo: {brillo}");
    }
    public void AjustarBrillo(int nivel)
    {
        if (nivel < 0 || nivel > 100)
        {
            Console.WriteLine("El brillo debe estar entre 0 y 100");
            return;
        }
        brillo = nivel;
        Console.WriteLine($"El brillo se ajusto a {brillo}");
    }

}



public class Ventiladord : IDispositivoInteligente
{
    // Atributos
    private bool encencidad = false;
    private int velocidad = 1;

    //Metodos
    public void Encender()
    {
        encencidad = true;
        Console.WriteLine("El ventilador esta encendido");
    }
    public void Apagar()
    {
        encencidad = false;
        Console.WriteLine("El ventilador esta apagado");
    }
    public void MostrarEstado()
    {
        Console.WriteLine($"Ventilador - Estado: {(encencidad ? "Encendida" : "Apagada")}, Velocidad: {velocidad}");
    }
    public void AjustarVelocidad(int nivel)
    {
        velocidad = Math.Clamp(nivel, 0, 100);
        Console.WriteLine($"Velcidad ajustada: {velocidad}");
    }
}



public class Altavoz : IDispositivoInteligente
{
    // Atributos
    private bool encencidad = false;
    private string cancionActual = "Ninguna";

    //Metodos
    public void Encender()
    {
        encencidad = true;
        Console.WriteLine("El altavoz esta encendida");
    }
    public void Apagar()
    {
        encencidad = false;
        Console.WriteLine("El altavoz esta apagada");
        
    }
    public void MostrarEstado()
    {
        Console.WriteLine($"Altavoz - Estado: {(encencidad ? "Encendida" : "Apagada")}, Reproduciendo: {cancionActual}");
    }
    public void ReproducirMusica(string cancion)
    {
        cancionActual = cancion;
        Console.WriteLine($"{(encencidad ? $"Reproduciendo: {cancionActual}" : "Reproduciendo nada")}");
    }

}