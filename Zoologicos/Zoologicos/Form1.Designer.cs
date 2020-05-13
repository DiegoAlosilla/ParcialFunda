namespace Zoologicos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabRegistarZoologico = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.textBoxPresupuesto = new System.Windows.Forms.TextBox();
            this.textBoxTamanio = new System.Windows.Forms.TextBox();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.textBoxPais = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxIdentificador = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.textBoxPaisFiltro = new System.Windows.Forms.TextBox();
            this.dataGridViewZoologico = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxVulgar = new System.Windows.Forms.TextBox();
            this.textBoxCientifico = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxClase = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonSi = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.dataGridViewNombreZoologicos = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabRegistarZoologico.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZoologico)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNombreZoologicos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabRegistarZoologico
            // 
            this.tabRegistarZoologico.Controls.Add(this.tabPage1);
            this.tabRegistarZoologico.Controls.Add(this.tabPage2);
            this.tabRegistarZoologico.Controls.Add(this.tabPage3);
            this.tabRegistarZoologico.Location = new System.Drawing.Point(1, 1);
            this.tabRegistarZoologico.Name = "tabRegistarZoologico";
            this.tabRegistarZoologico.SelectedIndex = 0;
            this.tabRegistarZoologico.Size = new System.Drawing.Size(678, 332);
            this.tabRegistarZoologico.TabIndex = 0;
            this.tabRegistarZoologico.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonRegistrar);
            this.tabPage1.Controls.Add(this.textBoxPresupuesto);
            this.tabPage1.Controls.Add(this.textBoxTamanio);
            this.tabPage1.Controls.Add(this.textBoxCiudad);
            this.tabPage1.Controls.Add(this.textBoxPais);
            this.tabPage1.Controls.Add(this.textBoxNombre);
            this.tabPage1.Controls.Add(this.textBoxIdentificador);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(670, 306);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registrar Zoologico";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(267, 120);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(97, 48);
            this.buttonRegistrar.TabIndex = 12;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // textBoxPresupuesto
            // 
            this.textBoxPresupuesto.Location = new System.Drawing.Point(467, 70);
            this.textBoxPresupuesto.Name = "textBoxPresupuesto";
            this.textBoxPresupuesto.Size = new System.Drawing.Size(100, 20);
            this.textBoxPresupuesto.TabIndex = 11;
            // 
            // textBoxTamanio
            // 
            this.textBoxTamanio.Location = new System.Drawing.Point(467, 44);
            this.textBoxTamanio.Name = "textBoxTamanio";
            this.textBoxTamanio.Size = new System.Drawing.Size(100, 20);
            this.textBoxTamanio.TabIndex = 10;
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(467, 19);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(100, 20);
            this.textBoxCiudad.TabIndex = 9;
            // 
            // textBoxPais
            // 
            this.textBoxPais.Location = new System.Drawing.Point(158, 67);
            this.textBoxPais.Name = "textBoxPais";
            this.textBoxPais.Size = new System.Drawing.Size(100, 20);
            this.textBoxPais.TabIndex = 8;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(158, 41);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 7;
            // 
            // textBoxIdentificador
            // 
            this.textBoxIdentificador.Location = new System.Drawing.Point(158, 16);
            this.textBoxIdentificador.Name = "textBoxIdentificador";
            this.textBoxIdentificador.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdentificador.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Presupuesto S/.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tamanio m2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ciudad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pais";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificador";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.dataGridViewNombreZoologicos);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.textBoxClase);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.textBoxCantidad);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.textBoxCientifico);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.textBoxVulgar);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(670, 306);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registrar Especie";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonConsultar);
            this.tabPage3.Controls.Add(this.Label7);
            this.tabPage3.Controls.Add(this.textBoxPaisFiltro);
            this.tabPage3.Controls.Add(this.dataGridViewZoologico);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(670, 306);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Listar Zoologicos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(543, 9);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(98, 47);
            this.buttonConsultar.TabIndex = 3;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(39, 26);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(27, 13);
            this.Label7.TabIndex = 2;
            this.Label7.Text = "Pais";
            // 
            // textBoxPaisFiltro
            // 
            this.textBoxPaisFiltro.Location = new System.Drawing.Point(80, 23);
            this.textBoxPaisFiltro.Name = "textBoxPaisFiltro";
            this.textBoxPaisFiltro.Size = new System.Drawing.Size(100, 20);
            this.textBoxPaisFiltro.TabIndex = 1;
            // 
            // dataGridViewZoologico
            // 
            this.dataGridViewZoologico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZoologico.Location = new System.Drawing.Point(7, 85);
            this.dataGridViewZoologico.Name = "dataGridViewZoologico";
            this.dataGridViewZoologico.Size = new System.Drawing.Size(656, 212);
            this.dataGridViewZoologico.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nombre Vulgar";
            // 
            // textBoxVulgar
            // 
            this.textBoxVulgar.Location = new System.Drawing.Point(121, 18);
            this.textBoxVulgar.Name = "textBoxVulgar";
            this.textBoxVulgar.Size = new System.Drawing.Size(100, 20);
            this.textBoxVulgar.TabIndex = 1;
            // 
            // textBoxCientifico
            // 
            this.textBoxCientifico.Location = new System.Drawing.Point(121, 44);
            this.textBoxCientifico.Name = "textBoxCientifico";
            this.textBoxCientifico.Size = new System.Drawing.Size(100, 20);
            this.textBoxCientifico.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nombre Cientifico";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(121, 70);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(100, 20);
            this.textBoxCantidad.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Cantidad";
            // 
            // textBoxClase
            // 
            this.textBoxClase.Location = new System.Drawing.Point(121, 96);
            this.textBoxClase.Name = "textBoxClase";
            this.textBoxClase.Size = new System.Drawing.Size(100, 20);
            this.textBoxClase.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Clase";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonNo);
            this.groupBox1.Controls.Add(this.radioButtonSi);
            this.groupBox1.Location = new System.Drawing.Point(31, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 66);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extincion";
            // 
            // radioButtonSi
            // 
            this.radioButtonSi.AutoSize = true;
            this.radioButtonSi.Location = new System.Drawing.Point(27, 30);
            this.radioButtonSi.Name = "radioButtonSi";
            this.radioButtonSi.Size = new System.Drawing.Size(34, 17);
            this.radioButtonSi.TabIndex = 9;
            this.radioButtonSi.TabStop = true;
            this.radioButtonSi.Text = "Si";
            this.radioButtonSi.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(124, 30);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(39, 17);
            this.radioButtonNo.TabIndex = 10;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // dataGridViewNombreZoologicos
            // 
            this.dataGridViewNombreZoologicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNombreZoologicos.Location = new System.Drawing.Point(317, 44);
            this.dataGridViewNombreZoologicos.Name = "dataGridViewNombreZoologicos";
            this.dataGridViewNombreZoologicos.Size = new System.Drawing.Size(269, 144);
            this.dataGridViewNombreZoologicos.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(314, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Seleccionar Zoologicos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 62);
            this.button1.TabIndex = 11;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 332);
            this.Controls.Add(this.tabRegistarZoologico);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabRegistarZoologico.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZoologico)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNombreZoologicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabRegistarZoologico;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPresupuesto;
        private System.Windows.Forms.TextBox textBoxTamanio;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.TextBox textBoxPais;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxIdentificador;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewZoologico;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.TextBox textBoxPaisFiltro;
        private System.Windows.Forms.TextBox textBoxClase;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCientifico;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxVulgar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridViewNombreZoologicos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonSi;
    }
}

