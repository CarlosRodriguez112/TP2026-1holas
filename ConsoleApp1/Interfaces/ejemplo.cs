// Programa principal

IEjemplo algo = new EjemploClase();
algo.HacerAlgo();
algo.HacerAlgoMas();


EjemploClase otracosa = new EjemploClase();
otracosa.HacerAlgo();
otracosa.HacerAlgoMas();
//Interfaz
public interface IEjemplo
{
    //Metodo de contrato
    void HacerAlgo();

    //Metodo ya definido
    void HacerAlgoMas();
    
}

//Clase que implementa interfaz
public class EjemploClase : IEjemplo
{
    public void HacerAlgo()
    {
        Console.WriteLine("Haciendo algo...");
    }
    public void HacerAlgoMas()
    {
        Console.WriteLine("Algo más");
    }
}

