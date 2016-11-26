namespace ClinicaFrba.Registro_Llegada
{
    partial class FrmRegistrarLlegada
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
            this.label1 = new System.Windows.Forms.Label();
            this.CMBEspecialidades = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CMBProfesional = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CMBAfiliado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CMBTurno = new System.Windows.Forms.ComboBox();
            this.BTNAceptar = new System.Windows.Forms.Button();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroAfiliado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Especialidad";
            // 
            // CMBEspecialidades
            // 
            this.CMBEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBEspecialidades.Enabled = false;
            this.CMBEspecialidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBEspecialidades.FormattingEnabled = true;
            this.CMBEspecialidades.Items.AddRange(new object[] {
            "Todas"});
            this.CMBEspecialidades.Location = new System.Drawing.Point(259, 127);
            this.CMBEspecialidades.Name = "CMBEspecialidades";
            this.CMBEspecialidades.Size = new System.Drawing.Size(234, 28);
            this.CMBEspecialidades.Sorted = true;
            this.CMBEspecialidades.TabIndex = 2;
            this.CMBEspecialidades.SelectedIndexChanged += new System.EventHandler(this.CMBEspecialidades_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Profesional";
            // 
            // CMBProfesional
            // 
            this.CMBProfesional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBProfesional.Enabled = false;
            this.CMBProfesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBProfesional.FormattingEnabled = true;
            this.CMBProfesional.Location = new System.Drawing.Point(259, 181);
            this.CMBProfesional.Name = "CMBProfesional";
            this.CMBProfesional.Size = new System.Drawing.Size(232, 28);
            this.CMBProfesional.Sorted = true;
            this.CMBProfesional.TabIndex = 3;
            this.CMBProfesional.SelectedIndexChanged += new System.EventHandler(this.CMBProfesional_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Afiliado";
            // 
            // CMBAfiliado
            // 
            this.CMBAfiliado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CMBAfiliado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CMBAfiliado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBAfiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBAfiliado.FormattingEnabled = true;
            this.CMBAfiliado.Location = new System.Drawing.Point(259, 77);
            this.CMBAfiliado.Name = "CMBAfiliado";
            this.CMBAfiliado.Size = new System.Drawing.Size(234, 28);
            this.CMBAfiliado.Sorted = true;
            this.CMBAfiliado.TabIndex = 1;
            this.CMBAfiliado.SelectedIndexChanged += new System.EventHandler(this.CMBAfiliado_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Turno";
            // 
            // CMBTurno
            // 
            this.CMBTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBTurno.Enabled = false;
            this.CMBTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBTurno.FormattingEnabled = true;
            this.CMBTurno.Location = new System.Drawing.Point(259, 234);
            this.CMBTurno.Name = "CMBTurno";
            this.CMBTurno.Size = new System.Drawing.Size(229, 28);
            this.CMBTurno.Sorted = true;
            this.CMBTurno.TabIndex = 4;
            // 
            // BTNAceptar
            // 
            this.BTNAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAceptar.Location = new System.Drawing.Point(116, 312);
            this.BTNAceptar.Name = "BTNAceptar";
            this.BTNAceptar.Size = new System.Drawing.Size(124, 33);
            this.BTNAceptar.TabIndex = 7;
            this.BTNAceptar.Text = "&Aceptar";
            this.BTNAceptar.UseVisualStyleBackColor = true;
            this.BTNAceptar.Click += new System.EventHandler(this.BTNAceptar_Click);
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCancelar.Location = new System.Drawing.Point(341, 312);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(124, 33);
            this.BTNCancelar.TabIndex = 8;
            this.BTNCancelar.Text = "&Cancelar";
            this.BTNCancelar.UseVisualStyleBackColor = true;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Numero de Afiliado";
            // 
            // txtNumeroAfiliado
            // 
            this.txtNumeroAfiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroAfiliado.Location = new System.Drawing.Point(259, 33);
            this.txtNumeroAfiliado.Name = "txtNumeroAfiliado";
            this.txtNumeroAfiliado.Size = new System.Drawing.Size(233, 26);
            this.txtNumeroAfiliado.TabIndex = 13;
            this.txtNumeroAfiliado.Text = "Ingrese numero de afiliado";
            this.txtNumeroAfiliado.TextChanged += new System.EventHandler(this.txtNumeroAfiliado_TextChanged);
            // 
            // FrmRegistrarLlegada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 374);
            this.Controls.Add(this.txtNumeroAfiliado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTNCancelar);
            this.Controls.Add(this.BTNAceptar);
            this.Controls.Add(this.CMBTurno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CMBAfiliado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CMBProfesional);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CMBEspecialidades);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistrarLlegada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar Llegada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CMBEspecialidades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CMBProfesional;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CMBAfiliado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CMBTurno;
        private System.Windows.Forms.Button BTNAceptar;
        private System.Windows.Forms.Button BTNCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumeroAfiliado;
    }
}