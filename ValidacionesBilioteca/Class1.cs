namespace ValidacionesBilioteca
{
    public static class Validaciones
    {
        public static bool EsAnioValido(int anio)
        {
            return anio > 0 && anio <= DateTime.Now.Year;
        }

        public static bool EsTituloValido(string titulo)
        {
            return !string.IsNullOrWhiteSpace(titulo);
        }
    }
}
