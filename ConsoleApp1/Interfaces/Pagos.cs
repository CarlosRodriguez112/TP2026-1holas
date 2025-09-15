//Programa principal

List<IPago> listaPagos = new List<IPago>();
double cantidadEfectivo = 1000;
double cantidadTarjeta = 2000;
bool irse = false;

Console.WriteLine($"Tienes ${cantidadEfectivo} en efectivo \ny tienes ${cantidadTarjeta} en la tarjeta");
while (cantidadEfectivo > 0 && cantidadTarjeta > 0 && irse != true)
{
    
    Console.WriteLine("Ingresa el monto a pagar: ");
    string montoTexto = Console.ReadLine() ?? "";
    if (double.TryParse(montoTexto, out double monto))
    {
        Console.WriteLine("El pago es con tarjeta? s/n");
        bool salir = false;
        while (salir != true)
        {
            string opcion = Console.ReadLine() ?? "".ToLower();
            if (opcion == "s")
            {
                Console.WriteLine("Ingrese el numero de tarjeta: ");
                string numTarjeta = Console.ReadLine() ?? "";
                cantidadTarjeta = cantidadTarjeta - monto;
                
                // Crear el objeto pago tarjeta
                // 
                IPago pago = new PagoTarjeta(numTarjeta, monto);
                listaPagos.Add(pago);
                salir = true;
            }
            else if (opcion == "n")
            {
                cantidadEfectivo = cantidadEfectivo - monto;
                //Objeto pago en efectivo
                IPago pago = new PagoEfectivo(monto);
                listaPagos.Add(pago);
                salir = true;
            }
            else
            {
                Console.WriteLine("Por favor, ingrese s para pago con tarjeta o n para pago en efectivo.");
            }
        }


        foreach (IPago p in listaPagos)
        {
            PagoTarjeta pagoTarjeta = p as PagoTarjeta;
            PagoEfectivo pagoEfectivo = p as PagoEfectivo;

            if (pagoTarjeta != null)
            {
                Console.WriteLine("Se pago con tarjeta");
                pagoTarjeta.ProcesarPago();
            }
            else
            {
                Console.WriteLine("Se pago con efectivo");
                pagoEfectivo.ProcesarPago();
            }
            //TODO procesar los pagos con efectivo
        }
        Console.WriteLine($"Tu cantidad actual es de ${cantidadEfectivo} en efectivo y ${cantidadTarjeta} en la tarjeta");
            Console.WriteLine("¿Quieres seguir pagando? s/n (u otra tecla)");
            bool aqui = false;
            while (aqui != true)
            {
                string bai = Console.ReadLine() ?? "".ToLower();
                if (bai == "s")
                {
                    aqui = true;
                }
                else
                {
                    aqui = true;
                    irse = true;
                }
            }
    }
    else
    {
        Console.WriteLine("La cantidad debe ser numerica");
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
        Console.WriteLine($"Pago en efectivo de: ${Monto} procesado");
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
            Console.WriteLine($"Pago con tarjeta de: ${Monto} procesado");
        }
        else
        {
            Console.WriteLine("Tarjeta invalida, no procesada");
        }
    }
}