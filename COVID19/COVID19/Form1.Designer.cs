namespace COVID19
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBoxSexoPaciente = new System.Windows.Forms.ComboBox();
            this.comboBoxDistrito = new System.Windows.Forms.ComboBox();
            this.comboBoxEstadoPaciente = new System.Windows.Forms.ComboBox();
            this.buttonRegistrarPaciente = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxFechInterna = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxCelular = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxEdadPaciente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxMombrePaciente = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonRegMedico = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewPacientesCargoMedico = new System.Windows.Forms.DataGridView();
            this.textBoxNumeroColegiatura = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxFechaInternamiento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNumeroCelular = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEdadM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNombreCompletoM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDNIM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewPacientes = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridViewMedicos = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientesCargoMedico)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientes)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(579, 373);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBoxSexoPaciente);
            this.tabPage2.Controls.Add(this.comboBoxDistrito);
            this.tabPage2.Controls.Add(this.comboBoxEstadoPaciente);
            this.tabPage2.Controls.Add(this.buttonRegistrarPaciente);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.textBoxFechInterna);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.textBoxCelular);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.textBoxEdadPaciente);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.textBoxMombrePaciente);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.textBoxDNI);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(571, 347);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registrar Medico";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBoxSexoPaciente
            // 
            this.comboBoxSexoPaciente.FormattingEnabled = true;
            this.comboBoxSexoPaciente.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBoxSexoPaciente.Location = new System.Drawing.Point(158, 164);
            this.comboBoxSexoPaciente.Name = "comboBoxSexoPaciente";
            this.comboBoxSexoPaciente.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSexoPaciente.TabIndex = 36;
            // 
            // comboBoxDistrito
            // 
            this.comboBoxDistrito.FormattingEnabled = true;
            this.comboBoxDistrito.Items.AddRange(new object[] {
            "Comas",
            "La Victoria",
            "Brenia",
            "Callao",
            "Lurin"});
            this.comboBoxDistrito.Location = new System.Drawing.Point(402, 108);
            this.comboBoxDistrito.Name = "comboBoxDistrito";
            this.comboBoxDistrito.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDistrito.TabIndex = 35;
            // 
            // comboBoxEstadoPaciente
            // 
            this.comboBoxEstadoPaciente.FormattingEnabled = true;
            this.comboBoxEstadoPaciente.Items.AddRange(new object[] {
            "INTERNADA",
            "EN UCI",
            "FALLECIDA",
            "RECUPERADA"});
            this.comboBoxEstadoPaciente.Location = new System.Drawing.Point(402, 161);
            this.comboBoxEstadoPaciente.Name = "comboBoxEstadoPaciente";
            this.comboBoxEstadoPaciente.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEstadoPaciente.TabIndex = 34;
            // 
            // buttonRegistrarPaciente
            // 
            this.buttonRegistrarPaciente.Location = new System.Drawing.Point(221, 221);
            this.buttonRegistrarPaciente.Name = "buttonRegistrarPaciente";
            this.buttonRegistrarPaciente.Size = new System.Drawing.Size(136, 42);
            this.buttonRegistrarPaciente.TabIndex = 33;
            this.buttonRegistrarPaciente.Text = "Registrar Paciente";
            this.buttonRegistrarPaciente.UseVisualStyleBackColor = true;
            this.buttonRegistrarPaciente.Click += new System.EventHandler(this.buttonRegistrarPaciente_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(292, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Estado";
            // 
            // textBoxFechInterna
            // 
            this.textBoxFechInterna.Location = new System.Drawing.Point(402, 135);
            this.textBoxFechInterna.Name = "textBoxFechInterna";
            this.textBoxFechInterna.Size = new System.Drawing.Size(121, 20);
            this.textBoxFechInterna.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(292, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Fecha Internamiento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(292, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Distrito";
            // 
            // textBoxCelular
            // 
            this.textBoxCelular.Location = new System.Drawing.Point(402, 83);
            this.textBoxCelular.Name = "textBoxCelular";
            this.textBoxCelular.Size = new System.Drawing.Size(121, 20);
            this.textBoxCelular.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(292, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Numero Celular";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(48, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Sexo";
            // 
            // textBoxEdadPaciente
            // 
            this.textBoxEdadPaciente.Location = new System.Drawing.Point(158, 135);
            this.textBoxEdadPaciente.Name = "textBoxEdadPaciente";
            this.textBoxEdadPaciente.Size = new System.Drawing.Size(121, 20);
            this.textBoxEdadPaciente.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(48, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Edad";
            // 
            // textBoxMombrePaciente
            // 
            this.textBoxMombrePaciente.Location = new System.Drawing.Point(158, 109);
            this.textBoxMombrePaciente.Name = "textBoxMombrePaciente";
            this.textBoxMombrePaciente.Size = new System.Drawing.Size(121, 20);
            this.textBoxMombrePaciente.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(48, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Nombre Completo";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(158, 83);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(121, 20);
            this.textBoxDNI.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(48, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "DNI";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonRegMedico);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dataGridViewPacientesCargoMedico);
            this.tabPage1.Controls.Add(this.textBoxNumeroColegiatura);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.comboBoxSexo);
            this.tabPage1.Controls.Add(this.comboBoxEstado);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.textBoxFechaInternamiento);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.textBoxNumeroCelular);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxEdadM);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxNombreCompletoM);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxDNIM);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(571, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registrar Paciente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonRegMedico
            // 
            this.buttonRegMedico.Location = new System.Drawing.Point(359, 295);
            this.buttonRegMedico.Name = "buttonRegMedico";
            this.buttonRegMedico.Size = new System.Drawing.Size(148, 23);
            this.buttonRegMedico.TabIndex = 24;
            this.buttonRegMedico.Text = "Registrar Medico";
            this.buttonRegMedico.UseVisualStyleBackColor = true;
            this.buttonRegMedico.Click += new System.EventHandler(this.buttonRegMedico_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Pacientes a Cargo del Medico";
            // 
            // dataGridViewPacientesCargoMedico
            // 
            this.dataGridViewPacientesCargoMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPacientesCargoMedico.Location = new System.Drawing.Point(313, 88);
            this.dataGridViewPacientesCargoMedico.Name = "dataGridViewPacientesCargoMedico";
            this.dataGridViewPacientesCargoMedico.Size = new System.Drawing.Size(240, 181);
            this.dataGridViewPacientesCargoMedico.TabIndex = 22;
            // 
            // textBoxNumeroColegiatura
            // 
            this.textBoxNumeroColegiatura.Location = new System.Drawing.Point(152, 120);
            this.textBoxNumeroColegiatura.Name = "textBoxNumeroColegiatura";
            this.textBoxNumeroColegiatura.Size = new System.Drawing.Size(121, 20);
            this.textBoxNumeroColegiatura.TabIndex = 21;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(42, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "Numero Colegiatura";
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBoxSexo.Location = new System.Drawing.Point(152, 170);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSexo.TabIndex = 19;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "INTERNADA",
            "EN UCI",
            "FALLECIDA",
            "RECUPERADA"});
            this.comboBoxEstado.Location = new System.Drawing.Point(152, 248);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEstado.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Estado";
            // 
            // textBoxFechaInternamiento
            // 
            this.textBoxFechaInternamiento.Location = new System.Drawing.Point(152, 222);
            this.textBoxFechaInternamiento.Name = "textBoxFechaInternamiento";
            this.textBoxFechaInternamiento.Size = new System.Drawing.Size(121, 20);
            this.textBoxFechaInternamiento.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fecha Internamiento";
            // 
            // textBoxNumeroCelular
            // 
            this.textBoxNumeroCelular.Location = new System.Drawing.Point(152, 196);
            this.textBoxNumeroCelular.Name = "textBoxNumeroCelular";
            this.textBoxNumeroCelular.Size = new System.Drawing.Size(121, 20);
            this.textBoxNumeroCelular.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Especialidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sexo";
            // 
            // textBoxEdadM
            // 
            this.textBoxEdadM.Location = new System.Drawing.Point(152, 144);
            this.textBoxEdadM.Name = "textBoxEdadM";
            this.textBoxEdadM.Size = new System.Drawing.Size(121, 20);
            this.textBoxEdadM.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Edad";
            // 
            // textBoxNombreCompletoM
            // 
            this.textBoxNombreCompletoM.Location = new System.Drawing.Point(152, 91);
            this.textBoxNombreCompletoM.Name = "textBoxNombreCompletoM";
            this.textBoxNombreCompletoM.Size = new System.Drawing.Size(121, 20);
            this.textBoxNombreCompletoM.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Completo";
            // 
            // textBoxDNIM
            // 
            this.textBoxDNIM.Location = new System.Drawing.Point(152, 65);
            this.textBoxDNIM.Name = "textBoxDNIM";
            this.textBoxDNIM.Size = new System.Drawing.Size(121, 20);
            this.textBoxDNIM.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.dataGridViewPacientes);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(571, 347);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Listar Pacientes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPacientes
            // 
            this.dataGridViewPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPacientes.Location = new System.Drawing.Point(5, 95);
            this.dataGridViewPacientes.Name = "dataGridViewPacientes";
            this.dataGridViewPacientes.Size = new System.Drawing.Size(560, 246);
            this.dataGridViewPacientes.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridViewMedicos);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(571, 347);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Listar Medicos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMedicos
            // 
            this.dataGridViewMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedicos.Location = new System.Drawing.Point(14, 88);
            this.dataGridViewMedicos.Name = "dataGridViewMedicos";
            this.dataGridViewMedicos.Size = new System.Drawing.Size(551, 253);
            this.dataGridViewMedicos.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 377);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientesCargoMedico)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientes)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxFechaInternamiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNumeroCelular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEdadM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNombreCompletoM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDNIM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewPacientes;
        private System.Windows.Forms.ComboBox comboBoxSexo;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.ComboBox comboBoxSexoPaciente;
        private System.Windows.Forms.ComboBox comboBoxDistrito;
        private System.Windows.Forms.ComboBox comboBoxEstadoPaciente;
        private System.Windows.Forms.Button buttonRegistrarPaciente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxFechInterna;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxCelular;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxEdadPaciente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxMombrePaciente;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxNumeroColegiatura;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewPacientesCargoMedico;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridViewMedicos;
        private System.Windows.Forms.Button buttonRegMedico;
    }
}

