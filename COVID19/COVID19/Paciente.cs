namespace COVID19
{
    public class Paciente
    {
        public string DNI { get; set; }
        public string NombreCompleto { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string NumeroCelular { get; set; }
        public string Distrito { get; set; }
        public int FechaInternamiento { get; set; }
        public string Estado { get; set; }
        public int UltimaModificacion { get; set; }

        public Paciente(string dNI, string nombreCompleto, int edad, string sexo, string numeroCelular, string distrito, int fechaInternamiento, string estado, int ultimaModificacion)
        {
            DNI = dNI;
            NombreCompleto = nombreCompleto;
            Edad = edad;
            Sexo = sexo;
            NumeroCelular = numeroCelular;
            Distrito = distrito;
            FechaInternamiento = fechaInternamiento;
            Estado = estado;
            UltimaModificacion = ultimaModificacion;
        }
    }
}
