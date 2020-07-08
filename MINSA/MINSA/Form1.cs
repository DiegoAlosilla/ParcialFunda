using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace MINSA
{
    public partial class Form1 : Form
    {

        private HospitalNE hospitalNE;
        public Form1()
        {
            InitializeComponent();
            hospitalNE = new HospitalNE();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (var item in hospitalNE.listarHospitales())
            {
                listViewHospital.Items.Add(item.Nombre);
            }

            
        }
    }
}

