namespace ClinicaFrba.Cancelar_Atencion
{
    partial class FrmCancelarAtencion
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
            this.comboBoxTipoCancalacion = new System.Windows.Forms.ComboBox();
            this.textBoxDetalle = new System.Windows.Forms.TextBox();
            this.labelTipoCan = new System.Windows.Forms.Label();
            this.labelDetalle = new System.Windows.Forms.Label();
            this.buttonCancelaTurno = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxTipoCancalacion
            // 
            this.comboBoxTipoCancalacion.FormattingEnabled = true;
            this.comboBoxTipoCancalacion.Location = new System.Drawing.Point(201, 162);
            this.comboBoxTipoCancalacion.Name = "comboBoxTipoCancalacion";
            this.comboBoxTipoCancalacion.Size = new System.Drawing.Size(169, 21);
            this.comboBoxTipoCancalacion.TabIndex = 0;
            // 
            // textBoxDetalle
            // 
            this.textBoxDetalle.Location = new System.Drawing.Point(201, 198);
            this.textBoxDetalle.Name = "textBoxDetalle";
            this.textBoxDetalle.Size = new System.Drawing.Size(247, 20);
            this.textBoxDetalle.TabIndex = 1;
            // 
            // labelTipoCan
            // 
            this.labelTipoCan.AutoSize = true;
            this.labelTipoCan.Location = new System.Drawing.Point(89, 165);
            this.labelTipoCan.Name = "labelTipoCan";
            this.labelTipoCan.Size = new System.Drawing.Size(107, 13);
            this.labelTipoCan.TabIndex = 2;
            this.labelTipoCan.Text = "Tipo de cancelación:";
            // 
            // labelDetalle
            // 
            this.labelDetalle.AutoSize = true;
            this.labelDetalle.Location = new System.Drawing.Point(88, 205);
            this.labelDetalle.Name = "labelDetalle";
            this.labelDetalle.Size = new System.Drawing.Size(43, 13);
            this.labelDetalle.TabIndex = 3;
            this.labelDetalle.Text = "Detalle:";
            // 
            // buttonCancelaTurno
            // 
            this.buttonCancelaTurno.Location = new System.Drawing.Point(225, 257);
            this.buttonCancelaTurno.Name = "buttonCancelaTurno";
            this.buttonCancelaTurno.Size = new System.Drawing.Size(121, 23);
            this.buttonCancelaTurno.TabIndex = 4;
            this.buttonCancelaTurno.Text = "Cancelar Turno";
            this.buttonCancelaTurno.UseVisualStyleBackColor = true;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(360, 257);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(88, 23);
            this.buttonCerrar.TabIndex = 5;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            // 
            // FrmCancelarAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 302);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonCancelaTurno);
            this.Controls.Add(this.labelDetalle);
            this.Controls.Add(this.labelTipoCan);
            this.Controls.Add(this.textBoxDetalle);
            this.Controls.Add(this.comboBoxTipoCancalacion);
            this.Name = "FrmCancelarAtencion";
            this.Text = "CANCELAR ATENCIÓN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTipoCancalacion;
        private System.Windows.Forms.TextBox textBoxDetalle;
        private System.Windows.Forms.Label labelTipoCan;
        private System.Windows.Forms.Label labelDetalle;
        private System.Windows.Forms.Button buttonCancelaTurno;
        private System.Windows.Forms.Button buttonCerrar;
    }
}