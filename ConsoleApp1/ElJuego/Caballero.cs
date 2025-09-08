public class Caballero : Guerrero
{
    public Caballero(string nombre) : base(nombre, 120, 15)
    {

    }

    public override void Atacar(Guerrero enemigo)
    {
        Console.WriteLine($"{Nombre} (Caballero) usa un golpe critico!");
        base.Atacar(enemigo);
    }
}