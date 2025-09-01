//Programa principal del banco

Banco banco = new Banco();


try
{
    Console.WriteLine("Ingresa tu numero de cuenta: ");
    string NumeroCuenta = Console.ReadLine() ?? "";

    CuentaBancaria cuentaOrigen = banco.BuscarCuenta(NumeroCuenta);


    // Depositar

    Console.WriteLine("Ingresa la cantidad a depositar: ");

    double num = double.Parse(Console.ReadLine() ?? "");
    cuentaOrigen.Depositar((decimal)num);

   
    // Transferir

    Console.WriteLine("Ingresa el numero de cuenta: ");
    string NumeroCuentaDestino = Console.ReadLine() ?? "";

    CuentaBancaria cuentaDestino = banco.BuscarCuenta(NumeroCuentaDestino);

    Console.WriteLine("Ingresa la cantidad a transferir: ");
    double NumeroTransferir = double.Parse(Console.ReadLine() ?? "");

    cuentaOrigen.Transferir(cuentaDestino, (decimal)NumeroTransferir);

    // Retirar
    Console.WriteLine("Ingresa la cantidad a retirar: ");
    double NumeroRetiro = double.Parse(Console.ReadLine() ?? "");

    cuentaDestino.Retirar((decimal)NumeroRetiro);
}

catch (SaldoInsuficienteException e)
{
    Console.WriteLine(e.Message);
}

catch (CuentaNoEncontradaException e)
{
    Console.WriteLine(e.Message);
}

catch (DepositoInvalidoException e)
{
    Console.WriteLine(e.Message);
}