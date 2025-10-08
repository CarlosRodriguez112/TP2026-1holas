namespace RobotLibrary
{
    public class robot
    {
        //Propiedades del robot
        public float Peso { get; set; }
        public string Modelo { get; set; }
        public bool Estado { get; set; }
        public int EnergiaDisponible { get; set; }
        //COnstructor con parametros
        public robot(float peso, string modelo, int energiaDisponible)
        {
            Peso = peso;
            Modelo = modelo;
            Estado = false;
            EnergiaDisponible = energiaDisponible;
        }
        //Metodos del robot
        public virtual void Encender()
        {
            if (!Estado && EnergiaDisponible > 0)
            {
                Estado = true;
                Console.WriteLine("El robot se ha encendido.");
            }
            else if (Estado)
            {
                Console.WriteLine("El robot ya está encendido.");
            }
            else
            {
                Console.WriteLine("No hay suficiente energía para encender el robot.");
            }
        }
        public virtual void Apagar()
        {
            if (Estado)
            {
                Estado = false;
                Console.WriteLine("El robot se ha apagado.");
            }
            else
            {
                Console.WriteLine("El robot ya está apagado.");
            }
        }
        public virtual int VerificarEnergia()
        {
            if (EnergiaDisponible <= 0)
            {
                Console.WriteLine("El robot no tiene energía disponible.");
                return 0;
            }
            else
            {
                Console.WriteLine($"El robot tiene: {EnergiaDisponible} %");
                return EnergiaDisponible;
            }
        }
        public virtual void RecargarEnergia(int cantidad)
        {

            if (cantidad <= 0)
            {
                Console.WriteLine("La cantidad debe ser mayor a 0.");
                return;
            }
            else if (EnergiaDisponible + cantidad > 100)
            {
                EnergiaDisponible = 100;
                Console.WriteLine($"El robot ha sido recargado. Energia disponible: {EnergiaDisponible} %");
            }
            else
            {
                EnergiaDisponible += cantidad;
                Console.WriteLine($"El robot ha sido recargado. Energia disponible: {EnergiaDisponible} %");
            }

        }
        public virtual void MostrarEstado()
        {
            Console.WriteLine($"El robot está: {(Estado ? "Encendido" : "Apagado")}.");
        }


        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Peso: {Peso} kg");
            Console.WriteLine($"Modelo: {Modelo}");
        }
    }



    public class robotMovil : robot
    {
        //Propiedades
        public float Velocidad { get; set; }
        public string Direccion { get; set; }
        public int MotorIzquierdo { get; set; }
        public int MotorDerecho { get; set; }
        public bool SensorUltrasonico { get; set; }
        //Constructor
        public robotMovil(float peso, string modelo, int energiaDisponible, float velocidad, string direccion)
            : base(peso, modelo, energiaDisponible)
        {
            Velocidad = 0;
            Direccion = direccion;
            MotorIzquierdo = 0;
            MotorDerecho = 0;
            SensorUltrasonico = false;
        }
        //Metodos heredados


        public override void Encender()
        {
            base.Encender();
            SensorUltrasonico = true;
            Console.WriteLine($"El robot movil esta encendido");
        }

        public override void Apagar()
        {
            base.Apagar();
            SensorUltrasonico = false;
            Console.WriteLine($"El robot movil esta apagado");
        }
        public override int VerificarEnergia()
        {
            int energia = base.VerificarEnergia();
            Console.WriteLine($"El robot movil tiene: {energia} % de energia disponible");
            return base.VerificarEnergia();
        }
        public override void RecargarEnergia(int cantidad)
        {
            base.RecargarEnergia(cantidad);
            Console.WriteLine($"El robot movil ha sido recargado con energia de: {EnergiaDisponible}");
        }
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Velocidad: {Velocidad} cm/s");
            Console.WriteLine($"Direccion: {Direccion}");
        }   

        public void ConsumirEnergia(int cantidad)
        {
            if (cantidad <= 0)
            {
                Console.WriteLine("La cantidad debe ser mayor a 0.");
                return;
            }
            else if (EnergiaDisponible - cantidad < 0)
            {
                EnergiaDisponible = 0;
                Console.WriteLine("El robot se ha quedado sin energía.");
                Apagar();
            }
            else
            {
                EnergiaDisponible -= cantidad;
                Console.WriteLine($"El robot ha consumido {cantidad} % de energía. Energia disponible: {EnergiaDisponible} %");
            }
        }

        public void Mover(float velocidad, string direccion)
        {
            Velocidad = velocidad;
            Direccion = direccion;
            Console.WriteLine($"El robot se está moviendo a {Velocidad} cm/s en dirección {Direccion}.");

        }

        public void Detener()
        {
            Velocidad = 0;
            Direccion = "Detenido";
            Console.WriteLine("El robot se ha detenido.");
        }
        public void GirarPordiferencia(string direccion)
        {
            if (direccion.ToLower() == "izquierda")
            {
                MotorDerecho = 0;
                MotorIzquierdo = 100;
            }
            else if (direccion.ToLower() == "derecha")
            {
                MotorDerecho = 100;
                MotorIzquierdo = 0;
            }
            else
            {
                Console.WriteLine("Direccion no valida. Use 'izquierda' o 'derecha'.");
                return;
            }
        }
        public void GirarPorContrarotacion(string direccion)
        {
            if (direccion.ToLower() == "izquierda")
            {
                MotorDerecho = 100;
                MotorIzquierdo = -100;
                Console.WriteLine("El robot esta girando a la izquierda por contrarotacion");
            }
            else if (direccion.ToLower() == "derecha")
            {
                MotorDerecho = -100;
                MotorIzquierdo = 100;
                Console.WriteLine("El robot esta girando a la derecha por contrarotacion");
            }
            else
            {
                Console.WriteLine("Direccion no valida. Use 'izquierda' o 'derecha'.");
                return;
            }
        }

        public void ObtenerDstanciaSensor()
        {
            Random random = new Random();
            int distancia = random.Next(1, 100); // Simula una distancia entre 1 y 100 cm
            Console.WriteLine($"La distancia medida por el sensor ultrasonico es: {distancia} cm.");
        }

        public void AumentarVelocidad(int incremento)
        {
            if (incremento <= 0)
            {
                Console.WriteLine("El incremento debe ser mayor a 0.");
                return;
            }
            Velocidad += incremento;
            Console.WriteLine($"La velocidad del robot ha aumentado a {Velocidad} cm/s.");
        }
        public void DisminuirVelocidad(int decremento)
        {
            if (decremento <= 0)
            {
                Console.WriteLine("El decremento debe ser mayor a 0.");
                return;
            }
            if (Velocidad - decremento < 0)
            {
                Velocidad = 0;
                Console.WriteLine("El robot ha detenido su movimiento.");
                return;
            }
            else
            {
                Velocidad -= decremento;
            }
            Console.WriteLine($"La velocidad del robot ha disminuido a {Velocidad} cm/s.");
        }
    }



}
