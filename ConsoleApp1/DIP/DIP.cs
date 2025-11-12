//Principio de inversion de dependencias (DIP)
//Los modelos de alto nivel no deben depender de los modelos de bajo nivel. Ambos deben depender de abstracciones.

//Sin aplicar DIP
public class Vampiro
{
    public void Asustar()
    {
        Console.WriteLine("Soy un vampiro!");
    }
}

public class OrganizadorFiesta()
{
    public Vampiro vampiro = new Vampiro(); //El organizador depende de la clase concreta Vampiro (Dependencia directa)

    public void IniciarFiesta()
    {
        Console.WriteLine("La fiesta ha comenzado!");
        vampiro.Asustar();
    }
}

//Aplicando DIP
public interface IAsustardorDIP
{
    void Asustar();
}
public class FantasmaDIP : IAsustardorDIP
{
    public void Asustar()
    {
        Console.WriteLine("Boo! Soy un fantasma!");
    }
}

public class VampiroDIP : IAsustardorDIP
{
    public void Asustar()
    {
        Console.WriteLine("Soy un vampiro!");
    }
}

public class OrganizadorFiestaDIP
{
    private readonly IAsustardorDIP asustador;
    public OrganizadorFiestaDIP(IAsustardorDIP asustador) //Dependencia a una abstracción
    {
        this.asustador = asustador;
    }
    public void IniciarFiesta()
    {
        Console.WriteLine("La fiesta ha comenzado!");
        asustador.Asustar();
    }
}