namespace ClinicaFrba.Abm_Planes
{
    partial class FrmBuscarPlan
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
            this.dataGridViewPlanes = new System.Windows.Forms.DataGridView();
            this.buttonCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlanes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPlanes
            // 
            this.dataGridViewPlanes.AllowUserToOrderColumns = true;
            this.dataGridViewPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlanes.Location = new System.Drawing.Point(30, 24);
            this.dataGridViewPlanes.Name = "dataGridViewPlanes";
            this.dataGridViewPlanes.Size = new System.Drawing.Size(760, 250);
            this.dataGridViewPlanes.TabIndex = 1;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(660, 310);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(130, 38);
            this.buttonCerrar.TabIndex = 2;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // FrmBuscarPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 373);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.dataGridViewPlanes);
            this.Name = "FrmBuscarPlan";
            this.Text = "LISTADO DE PLANES";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlanes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPlanes;
        private System.Windows.Forms.Button buttonCerrar;
    }
}