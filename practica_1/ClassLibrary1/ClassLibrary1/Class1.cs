namespace RobotLibrarydospuntocero
{
    // Clase base
    public class Robot
    {
        // Atributos encapsulados
        public float Peso { get; set; }
        public string Modelo { get; set; }
        public bool Estado { get; set; }
        public int EnergiaDisponible { get; set; }

        // Constructor sin parámetros
        public Robot()
        {
            Modelo = "Robot Genérico";
            Peso = 5.0f;
            EnergiaDisponible = 100;
            Estado = false;
        }

        // Constructor con parámetros
        public Robot(string modelo, float peso, int energia, bool estado)
        {
            Modelo = modelo;
            Peso = peso;
            EnergiaDisponible = energia;
            Estado = estado;
        }

        // Métodos virtuales (para poder sobrescribir)
        public virtual void Encender()
        {
            Estado = true;
            Console.WriteLine($"{Modelo} encendido.");
        }

        public virtual void Apagar()
        {
            Estado = false;
            Console.WriteLine($"{Modelo} apagado.");
        }

        public virtual int VerificarEnergia()
        {
            Console.WriteLine($"Energía restante: {EnergiaDisponible}%");
            return EnergiaDisponible;
        }

        public virtual void RecargarEnergia(int cantidad)
        {
            EnergiaDisponible += cantidad;
            if (EnergiaDisponible > 100)
            {
                EnergiaDisponible = 100;
            }
            else if (EnergiaDisponible < 0)
            {
                EnergiaDisponible = 0;
            }
            Console.WriteLine($"{Modelo} recargado a {EnergiaDisponible}%");
        }

        public virtual void MostrarEstado()
        {
            string estado = Estado ? "Encendido" : "Apagado";
            Console.WriteLine($"Estado del robot: {estado}");
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Modelo: {Modelo} | Peso: {Peso} kg | Energía: {EnergiaDisponible}%");
        }
    }

    // Clase: RobotMovil
    public class RobotMovil : Robot
    {
        public float Velocidad { get; set; }
        public string Direccion { get; set; }
        public int MotorIzquierdo { get; set; }
        public int MotorDerecho { get; set; }
        public float SensorUltrasonico { get; set; }

        // Constructor
        public RobotMovil(string modelo, float peso, int energia, bool estado) : base(modelo, peso, energia, estado)
        {
            Velocidad = 0;
            Direccion = "detenido";
            SensorUltrasonico = 100; // valor inicial simulado
        }

        // Sobrescritura de métodos
        public override void Encender()
        {
            Estado = true;
            Console.WriteLine($"{Modelo} encendido.");
        }

        public override void Apagar()
        {
            Estado = false;
            Velocidad = 0;
            Direccion = "detenido";
            Console.WriteLine($"{Modelo} apagado.");
        }

        public override int VerificarEnergia()
        {
            Console.WriteLine($"Energía actual del robot móvil: {EnergiaDisponible}%");
            return EnergiaDisponible;
        }

        public override void RecargarEnergia(int cantidad)
        {
            base.RecargarEnergia(cantidad);
            Console.WriteLine($"{Modelo}: Recarga completada con éxito.");
        }

        public override void MostrarEstado()
        {
            string estado = Estado ? "Encendido" : "Apagado";
            Console.WriteLine($"Estado: {estado} | Velocidad: {Velocidad} cm/s | Dirección: {Direccion}");
        }

        // Métodos adicionales
        public void ConsumirEnergia(int cantidad)
        {
            EnergiaDisponible -= cantidad;
            if (EnergiaDisponible < 0)
            {
                EnergiaDisponible = 0;
            }
        }

        public void Mover(float velocidad, string direccion)
        {
            if (!Estado)
            {
                Console.WriteLine("El robot está apagado. No puede moverse.");
                return;
            }

            Velocidad = velocidad;
            Direccion = direccion;
            Console.WriteLine($"{Modelo} se mueve {direccion} a {Velocidad} cm/s.");
            ConsumirEnergia(5);
        }

        public void Detener()
        {
            Velocidad = 0;
            Direccion = "detenido";
            Console.WriteLine($"{Modelo} se ha detenido.");
        }

        public void GiroPorDiferencia(string direccion)
        {
            if (!Estado)
            {
                Console.WriteLine("El robot está apagado. No puede girar.");
                return;
            }

            Console.WriteLine($"{Modelo} realiza un giro por diferencia hacia la {direccion}.");
            ConsumirEnergia(3);
        }

        public void GiroPorContrarrotacion(string direccion)
        {
            if (direccion.ToLower() != "izquierda" && direccion.ToLower() != "derecha")
            {
                Console.WriteLine("Dirección inválida. Use 'izquierda' o 'derecha'.");
                return;
            }

            if (!Estado)
            {
                Console.WriteLine("El robot está apagado. No puede girar.");
                return;
            }

            if (direccion.ToLower() == "izquierda")
            {
                MotorIzquierdo = 50;
                MotorDerecho = -50;
            }
            else if (direccion.ToLower() == "derecha")
            {
                MotorIzquierdo = -50;
                MotorDerecho = 50;
            }
            Console.WriteLine($"{Modelo} realiza un giro por contrarrotación hacia la {direccion}.");
            ConsumirEnergia(4);
        }

        public void ObtenerDistanciaSensor()
        {
            Random random = new Random();
            int distancia = random.Next(10, 100);
            Console.WriteLine($"Distancia detectada por sensor ultrasonico: {distancia} cm.");
        }

        public void AumentarVelocidad(int incremento)
        {
            Velocidad += incremento;
            if (Velocidad > 100)
            {
                Velocidad = 100;
            }
            else if (Velocidad < 0)
            {
                Velocidad = 0;
            }
            Console.WriteLine($"Velocidad aumentada a {Velocidad} cm/s.");
            ConsumirEnergia(2);
        }

        public void ReducirVelocidad(int decremento)
        {
            Velocidad -= decremento;
            if (Velocidad < 0) Velocidad = 0;
            Console.WriteLine($"Velocidad reducida a {Velocidad} cm/s.");
            ConsumirEnergia(1);
        }
    }
}
