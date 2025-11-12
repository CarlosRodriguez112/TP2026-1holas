// Segregacion de interfaces
// Ninguna clase debe verse obligada a implementar interfaces que no utiliza

//Sin aplicar el principio ISP

Fantasma fantasma = new Fantasma();
//fantasma.LanzarHechizo();


//Aplicando el principio ISP
FantasmaISP fantasmaISP = new FantasmaISP();
fantasmaISP.Asustar();

BrujaISP brujaISP = new BrujaISP();
brujaISP.LanzarHechizo();
interface IMounstro
{
    void Asustar();
    void Volar();
    void LanzarHechizo();

}

public class Fantasma : IMounstro
{
    public void Asustar()
    {
        Console.WriteLine("Boo!");
    }
    public void Volar()
    {
        Console.WriteLine("El fantasma flota por el lugar.");
    }
    public void LanzarHechizo()
    {
        throw new NotImplementedException("Los fantasmas no lanzan hechizos.");
    }
}

//Aplicando el principio ISP


interface IAsustador
{
    void Asustar();
}
interface IVolador
{
    void Volar();
}
interface IHechicero
{
    void LanzarHechizo();
}

public class FantasmaISP : IAsustador, IVolador
{
    public void Asustar()
    {
        Console.WriteLine("Boo!");
    }
    public void Volar()
    {
        Console.WriteLine("El fantasma flota por el lugar.");
    }
}

public class BrujaISP : IAsustador, IVolador, IHechicero
{
    public void Asustar()
    {
        Console.WriteLine("Hehee!");
    }
    public void Volar()
    {
        Console.WriteLine("La bruja vuela con su escoba");
    }
    public void LanzarHechizo()
    {
        Console.WriteLine("La bruja lanzó un hechizo");
    }
}