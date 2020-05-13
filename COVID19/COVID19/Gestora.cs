using System.Data;

namespace COVID19
{
    public class Gestora
    {


        public DataTable pacientes;
        public Paciente paciente;


        public DataTable medicos;
        public Medico medico;

        public Gestora()
        {
            pacientes = new DataTable();


            pacientes.Columns.Add("DNI");
            pacientes.Columns.Add("NombreCompleto");
            pacientes.Columns.Add("Edad");
            pacientes.Columns.Add("Sexo");
            pacientes.Columns.Add("NumeroCelular");
            pacientes.Columns.Add("Distrito");
            pacientes.Columns.Add("FechaInternamiento");
            pacientes.Columns.Add("Estado");
            pacientes.Columns.Add("UltimaModificacion");

            //dataGridViewNombreZoologicos.AutoGenerateColumns = false;
            //dataGridViewNombreZoologicos.ColumnCount = 2;


            medicos = new DataTable();
            //medico = new Medico();
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
        }
    }
}
