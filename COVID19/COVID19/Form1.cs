using System;
using System.Data;
using System.Windows.Forms;

namespace COVID19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Gestora gestora;

        private void Form1_Load(object sender, EventArgs e)
        {
            gestora = new Gestora();

            dataGridViewPacientesCargoMedico.AutoGenerateColumns = false;
            dataGridViewPacientesCargoMedico.ColumnCount = 2;
        }



        private void buttonRegitrarPaciente_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegMedico_Click(object sender, EventArgs e)
        {
            
            dataGridViewMedicos.DataSource = gestora.medicos;
        }

        private void buttonRegistrarPaciente_Click(object sender, EventArgs e)
        {
            gestora.RegistrarPaciente
                (
                textBoxDNI.Text,
                textBoxMombrePaciente.Text,
                int.Parse(textBoxEdadPaciente.Text),
                comboBoxSexoPaciente.SelectedItem.ToString(),
                textBoxCelular.Text,
                comboBoxDistrito.SelectedItem.ToString(),
                int.Parse(textBoxFechaInternamiento.Text),
                comboBoxEstadoPaciente.SelectedItem.ToString(),
                int.Parse(textBoxFechaInternamiento.Text)
                );

            dataGridViewPacientes.DataSource = gestora.pacientes;


            dataGridViewPacientesCargoMedico.Columns[0].HeaderText = "DNI";
            dataGridViewPacientesCargoMedico.Columns[0].DataPropertyName = "DNI";
            dataGridViewPacientesCargoMedico.Columns[1].HeaderText = "NombreCompleto";
            dataGridViewPacientesCargoMedico.Columns[1].DataPropertyName = "NombreCompleto";
            dataGridViewPacientesCargoMedico.DataSource = gestora.pacientesMedicos;
        }
    }
}
