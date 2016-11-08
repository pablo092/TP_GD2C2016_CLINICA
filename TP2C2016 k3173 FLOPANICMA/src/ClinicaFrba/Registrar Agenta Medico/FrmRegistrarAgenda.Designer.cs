namespace ClinicaFrba.Registrar_Agenta_Medico
{
    partial class FrmRegistrarAgenda
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
            this.labelProfesional = new System.Windows.Forms.Label();
            this.comboBoxProfesionales = new System.Windows.Forms.ComboBox();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.labelHorarioIni = new System.Windows.Forms.Label();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.labelEspecialidad = new System.Windows.Forms.Label();
            this.comboBoxEspecialidad = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFecIni = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFecFin = new System.Windows.Forms.DateTimePicker();
            this.labelFecFin = new System.Windows.Forms.Label();
            this.labelHorarioFin = new System.Windows.Forms.Label();
            this.numericUpDownHoraIni = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHoraFin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinIni = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinFin = new System.Windows.Forms.NumericUpDown();
            this.labelHSI = new System.Windows.Forms.Label();
            this.labelHSF = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHoraIni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHoraFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinIni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinFin)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProfesional
            // 
            this.labelProfesional.AutoSize = true;
            this.labelProfesional.Location = new System.Drawing.Point(37, 43);
            this.labelProfesional.Name = "labelProfesional";
            this.labelProfesional.Size = new System.Drawing.Size(62, 13);
            this.labelProfesional.TabIndex = 0;
            this.labelProfesional.Text = "Profesional:";
            // 
            // comboBoxProfesionales
            // 
            this.comboBoxProfesionales.FormattingEnabled = true;
            this.comboBoxProfesionales.Location = new System.Drawing.Point(126, 43);
            this.comboBoxProfesionales.Name = "comboBoxProfesionales";
            this.comboBoxProfesionales.Size = new System.Drawing.Size(284, 21);
            this.comboBoxProfesionales.TabIndex = 1;
            this.comboBoxProfesionales.SelectedIndexChanged += new System.EventHandler(this.comboBoxProfesionales_Click);
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Location = new System.Drawing.Point(37, 114);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(83, 13);
            this.labelFechaInicio.TabIndex = 2;
            this.labelFechaInicio.Text = "Fecha de Inicio:";
            // 
            // labelHorarioIni
            // 
            this.labelHorarioIni.AutoSize = true;
            this.labelHorarioIni.Location = new System.Drawing.Point(37, 185);
            this.labelHorarioIni.Name = "labelHorarioIni";
            this.labelHorarioIni.Size = new System.Drawing.Size(72, 13);
            this.labelHorarioIni.TabIndex = 4;
            this.labelHorarioIni.Text = "Horario Inicio:";
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(268, 282);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(107, 34);
            this.buttonCerrar.TabIndex = 7;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(126, 282);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(116, 34);
            this.buttonAceptar.TabIndex = 8;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // labelEspecialidad
            // 
            this.labelEspecialidad.AutoSize = true;
            this.labelEspecialidad.Location = new System.Drawing.Point(37, 82);
            this.labelEspecialidad.Name = "labelEspecialidad";
            this.labelEspecialidad.Size = new System.Drawing.Size(70, 13);
            this.labelEspecialidad.TabIndex = 9;
            this.labelEspecialidad.Text = "Especialidad:";
            // 
            // comboBoxEspecialidad
            // 
            this.comboBoxEspecialidad.FormattingEnabled = true;
            this.comboBoxEspecialidad.Location = new System.Drawing.Point(126, 82);
            this.comboBoxEspecialidad.Name = "comboBoxEspecialidad";
            this.comboBoxEspecialidad.Size = new System.Drawing.Size(284, 21);
            this.comboBoxEspecialidad.TabIndex = 10;
            // 
            // dateTimePickerFecIni
            // 
            this.dateTimePickerFecIni.Location = new System.Drawing.Point(126, 114);
            this.dateTimePickerFecIni.Name = "dateTimePickerFecIni";
            this.dateTimePickerFecIni.Size = new System.Drawing.Size(211, 20);
            this.dateTimePickerFecIni.TabIndex = 11;
            // 
            // dateTimePickerFecFin
            // 
            this.dateTimePickerFecFin.Location = new System.Drawing.Point(126, 147);
            this.dateTimePickerFecFin.Name = "dateTimePickerFecFin";
            this.dateTimePickerFecFin.Size = new System.Drawing.Size(211, 20);
            this.dateTimePickerFecFin.TabIndex = 12;
            // 
            // labelFecFin
            // 
            this.labelFecFin.AutoSize = true;
            this.labelFecFin.Location = new System.Drawing.Point(37, 147);
            this.labelFecFin.Name = "labelFecFin";
            this.labelFecFin.Size = new System.Drawing.Size(57, 13);
            this.labelFecFin.TabIndex = 13;
            this.labelFecFin.Text = "Fecha Fin:";
            // 
            // labelHorarioFin
            // 
            this.labelHorarioFin.AutoSize = true;
            this.labelHorarioFin.Location = new System.Drawing.Point(37, 216);
            this.labelHorarioFin.Name = "labelHorarioFin";
            this.labelHorarioFin.Size = new System.Drawing.Size(61, 13);
            this.labelHorarioFin.TabIndex = 14;
            this.labelHorarioFin.Text = "Horario Fin:";
            // 
            // numericUpDownHoraIni
            // 
            this.numericUpDownHoraIni.Location = new System.Drawing.Point(126, 183);
            this.numericUpDownHoraIni.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownHoraIni.Name = "numericUpDownHoraIni";
            this.numericUpDownHoraIni.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownHoraIni.TabIndex = 15;
            // 
            // numericUpDownHoraFin
            // 
            this.numericUpDownHoraFin.Location = new System.Drawing.Point(126, 216);
            this.numericUpDownHoraFin.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownHoraFin.Name = "numericUpDownHoraFin";
            this.numericUpDownHoraFin.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownHoraFin.TabIndex = 16;
            // 
            // numericUpDownMinIni
            // 
            this.numericUpDownMinIni.Location = new System.Drawing.Point(182, 183);
            this.numericUpDownMinIni.Name = "numericUpDownMinIni";
            this.numericUpDownMinIni.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownMinIni.TabIndex = 17;
            this.numericUpDownMinIni.Click += new System.EventHandler(this.numericUpDownSegIni_Click);
            // 
            // numericUpDownMinFin
            // 
            this.numericUpDownMinFin.Location = new System.Drawing.Point(182, 216);
            this.numericUpDownMinFin.Name = "numericUpDownMinFin";
            this.numericUpDownMinFin.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownMinFin.TabIndex = 18;
            this.numericUpDownMinFin.Click += new System.EventHandler(this.numericUpDownSegFin_Click);
            // 
            // labelHSI
            // 
            this.labelHSI.AutoSize = true;
            this.labelHSI.Location = new System.Drawing.Point(229, 185);
            this.labelHSI.Name = "labelHSI";
            this.labelHSI.Size = new System.Drawing.Size(22, 13);
            this.labelHSI.TabIndex = 19;
            this.labelHSI.Text = "HS";
            // 
            // labelHSF
            // 
            this.labelHSF.AutoSize = true;
            this.labelHSF.Location = new System.Drawing.Point(229, 218);
            this.labelHSF.Name = "labelHSF";
            this.labelHSF.Size = new System.Drawing.Size(22, 13);
            this.labelHSF.TabIndex = 20;
            this.labelHSF.Text = "HS";
            // 
            // FrmRegistrarAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 335);
            this.Controls.Add(this.labelHSF);
            this.Controls.Add(this.labelHSI);
            this.Controls.Add(this.numericUpDownMinFin);
            this.Controls.Add(this.numericUpDownMinIni);
            this.Controls.Add(this.numericUpDownHoraFin);
            this.Controls.Add(this.numericUpDownHoraIni);
            this.Controls.Add(this.labelHorarioFin);
            this.Controls.Add(this.labelFecFin);
            this.Controls.Add(this.dateTimePickerFecFin);
            this.Controls.Add(this.dateTimePickerFecIni);
            this.Controls.Add(this.comboBoxEspecialidad);
            this.Controls.Add(this.labelEspecialidad);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.labelHorarioIni);
            this.Controls.Add(this.labelFechaInicio);
            this.Controls.Add(this.comboBoxProfesionales);
            this.Controls.Add(this.labelProfesional);
            this.Name = "FrmRegistrarAgenda";
            this.Text = "REGISTRAR AGENDA MÉDICO";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHoraIni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHoraFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinIni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinFin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProfesional;
        private System.Windows.Forms.ComboBox comboBoxProfesionales;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Label labelHorarioIni;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label labelEspecialidad;
        private System.Windows.Forms.ComboBox comboBoxEspecialidad;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecIni;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecFin;
        private System.Windows.Forms.Label labelFecFin;
        private System.Windows.Forms.Label labelHorarioFin;
        private System.Windows.Forms.NumericUpDown numericUpDownHoraIni;
        private System.Windows.Forms.NumericUpDown numericUpDownHoraFin;
        private System.Windows.Forms.NumericUpDown numericUpDownMinIni;
        private System.Windows.Forms.NumericUpDown numericUpDownMinFin;
        private System.Windows.Forms.Label labelHSI;
        private System.Windows.Forms.Label labelHSF;
    }
}