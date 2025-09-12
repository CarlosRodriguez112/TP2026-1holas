//Programa principal de animales

Perro miPerro = new Perro();
miPerro.Respirar();
miPerro.HacerSonido();


public class Animal
{
    //Metodos del padre
    public void Respirar ()
    {
        Console.WriteLine("Respirando");
    }

    // Herencia con polimosfirmo
    public virtual void HacerSonido()
    {
        Console.WriteLine("El animal hace un sonido");
    }
}



// Clases hijas
public class Perro : Animal
{
    public override void HacerSonido()
    {
        
        Console.WriteLine("Guau Guau");
    }
}


public class Gato : Animal
{
    public override void HacerSonido()
    {
        base.HacerSonido();
        Console.WriteLine("Miau Miau");
    }
}