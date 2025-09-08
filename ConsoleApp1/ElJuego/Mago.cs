public class Mago : Guerrero
{
    public Mago(string nombre) : base(nombre, 80, 25)
    {

    }

    public override void Atacar(Guerrero enemigo)
    {
        Console.WriteLine($"{Nombre} (Mago) Lanza un hechizo d fuego {enemigo.Nombre}");
        base.Atacar(enemigo);
    }
}