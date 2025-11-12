////Gestion de mascotas aplicando SOLID

//Programa Principal
using static MascotaSRP;

MascotaSRP mascota = new MascotaSRP("Lilo", "Perro", 8);

MascotaSRP mascota2 = new MascotaSRP("Miu", "Gato", 3);

MascotaSRP mascota3 = new MascotaSRP("ADFS", "Tortuga", 8);
List<IVacuna> mascotas = new List<IVacuna>();
ServicioCalculadoraVacunas servicio = new ServicioCalculadoraVacunas(mascotas);
RepositorioMascota repo = new RepositorioMascota();
repo.Guardar(mascota);
NotificacionMascota notificacion = new NotificacionMascota();
notificacion.EnviarNotificacion(mascota);

//Clases
public class MascotaSRP
{
    //Datos de las mascotas
    public string Nombre { get; set; }
    public string Tipo { get; set; }
    public int Edad { get; set; }

    public MascotaSRP(string nombre, string tipo, int edad)
    {
        Nombre = nombre;
        Tipo = tipo;
        Edad = edad;
    }
}
//Almacenamiento
public class RepositorioMascota()
{
    private static List<MascotaSRP> mascotas = new List<MascotaSRP>();
    //Método para validar los datos
    public void Guardar(MascotaSRP mascota)
    {
        mascotas.Add(mascota);
        Console.WriteLine($"Mascota {mascota.Nombre} guardada exitosamente.");
    }

}
public class MaascotaValidar(MascotaSRP mascota)
{
    public bool Validar()
    {
        if (string.IsNullOrEmpty(mascota.Nombre) || mascota.Edad >= 0)
        {
            return false;
        }
        return true;
    }
}
public class NotificacionMascota()
{
    public void EnviarNotificacion(MascotaSRP mascota)
    {
        Console.WriteLine($"Notificación: La mascota {mascota.Nombre} ha sido registrada.");
    }
}
public class InformeMascota()
{
    public void GenerarInforme(List<MascotaSRP> mascotas)
    {
        Console.WriteLine("Informe:");
        foreach (var mascota in mascotas)
        {
            Console.WriteLine($"{mascota.Nombre}, {mascota.Tipo},{mascota.Edad} años");
        }
    }
}
//Aplicando OCP
public interface IVacuna
{
    decimal CalculoCosto();
    bool Aplica(string tipoMascota);
}
public class PerroVacuna : IVacuna
{
    public bool Aplica(string tipoMascota)
    {
        return tipoMascota == "Perro";
    }
    public decimal CalculoCosto()
    {
        return 50.0m;
    }
}
public class GatoVacuna : IVacuna
{
    public bool Aplica(string tipoMascota)
    {
        return tipoMascota == "Gato";
    }
    public decimal CalculoCosto()
    {
        return 30.0m;
    }
}
public class TortugaVacuna : IVacuna
{
    public bool Aplica(string tipoMascota)
    {
        return tipoMascota == "Tortuga";
    }
    public decimal CalculoCosto()
    {
        return 20.0m;
    }
}
public class ServicioCalculadoraVacunas
{
    private List<IVacuna> _calculadora;
    public ServicioCalculadoraVacunas(List<IVacuna> calculadora)
    {
        _calculadora = calculadora;
    }
    public decimal CalcularCosto(string tipoMascota)
    {
        IVacuna calculo = null;
        foreach (var calc in _calculadora)
        {
            if (calc.Aplica(tipoMascota))
            {
                calculo = calc;
                break;
            }
        }
        if (calculo == null)
        {
            throw new ArgumentException("Tipo de mascota no válido");
        }
        return calculo.CalculoCosto();
    }
}


