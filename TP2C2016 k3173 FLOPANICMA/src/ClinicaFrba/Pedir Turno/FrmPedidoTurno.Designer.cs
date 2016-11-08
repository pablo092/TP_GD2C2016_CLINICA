namespace ClinicaFrba.Pedir_Turno
{
    partial class FrmPedidoTurno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxProf = new System.Windows.Forms.TextBox();
            this.labelProf = new System.Windows.Forms.Label();
            this.labelEsp = new System.Windows.Forms.Label();
            this.comboBoxEsp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFecDisp = new System.Windows.Forms.ComboBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonPedirTurno = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxProf
            // 
            this.textBoxProf.Location = new System.Drawing.Point(175, 28);
            this.textBoxProf.Name = "textBoxProf";
            this.textBoxProf.Size = new System.Drawing.Size(265, 20);
            this.textBoxProf.TabIndex = 0;
            // 
            // labelProf
            // 
            this.labelProf.AutoSize = true;
            this.labelProf.Location = new System.Drawing.Point(58, 35);
            this.labelProf.Name = "labelProf";
            this.labelProf.Size = new System.Drawing.Size(62, 13);
            this.labelProf.TabIndex = 1;
            this.labelProf.Text = "Profesional:";
            // 
            // labelEsp
            // 
            this.labelEsp.AutoSize = true;
            this.labelEsp.Location = new System.Drawing.Point(58, 68);
            this.labelEsp.Name = "labelEsp";
            this.labelEsp.Size = new System.Drawing.Size(70, 13);
            this.labelEsp.TabIndex = 2;
            this.labelEsp.Text = "Especialidad:";
            // 
            // comboBoxEsp
            // 
            this.comboBoxEsp.FormattingEnabled = true;
            this.comboBoxEsp.Location = new System.Drawing.Point(175, 58);
            this.comboBoxEsp.Name = "comboBoxEsp";
            this.comboBoxEsp.Size = new System.Drawing.Size(265, 21);
            this.comboBoxEsp.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fechas disponibles:";
            // 
            // comboBoxFecDisp
            // 
            this.comboBoxFecDisp.FormattingEnabled = true;
            this.comboBoxFecDisp.Location = new System.Drawing.Point(175, 125);
            this.comboBoxFecDisp.Name = "comboBoxFecDisp";
            this.comboBoxFecDisp.Size = new System.Drawing.Size(265, 21);
            this.comboBoxFecDisp.TabIndex = 6;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(345, 85);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(95, 23);
            this.buttonBuscar.TabIndex = 7;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonPedirTurno
            // 
            this.buttonPedirTurno.Location = new System.Drawing.Point(231, 187);
            this.buttonPedirTurno.Name = "buttonPedirTurno";
            this.buttonPedirTurno.Size = new System.Drawing.Size(112, 24);
            this.buttonPedirTurno.TabIndex = 8;
            this.buttonPedirTurno.Text = "Solicitar Turno";
            this.buttonPedirTurno.UseVisualStyleBackColor = true;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(356, 187);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(84, 24);
            this.buttonCerrar.TabIndex = 9;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            // 
            // FrmPedidoTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 223);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonPedirTurno);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.comboBoxFecDisp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEsp);
            this.Controls.Add(this.labelEsp);
            this.Controls.Add(this.labelProf);
            this.Controls.Add(this.textBoxProf);
            this.Name = "FrmPedidoTurno";
            this.Text = "PEDIDO TURNO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProf;
        private System.Windows.Forms.Label labelProf;
        private System.Windows.Forms.Label labelEsp;
        private System.Windows.Forms.ComboBox comboBoxEsp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFecDisp;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonPedirTurno;
        private System.Windows.Forms.Button buttonCerrar;
    }
}