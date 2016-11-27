namespace ClinicaFrba.HistorialModificacionesPlan
{
    partial class FrmHistModifPlan
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
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.dataGridViewResultados = new System.Windows.Forms.DataGridView();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxNroAfiliado = new System.Windows.Forms.TextBox();
            this.labelNroAfil = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(469, 326);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(93, 30);
            this.buttonCerrar.TabIndex = 0;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewResultados
            // 
            this.dataGridViewResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultados.Location = new System.Drawing.Point(43, 91);
            this.dataGridViewResultados.Name = "dataGridViewResultados";
            this.dataGridViewResultados.Size = new System.Drawing.Size(519, 207);
            this.dataGridViewResultados.TabIndex = 1;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(405, 41);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(93, 30);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // textBoxNroAfiliado
            // 
            this.textBoxNroAfiliado.Location = new System.Drawing.Point(145, 47);
            this.textBoxNroAfiliado.Name = "textBoxNroAfiliado";
            this.textBoxNroAfiliado.Size = new System.Drawing.Size(239, 20);
            this.textBoxNroAfiliado.TabIndex = 3;
            // 
            // labelNroAfil
            // 
            this.labelNroAfil.AutoSize = true;
            this.labelNroAfil.Location = new System.Drawing.Point(40, 54);
            this.labelNroAfil.Name = "labelNroAfil";
            this.labelNroAfil.Size = new System.Drawing.Size(99, 13);
            this.labelNroAfil.TabIndex = 4;
            this.labelNroAfil.Text = "Número de Afiliado:";
            // 
            // FrmHistModifPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 368);
            this.Controls.Add(this.labelNroAfil);
            this.Controls.Add(this.textBoxNroAfiliado);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.dataGridViewResultados);
            this.Controls.Add(this.buttonCerrar);
            this.Name = "FrmHistModifPlan";
            this.Text = "HISTORIAL DE MODIFICACIONES PLAN MEDICO";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.DataGridView dataGridViewResultados;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxNroAfiliado;
        private System.Windows.Forms.Label labelNroAfil;
    }
}