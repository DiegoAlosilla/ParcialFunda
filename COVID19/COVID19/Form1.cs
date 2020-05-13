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


        }



        private void buttonRegitrarPaciente_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegMedico_Click(object sender, EventArgs e)
        {


            foreach (DataGridViewRow dgvRenglon in dataGridViewPacientesCargoMedico.Rows)
            {
                DataTable temp = new DataTable();
                if (dgvRenglon.Selected)
                {
                    gestora.pacientesMedicosLista.Rows.Add(
                   dgvRenglon.Cells[0].Value.ToString(),
                   dgvRenglon.Cells[1].Value.ToString(),
                   int.Parse(dgvRenglon.Cells[2].Value.ToString()),
                   dgvRenglon.Cells[3].Value.ToString(),
                   dgvRenglon.Cells[4].Value.ToString(),
                   dgvRenglon.Cells[5].Value.ToString(),
                   int.Parse(dgvRenglon.Cells[6].Value.ToString()),
                   dgvRenglon.Cells[7].Value.ToString(),
                   int.Parse(dgvRenglon.Cells[8].Value.ToString())
                   );                                                    


                }

            }


            gestora.RegistrarMedico(
                textBoxDNIM.Text,
                textBoxNombreCompletoM.Text,
                textBoxNumeroColegiatura.Text,
                int.Parse(textBoxEdadM.Text),
                comboBoxSexo.SelectedItem.ToString(),
                textBoxEspecialidad.Text,
                int.Parse(textBoxFechaCole.Text),
                gestora.pacientesMedicosLista
                );
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
                int.Parse(textBoxFechaCole.Text),
                comboBoxEstadoPaciente.SelectedItem.ToString(),
                int.Parse(textBoxFechaCole.Text)
                );

            dataGridViewPacientes.DataSource = gestora.pacientes;


            //dataGridViewPacientesCargoMedico.Columns[0].HeaderText = "DNI";
            //dataGridViewPacientesCargoMedico.Columns[0].DataPropertyName = "DNI";
            //dataGridViewPacientesCargoMedico.Columns[1].HeaderText = "NombreCompleto";
            //dataGridViewPacientesCargoMedico.Columns[1].DataPropertyName = "NombreCompleto";
            dataGridViewPacientesCargoMedico.DataSource = gestora.pacientesMedicos;
        }
    }
}
