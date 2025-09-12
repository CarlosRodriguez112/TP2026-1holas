//Programa principal

List<IPago> listaPagos = new List<IPago>();

Console.WriteLine("Ingresa el monto a pagar: ");
string montoTexto = Console.ReadLine() ?? "";
if (double.TryParse(montoTexto, out double monto))
{
    Console.WriteLine("El pago es con tarjeta? s/n");
    string opcion = Console.ReadLine() ?? "".ToLower();

    if (opcion == "s")
    {
        Console.WriteLine("Ingrese el numero de tarjeta: ");
        string numTarjeta = Console.ReadLine() ?? "";

        // Crear el objeto pago tarjeta
        // 
        IPago pago = new PagoTarjeta(numTarjeta, monto);
        listaPagos.Add(pago);
    }
    else
    {
        //Objeto pago en efectivo
        IPago pago = new PagoEfectivo(monto);
        listaPagos.Add(pago);
    }

    foreach (IPago p in listaPagos)
    {
        PagoTarjeta pagoTarjeta = p as PagoTarjeta;

        if (pagoTarjeta != null)
        {
            Console.WriteLine("Se pago con tarjeta");
            pagoTarjeta.ProcesarPago();
        }
        //TODO procesar los pagos con efectivo
    }
}
// TODO Hacer el pago iterativo hasta que ya no haya pagos que procesar
interface IPago
{
    //Metodo de mi interfaz

    public void ProcesarPago();

}

// Clases que implementan la interfaz IPago

//Clase para pagos en efectivo

public class PagoEfectivo : IPago
{
    // Atributo
    public double Monto { get; set; }

    //Constructor
    public PagoEfectivo(double monto)
    {
        Monto = monto;
    }

    //Metodo de la inetrfaz
    public void ProcesarPago()
    {
        Console.WriteLine($"Pago en efectivo de: {Monto} procesado");
    }
}


public class PagoTarjeta : IPago
{
    // Atributo
    public double Monto { get; set; }
    public string NumeroTarjeta { get; set; }

    //Constructor

    public PagoTarjeta(string numeroTarjeta, double monto)
    {
        NumeroTarjeta = numeroTarjeta;
        Monto = monto;
    }


    //Metodo de la interfaz
    public void ProcesarPago()
    {
        if(NumeroTarjeta.Length == 16)
        {
            Console.WriteLine($"Pago con tarjeta de: {Monto} procesado");
        }
        else
        {
            Console.WriteLine("Tarjeta invalida, no procesada");
        }
    }
}