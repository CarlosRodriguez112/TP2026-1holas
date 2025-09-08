public class Arquero : Guerrero
{
    public Arquero(string nombre) : base(nombre, 90, 15)
    {

    }

    public override void Atacar(Guerrero enemigo)
    {
        int probabilidad = new Random().Next(0,100);
        if (probabilidad < 30)
        {
            Console.WriteLine($"{Nombre} (Arquero) falla el disparo!");
        }
        else
        {
            Console.WriteLine($"{Nombre} (Arquero) Dispara una flecha a {enemigo.Nombre}!");
            base.Atacar(enemigo);
        }
        
    }
}