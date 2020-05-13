using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace COVID19
{
    public class Gestora
    {


        public DataTable pacientes;
        public Paciente paciente;


        public DataTable medicos;
        public DataTable pacientesMedicos;
        public Medico medico;

        public List<Paciente> pacientesMedicosLista;



        public Gestora()
        {
            pacientes = new DataTable();
            pacientesMedicos = new DataTable();
            pacientesMedicosLista = new List<Paciente>();


            pacientes.Columns.Add("DNI");
            pacientes.Columns.Add("NombreCompleto");
            pacientes.Columns.Add("Edad");
            pacientes.Columns.Add("Sexo");
            pacientes.Columns.Add("NumeroCelular");
            pacientes.Columns.Add("Distrito");
            pacientes.Columns.Add("FechaInternamiento");
            pacientes.Columns.Add("Estado");
            pacientes.Columns.Add("UltimaModificacion");



            pacientesMedicos.Columns.Add("DNI");
            pacientesMedicos.Columns.Add("NombreCompleto");
            pacientesMedicos.Columns.Add("Edad");
            pacientesMedicos.Columns.Add("Sexo");
            pacientesMedicos.Columns.Add("NumeroCelular");
            pacientesMedicos.Columns.Add("Distrito");
            pacientesMedicos.Columns.Add("FechaInternamiento");
            pacientesMedicos.Columns.Add("Estado");
            pacientesMedicos.Columns.Add("UltimaModificacion");





            medicos = new DataTable();

            medicos.Columns.Add("DNI");
            medicos.Columns.Add("NombreCompleto");
            medicos.Columns.Add("NumeroColegiatura");
            medicos.Columns.Add("Edad");
            medicos.Columns.Add("Sexo");
            medicos.Columns.Add("Especialidad");
            medicos.Columns.Add("FechaColegiatura");
            medicos.Columns.Add("Cantidad Pacientes");


        }

        public void RegistrarPaciente(string dNI, string nombreCompleto, int edad, string sexo, string numeroCelular, string distrito, int fechaInternamiento, string estado, int ultimaModificacion)
        {

            paciente = new Paciente(dNI, nombreCompleto, edad, sexo, numeroCelular, distrito, fechaInternamiento, estado, ultimaModificacion);

            pacientes.Rows.Add(
                    paciente.DNI,
                    paciente.NombreCompleto,
                    paciente.Edad,
                    paciente.Sexo,
                    paciente.NumeroCelular,
                    paciente.Distrito,
                    paciente.FechaInternamiento,
                    paciente.Estado,
                    paciente.UltimaModificacion
               );

            pacientesMedicos.Rows.Add(
                    paciente.DNI,
                    paciente.NombreCompleto,
                    paciente.Edad,
                    paciente.Sexo,
                    paciente.NumeroCelular,
                    paciente.Distrito,
                    paciente.FechaInternamiento,
                    paciente.Estado,
                    paciente.UltimaModificacion
               );
        }



        public void RegistrarMedico(string dNI, string nombreCompleto, string numeroColegiatura, int edad, string sexo, string especialidad, int fechaColegiatura, DataTable _pacientes)
        {

            medico = new Medico(dNI, nombreCompleto, numeroColegiatura, edad, sexo, especialidad, fechaColegiatura, _pacientes);
                        
            medicos.Rows.Add(
                     medico.DNI, medico.NombreCompleto, medico.NumeroColegiatura, medico.Edad, medico.Sexo, medico.Especialidad, medico.FechaColegiatura, medico.Pacientes.Rows.Count()
               );
        }




    }
}
