using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Zoologicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public DataTable zoologicos;
        public Zoologico zoologico;


        public DataTable especies;
        public Especie especie;


        private void Form1_Load(object sender, EventArgs e)
        {

            zoologicos = new DataTable();
            zoologico = new Zoologico();

            zoologicos.Columns.Add("Id"); 
            zoologicos.Columns.Add("Nombre");
            zoologicos.Columns.Add("Pais");
            zoologicos.Columns.Add("Ciudad");
            zoologicos.Columns.Add("Tamanio");
            zoologicos.Columns.Add("Presupuesto");

            dataGridViewNombreZoologicos.AutoGenerateColumns = false;
            dataGridViewNombreZoologicos.ColumnCount = 2;


            especies = new DataTable();
            especie = new Especie();

            textBoxIdentificador.Text = zoologicos.Rows.Count.ToString();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            zoologico.Id = zoologicos.Rows.Count;
            zoologico.Nombre = textBoxNombre.Text;
            zoologico.Pais = textBoxPais.Text;
            zoologico.Ciudad = textBoxCiudad.Text;
            zoologico.Tamanio = double.Parse(textBoxTamanio.Text);
            zoologico.Presupuesto = float.Parse(textBoxPresupuesto.Text);

            zoologicos.Rows.Add(
                 zoologico.Id,
                 zoologico.Nombre,
                 zoologico.Pais,
                 zoologico.Ciudad,
                 zoologico.Tamanio,
                 zoologico.Presupuesto
            );

            zoologico = new Zoologico();

            Cargar_GrillaZoologico();

            textBoxIdentificador.Text = zoologicos.Rows.Count.ToString();

        }

        public void Cargar_GrillaZoologico()
        {
            dataGridViewZoologico.DataSource = zoologicos;

            dataGridViewNombreZoologicos.Columns[0].HeaderText = "Id";
            dataGridViewNombreZoologicos.Columns[0].DataPropertyName = "Id";
            dataGridViewNombreZoologicos.Columns[1].HeaderText = "Nombre";
            dataGridViewNombreZoologicos.Columns[1].DataPropertyName = "Nombre";
            dataGridViewNombreZoologicos.DataSource = zoologicos;
        }

        public void Cargar_GrillaZoologicoFiltro(string Pais)
        {
            //dataGridViewZoologico.Rows.Clear();
            zoologicos.DefaultView.RowFilter = $"Pais LIKE '{Pais}%'";
            dataGridViewZoologico.DataSource = zoologicos;
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            Cargar_GrillaZoologicoFiltro(textBoxPaisFiltro.Text);
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
