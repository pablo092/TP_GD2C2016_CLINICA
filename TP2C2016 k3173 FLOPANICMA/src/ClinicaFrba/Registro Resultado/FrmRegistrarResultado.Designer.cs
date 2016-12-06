namespace ClinicaFrba.Registro_Resultado
{
    partial class FrmRegistrarResultado
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
            this.label2 = new System.Windows.Forms.Label();
            this.TXTSINTOMAS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTDIAGNOSTICO = new System.Windows.Forms.TextBox();
            this.BTNACEPTAR = new System.Windows.Forms.Button();
            this.BTNCANCELAR = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sintomas";
            // 
            // TXTSINTOMAS
            // 
            this.TXTSINTOMAS.Location = new System.Drawing.Point(156, 93);
            this.TXTSINTOMAS.MaxLength = 255;
            this.TXTSINTOMAS.Multiline = true;
            this.TXTSINTOMAS.Name = "TXTSINTOMAS";
            this.TXTSINTOMAS.Size = new System.Drawing.Size(244, 75);
            this.TXTSINTOMAS.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Diagnostico";
            // 
            // TXTDIAGNOSTICO
            // 
            this.TXTDIAGNOSTICO.Location = new System.Drawing.Point(156, 190);
            this.TXTDIAGNOSTICO.MaxLength = 255;
            this.TXTDIAGNOSTICO.Multiline = true;
            this.TXTDIAGNOSTICO.Name = "TXTDIAGNOSTICO";
            this.TXTDIAGNOSTICO.Size = new System.Drawing.Size(244, 75);
            this.TXTDIAGNOSTICO.TabIndex = 5;
            // 
            // BTNACEPTAR
            // 
            this.BTNACEPTAR.Location = new System.Drawing.Point(50, 307);
            this.BTNACEPTAR.Name = "BTNACEPTAR";
            this.BTNACEPTAR.Size = new System.Drawing.Size(122, 35);
            this.BTNACEPTAR.TabIndex = 6;
            this.BTNACEPTAR.Text = "&Aceptar";
            this.BTNACEPTAR.UseVisualStyleBackColor = true;
            this.BTNACEPTAR.Click += new System.EventHandler(this.BTNACEPTAR_Click);
            // 
            // BTNCANCELAR
            // 
            this.BTNCANCELAR.Location = new System.Drawing.Point(259, 307);
            this.BTNCANCELAR.Name = "BTNCANCELAR";
            this.BTNCANCELAR.Size = new System.Drawing.Size(122, 35);
            this.BTNCANCELAR.TabIndex = 7;
            this.BTNCANCELAR.Text = "&Cancelar";
            this.BTNCANCELAR.UseVisualStyleBackColor = true;
            this.BTNCANCELAR.Click += new System.EventHandler(this.BTNCANCELAR_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Paciente";
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(158, 32);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(242, 28);
            this.cmbPaciente.TabIndex = 9;
            // 
            // FrmRegistrarResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 365);
            this.Controls.Add(this.cmbPaciente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTNCANCELAR);
            this.Controls.Add(this.BTNACEPTAR);
            this.Controls.Add(this.TXTDIAGNOSTICO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTSINTOMAS);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "FrmRegistrarResultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "REGISTRAR RESULTADO CONSULTA";
            this.Load += new System.EventHandler(this.FrmRegistrarResultado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTSINTOMAS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTDIAGNOSTICO;
        private System.Windows.Forms.Button BTNACEPTAR;
        private System.Windows.Forms.Button BTNCANCELAR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPaciente;
    }
}