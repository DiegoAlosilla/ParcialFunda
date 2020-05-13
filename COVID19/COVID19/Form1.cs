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

            dataGridViewPacientes.DataSource = gestora.pacientes;
        }



    }
}
