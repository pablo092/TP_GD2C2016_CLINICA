namespace ClinicaFrba.Abm_Especialidades_Medicas
{
    partial class FrmBuscarEspecialidadesMedicas
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
            this.dataGridViewEspMed = new System.Windows.Forms.DataGridView();
            this.buttonCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEspMed)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEspMed
            // 
            this.dataGridViewEspMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEspMed.Location = new System.Drawing.Point(32, 32);
            this.dataGridViewEspMed.Name = "dataGridViewEspMed";
            this.dataGridViewEspMed.Size = new System.Drawing.Size(524, 284);
            this.dataGridViewEspMed.TabIndex = 0;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(451, 346);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(105, 31);
            this.buttonCerrar.TabIndex = 1;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // FrmBuscarEspecialidadesMedicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 389);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.dataGridViewEspMed);
            this.Name = "FrmBuscarEspecialidadesMedicas";
            this.Text = "ESPECIALIDADES MÉDICAS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEspMed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEspMed;
        private System.Windows.Forms.Button buttonCerrar;
    }
}