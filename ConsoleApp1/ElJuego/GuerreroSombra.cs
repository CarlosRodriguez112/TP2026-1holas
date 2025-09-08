public class GuerreroSombra : Guerrero
{
    public GuerreroSombra(string nombre) : base(nombre, 110, 20)
    {

    }

    public override void Atacar(Guerrero enemigo)
    {
        Console.WriteLine($"{Nombre} (GuerreroSombra) usa las sombras a {enemigo.Nombre}!");
        base.Atacar(enemigo);
    }


    public override void RecibirDanio(int danio)
    {
        int probabilidad = new Random().Next(0, 100);
        if (probabilidad < 20)
        {
            Console.WriteLine($"{Nombre} (GuerreroSombra) evade el ataque!");
        }
        else
        {
            Console.WriteLine($"{Nombre} (GuerreroSombra) recibe {danio} de daño.");
            base.RecibirDanio(danio);
        }
            
    }
}