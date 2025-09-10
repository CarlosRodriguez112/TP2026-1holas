// Herencia con interfaces
Pajaro miPajaro = new Pajaro();

miPajaro.HacerSonido();
interface IAnimal
{
    void HacerSonido();
}

interface IVolador
{
    void Volar();
}
public class Pajaro : Animal, IAnimal, IVolador
{
    public void HacerSonido()
    {
        Console.WriteLine("pio pio");
    }

    public void Volar()
    {
        Console.WriteLine("El pajaro vuela");
    }
}