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
            this.labelSintomas = new System.Windows.Forms.Label();
            this.labelDiagnostico = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.richTextBoxDiagnostico = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSintomas = new System.Windows.Forms.RichTextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.labelHora = new System.Windows.Forms.Label();
            this.numericUpDownHH = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMM = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMM)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSintomas
            // 
            this.labelSintomas.AutoSize = true;
            this.labelSintomas.Location = new System.Drawing.Point(64, 103);
            this.labelSintomas.Name = "labelSintomas";
            this.labelSintomas.Size = new System.Drawing.Size(55, 13);
            this.labelSintomas.TabIndex = 0;
            this.labelSintomas.Text = "Síntomas:";
            // 
            // labelDiagnostico
            // 
            this.labelDiagnostico.AutoSize = true;
            this.labelDiagnostico.Location = new System.Drawing.Point(64, 182);
            this.labelDiagnostico.Name = "labelDiagnostico";
            this.labelDiagnostico.Size = new System.Drawing.Size(66, 13);
            this.labelDiagnostico.TabIndex = 1;
            this.labelDiagnostico.Text = "Diagnóstico:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // richTextBoxDiagnostico
            // 
            this.richTextBoxDiagnostico.Location = new System.Drawing.Point(136, 182);
            this.richTextBoxDiagnostico.Name = "richTextBoxDiagnostico";
            this.richTextBoxDiagnostico.Size = new System.Drawing.Size(362, 96);
            this.richTextBoxDiagnostico.TabIndex = 4;
            this.richTextBoxDiagnostico.Text = "";
            // 
            // richTextBoxSintomas
            // 
            this.richTextBoxSintomas.Location = new System.Drawing.Point(136, 103);
            this.richTextBoxSintomas.Name = "richTextBoxSintomas";
            this.richTextBoxSintomas.Size = new System.Drawing.Size(362, 68);
            this.richTextBoxSintomas.TabIndex = 5;
            this.richTextBoxSintomas.Text = "";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(344, 303);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 6;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(423, 303);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCerrar.TabIndex = 7;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Location = new System.Drawing.Point(64, 65);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(33, 13);
            this.labelHora.TabIndex = 8;
            this.labelHora.Text = "Hora:";
            // 
            // numericUpDownHH
            // 
            this.numericUpDownHH.Location = new System.Drawing.Point(136, 58);
            this.numericUpDownHH.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownHH.Name = "numericUpDownHH";
            this.numericUpDownHH.Size = new System.Drawing.Size(31, 20);
            this.numericUpDownHH.TabIndex = 9;
            // 
            // numericUpDownMM
            // 
            this.numericUpDownMM.Location = new System.Drawing.Point(173, 58);
            this.numericUpDownMM.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMM.Name = "numericUpDownMM";
            this.numericUpDownMM.Size = new System.Drawing.Size(31, 20);
            this.numericUpDownMM.TabIndex = 10;
            // 
            // FrmRegistrarResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 339);
            this.Controls.Add(this.numericUpDownMM);
            this.Controls.Add(this.numericUpDownHH);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.richTextBoxSintomas);
            this.Controls.Add(this.richTextBoxDiagnostico);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDiagnostico);
            this.Controls.Add(this.labelSintomas);
            this.Name = "FrmRegistrarResultado";
            this.Text = "REGISTRAR RESULTADO";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSintomas;
        private System.Windows.Forms.Label labelDiagnostico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RichTextBox richTextBoxDiagnostico;
        private System.Windows.Forms.RichTextBox richTextBoxSintomas;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.NumericUpDown numericUpDownHH;
        private System.Windows.Forms.NumericUpDown numericUpDownMM;
    }
}