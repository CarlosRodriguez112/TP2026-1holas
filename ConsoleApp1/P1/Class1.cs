using System;
using System.Collections.Generic;
using System.Linq;

namespace GestionProyectosSoftware
{
    // ======= CLASE BASE =======
    abstract class Programador
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Tecnologia { get; set; }
        public int ExitosIndividuales { get; set; }
        public int ExitosEquipo { get; set; }
        public string Equipo { get; set; }

        public Programador(string nombre, int edad, string tecnologia, string equipo = "")
        {
            Nombre = nombre;
            Edad = edad;
            Tecnologia = tecnologia;
            Equipo = equipo;
            ExitosIndividuales = 0;
            ExitosEquipo = 0;
        }

        public void RegistrarResultadoIndividual(string proyecto, int nivel)
        {
            if (nivel == 1)
                ExitosIndividuales++;
        }
        public void RegistrarResultadoIndividual(string proyecto, int nivel, string comentario)
        {
            if (nivel == 1)
                ExitosIndividuales++;
            if (!string.IsNullOrEmpty(comentario))
                Console.WriteLine($"[Comentario] {Nombre} - Proyecto: {proyecto}");

        }

        public void RegistrarResultadoEquipo(string proyecto, string resultado, string comentario = "")
        {
            if (resultado.ToUpper() == "EXITOSO")
                ExitosEquipo++;

            if (!string.IsNullOrEmpty(comentario))
                Console.WriteLine($"[Comentario Equipo] {Equipo} - Proyecto: {proyecto} -> {comentario}");
        }
    }

    // ======= CLASES HIJAS =======
    class ProgramadorIndividual : Programador
    {
        public ProgramadorIndividual(string nombre, int edad, string tecnologia)
            : base(nombre, edad, tecnologia, "") { }
    }

    class ProgramadorEquipo : Programador
    {
        public ProgramadorEquipo(string nombre, int edad, string tecnologia, string equipo)
            : base(nombre, edad, tecnologia, equipo) { }
    }

    // ======= CLASE PROYECTO =======
    class Proyecto
    {
        public string Nombre { get; set; }
        public string Tecnologia { get; set; }

        public Proyecto(string nombre, string tecnologia)
        {
            Nombre = nombre;
            Tecnologia = tecnologia;
        }
    }

    // ======= INTERFAZ ESTRATEGIA =======
    interface IEstrategiaEvaluacion
    {
        int ObtenerValor(Programador programador);
    }

    // ======= ESTRATEGIAS =======
    class EvaluacionPorExitosIndividuales : IEstrategiaEvaluacion
    {
        public int ObtenerValor(Programador p) => p.ExitosIndividuales;
    }

    class EvaluacionPorExitosEquipo : IEstrategiaEvaluacion
    {
        public int ObtenerValor(Programador p) => p.ExitosEquipo;
    }

    // ======= CLASE GESTION PROYECTOS =======
    class GestionProyectos
    {
        private List<Proyecto> proyectos = new List<Proyecto>();
        private List<Programador> programadores = new List<Programador>();
        private IEstrategiaEvaluacion estrategia;

        public GestionProyectos()
        {
            estrategia = new EvaluacionPorExitosIndividuales();
        }

        public void RegistrarProyecto(string nombre, string tecnologia)
        {
            proyectos.Add(new Proyecto(nombre, tecnologia));
        }

        public void RegistrarProgramador(Programador programador)
        {
            programadores.Add(programador);
        }

        public void RegistrarResultadoIndividual(string proyecto, string nombreProg, int nivel, string comentario = "")
        {
            var p = programadores.FirstOrDefault(x => x.Nombre == nombreProg);
            p?.RegistrarResultadoIndividual(proyecto, nivel, comentario);
        }

        public void RegistrarResultadoEquipo(string proyecto, string equipo, string resultado, string comentario = "")
        {
            var equipoProgs = programadores.Where(x => x.Equipo == equipo);
            foreach (var p in equipoProgs)
                p.RegistrarResultadoEquipo(proyecto, resultado, comentario);
        }

        public void CambiarCriterio(string criterio)
        {
            if (criterio.ToUpper() == "INDIVIDUAL")
                estrategia = new EvaluacionPorExitosIndividuales();
            else
                estrategia = new EvaluacionPorExitosEquipo();
        }

        public void MostrarMejorProgramador(string tecnologia)
        {
            var lista = programadores.Where(p => p.Tecnologia == tecnologia);
            if (!lista.Any())
            {
                Console.WriteLine($"No hay programadores en tecnología {tecnologia}");
                return;
            }

            var mejor = lista.OrderByDescending(p => estrategia.ObtenerValor(p)).First();
            Console.WriteLine($"Mejor programador en {tecnologia}: {mejor.Nombre} (Valor: {estrategia.ObtenerValor(mejor)})");
        }
    }

    // ======= PROGRAMA PRINCIPAL =======
    class Program
    {
        static void Main(string[] args)
        {
            GestionProyectos gestor = new GestionProyectos();
            int operaciones = int.Parse(Console.ReadLine());

            for (int i = 0; i < operaciones; i++)
            {
                string linea = Console.ReadLine();
                var partes = linea.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string comando = partes[0].ToUpper();

                switch (comando)
                {
                    case "PROYECTO":
                        gestor.RegistrarProyecto(partes[1], partes[2]);
                        break;

                    case "PROGRAMADOR":
                        if (partes.Length == 4)
                            gestor.RegistrarProgramador(new ProgramadorIndividual(partes[1], int.Parse(partes[2]), partes[3]));
                        else
                            gestor.RegistrarProgramador(new ProgramadorEquipo(partes[1], int.Parse(partes[2]), partes[3], partes[4]));
                        break;

                    case "RESULTADO":
                        if (int.TryParse(partes[3], out int nivel)) // individual
                        {
                            string comentario = partes.Length > 4 ? string.Join(' ', partes.Skip(4)) : "";
                            gestor.RegistrarResultadoIndividual(partes[1], partes[2], nivel, comentario);
                        }
                        else // equipo
                        {
                            string comentario = partes.Length > 4 ? string.Join(' ', partes.Skip(4)) : "";
                            gestor.RegistrarResultadoEquipo(partes[1], partes[2], partes[3], comentario);
                        }
                        break;

                    case "CRITERIO":
                        gestor.CambiarCriterio(partes[1]);
                        break;

                    case "MEJOR":
                        gestor.MostrarMejorProgramador(partes[1]);
                        break;
                }
            }
        }
    }
}
