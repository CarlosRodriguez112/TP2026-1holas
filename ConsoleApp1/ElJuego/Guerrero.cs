public class Guerrero
{
    //Atributos 
    public string Nombre { get; set; }
    public int Vida { get; set; }
    public int Ataque { get; set; }

    //Constructor 
    public Guerrero(string nombre, int vida, int ataque)
    {
        Nombre = nombre;
        Vida = vida;
        Ataque = ataque;
    }
    //Metodos
    public virtual void Atacar(Guerrero enemigo)
    {
        int danio = Ataque + new Random().Next(-3, 5);
        enemigo.RecibirDanio(danio);
        Console.WriteLine($"{Nombre} ataca a {enemigo.Nombre} causando {danio} de daño.");
    }

    public virtual void RecibirDanio(int danio)
    {
        Vida = Math.Max(Vida - danio, 0);
    }

    public static Guerrero operator + (Guerrero g1, Guerrero g2)
    {
        Console.WriteLine($"{g1.Nombre} y {g2.Nombre} Se fusionan en un nuevo guerrero");
        return new Guerrero($"{g1.Nombre} + {g2.Nombre}", (g1.Vida + g2.Vida) / 2, (g1.Ataque + g2.Ataque) / 2);
    }

}
