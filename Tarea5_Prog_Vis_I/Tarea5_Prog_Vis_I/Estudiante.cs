using System.Collections.Generic;

namespace Tarea5_Prog_Vis_I
{
    public class Estudiante
    {
        public string Carnet { get; set; }
        public string Nombre { get; set; }
        public double Promedio { get; set; }
        public List<Asignatura> Asignaturas { get; set; } = new List<Asignatura>();
        public void calCProm()
        {
            if(Asignaturas.Count == 0)
            {
                Promedio = 0;
                return;
            }
            double suma = 0;
            foreach (var asignatura in Asignaturas)
            {
                suma += asignatura.Nota;
            }
            Promedio = suma/ Asignaturas.Count;
        }
    }

    public class Asignatura
    {
        public string Nombre { get; set; }
        public double Nota { get; set; }
        public Asignatura(string nombre, double nota)
        {
            Nombre = nombre;
            Nota = nota;
        }
    }
    public class Promedios
    {
        public Estudiante estudiante;
        public double prom;
        public Promedios(Estudiante est, double p)
        {
            estudiante = est;
            prom = p;
        }
    }
    public static class DatosCompartidos
    {
        //public static Estudiante EstudianteActual { get; set; }
        //public List<Estudiante> Estudiantes= new List<Estudiante>();
        public static List<Promedios> mejoresProm(List<Estudiante> estudiantes)
        {
            List<Promedios> promedios = new List<Promedios>();
            for (int i = 0; i < estudiantes.Count; i++)
            {
                estudiantes[i].calCProm();
                promedios.Add(new Promedios(estudiantes[i], estudiantes[i].Promedio));
            }
            promedios.Sort((x, y) => y.prom.CompareTo(x.prom));
            return promedios;
        }
        public static int existe(List<Estudiante> estudiantes, string carnet)
        {
            for (int i = 0; i < estudiantes.Count; i++)
            {
                if (estudiantes[i].Carnet == carnet)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}