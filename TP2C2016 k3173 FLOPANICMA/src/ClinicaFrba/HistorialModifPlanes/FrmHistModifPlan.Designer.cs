namespace ClinicaFrba.HistorialModifPlanes
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
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelBusquedaAfil = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(426, 335);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(115, 29);
            this.buttonCerrar.TabIndex = 0;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(426, 48);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(115, 29);
            this.buttonBuscar.TabIndex = 1;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // labelBusquedaAfil
            // 
            this.labelBusquedaAfil.AutoSize = true;
            this.labelBusquedaAfil.Location = new System.Drawing.Point(35, 60);
            this.labelBusquedaAfil.Name = "labelBusquedaAfil";
            this.labelBusquedaAfil.Size = new System.Drawing.Size(132, 13);
            this.labelBusquedaAfil.TabIndex = 2;
            this.labelBusquedaAfil.Text = "Ingrese numero de Afiliado";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 3;
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Location = new System.Drawing.Point(38, 107);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.Size = new System.Drawing.Size(503, 209);
            this.dataGridViewResult.TabIndex = 4;
            // 
            // FrmHistModifPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 376);
            this.Controls.Add(this.dataGridViewResult);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelBusquedaAfil);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonCerrar);
            this.Name = "FrmHistModifPlan";
            this.Text = "HISTORIAL DE MODIFICACIONES DE PLANES";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelBusquedaAfil;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridViewResult;
    }
}