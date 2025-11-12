//Gestion de mascotas NO aplicando SOLID

//Programa Principal
MascotaManager mascota = new MascotaManager()
{
    Nombre = "Firulais",
    Tipo = "Perro",
    Edad = 8
};
mascota.Guardar();
mascota.EnviarNotificacion();
CalculadoraVacunas calculadora = new CalculadoraVacunas();
calculadora.CalculoCosto(mascota.Tipo);

//Clases
public class MascotaManager()
{
    //Datos de las mascotas
    public string Nombre { get; set; }
    public string Tipo { get; set; }
    public int Edad { get; set; }
    //Almacenamiento
    private static List<MascotaManager> mascotas = new List<MascotaManager>();
    //Método para validar los datos
    public bool Validar()
    {
        if (string.IsNullOrWhiteSpace(Nombre) || Edad < 0)
        {
            return false;
        }
        return true;
    }
    //Simulacion de almacenamiento en BD
    public void Guardar()
    {
        if (!Validar()) //El ! es negarlo
        {
            throw new InvalidOperationException("Datos inválidos");
        }
        mascotas.Add(this);
        Console.WriteLine($"Mascota {Nombre} guardada exitosamente.");
    }
    //Método para enviar notifiacion
    public void EnviarNotificacion()
    {
        Console.WriteLine($"Notificación: La mascota {Nombre} ha sido registrada.");
    }
    //Generar informe
    public void GenerarInforme()
    {
        Console.WriteLine("Informe:");
        foreach (var mascota in mascotas)
        {
            Console.WriteLine($"{mascota.Nombre}, {mascota.Tipo},{mascota.Edad} años");
        }
    }
}
//sin OCP
public class CalculadoraVacunas
{
    public decimal CalculoCosto(string tipoMascota)
    {
        switch (tipoMascota)
        {
            case "Perro":
                return 200.0m;
            case "Gato":
                return 180.0m;
            case "Tortuga":
                return 500.0m;
        }

    }
}