using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID19
{
    public class Medico
    {
        public string DNI { get; set; }
        public string NombreCompleto { get; set; }
        public string NumeroColegiatura { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Especialidad { get; set; }
        public int FechaColegiatura { get; set; }
        public List<Paciente> Pacientes { get; set; }

        public Medico(string dNI, string nombreCompleto, string numeroColegiatura, int edad, string sexo, string especialidad, int fechaColegiatura, List<Paciente> pacientes)
        {
            DNI = dNI;
            NombreCompleto = nombreCompleto;
            NumeroColegiatura = numeroColegiatura;
            Edad = edad;
            Sexo = sexo;
            Especialidad = especialidad;
            FechaColegiatura = fechaColegiatura;
            Pacientes = pacientes;
        }
    }
}
