namespace MINSA
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
            this.tabPageHospital = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listViewHospital = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPageHospital.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageHospital);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 421);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageHospital
            // 
            this.tabPageHospital.Controls.Add(this.listViewHospital);
            this.tabPageHospital.Location = new System.Drawing.Point(4, 22);
            this.tabPageHospital.Name = "tabPageHospital";
            this.tabPageHospital.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHospital.Size = new System.Drawing.Size(576, 395);
            this.tabPageHospital.TabIndex = 0;
            this.tabPageHospital.Text = "Hospital";
            this.tabPageHospital.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(576, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2Medicos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listViewHospital
            // 
            this.listViewHospital.HideSelection = false;
            this.listViewHospital.Location = new System.Drawing.Point(56, 138);
            this.listViewHospital.Name = "listViewHospital";
            this.listViewHospital.Size = new System.Drawing.Size(398, 188);
            this.listViewHospital.TabIndex = 1;
            this.listViewHospital.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 420);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageHospital.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageHospital;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listViewHospital;
    }
}

