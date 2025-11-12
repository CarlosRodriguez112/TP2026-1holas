//

public class CalculadoraPrestamos
{
    public decimal Calcular(Libro libro, string tipoPrestamo)
    {
        if (tipoPrestamo == "Regular")
        {
            return 10.0m;
        }
        else if (tipoPrestamo == "Extendido")
        {
            return 15.0m;
        }
        else if (tipoPrestamo == "Especial")
        {
            return 5.0m;
        }
        else
        {
            throw new ArgumentException("Tipo de préstamo no válido");
        }
    }
}
//Usando OCP
public interface IPrestamo
{
    decimal CalcularTarifa(LibroSRP libro);
}
public class PrestamoRegular : IPrestamo
{
    public decimal CalcularTarifa(LibroSRP libro)
    {
        return 10.0m;
    }
}
public class CalculadoraPrestamosOCP
{
    public decimal Calcular(LibroSRP libro, IPrestamo prestamo)
    {
        return prestamo.CalcularTarifa(libro);
    }
}