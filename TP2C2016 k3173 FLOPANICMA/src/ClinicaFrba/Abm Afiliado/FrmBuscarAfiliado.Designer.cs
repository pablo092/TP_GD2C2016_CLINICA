namespace ClinicaFrba.ABM_Afiliado
{
    partial class FrmBuscarAfiliado
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNroAfil = new System.Windows.Forms.Label();
            this.txtNroAfil = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.listadoAfiliados = new System.Windows.Forms.DataGridView();
            this.msgBusqueda = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoAfiliados)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNroAfil);
            this.groupBox1.Controls.Add(this.txtNroAfil);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTRO BUSQUEDA";
            // 
            // lblNroAfil
            // 
            this.lblNroAfil.AutoSize = true;
            this.lblNroAfil.Location = new System.Drawing.Point(6, 34);
            this.lblNroAfil.Name = "lblNroAfil";
            this.lblNroAfil.Size = new System.Drawing.Size(88, 13);
            this.lblNroAfil.TabIndex = 1;
            this.lblNroAfil.Text = "NRO. AFILIADO:";
            // 
            // txtNroAfil
            // 
            this.txtNroAfil.Location = new System.Drawing.Point(100, 31);
            this.txtNroAfil.Name = "txtNroAfil";
            this.txtNroAfil.Size = new System.Drawing.Size(224, 20);
            this.txtNroAfil.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(13, 88);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(278, 88);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // listadoAfiliados
            // 
            this.listadoAfiliados.AllowUserToAddRows = false;
            this.listadoAfiliados.AllowUserToDeleteRows = false;
            this.listadoAfiliados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listadoAfiliados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoAfiliados.Location = new System.Drawing.Point(12, 117);
            this.listadoAfiliados.MultiSelect = false;
            this.listadoAfiliados.Name = "listadoAfiliados";
            this.listadoAfiliados.ReadOnly = true;
            this.listadoAfiliados.RowHeadersVisible = false;
            this.listadoAfiliados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listadoAfiliados.Size = new System.Drawing.Size(341, 219);
            this.listadoAfiliados.TabIndex = 1;
            this.listadoAfiliados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listadoAfiliados_CellContentClick);
            // 
            // msgBusqueda
            // 
            this.msgBusqueda.Name = "msgBusqueda";
            this.msgBusqueda.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msgBusqueda});
            this.statusStrip1.Location = new System.Drawing.Point(0, 340);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(368, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FrmBuscarAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 362);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listadoAfiliados);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(384, 400);
            this.MinimumSize = new System.Drawing.Size(384, 400);
            this.Name = "FrmBuscarAfiliado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSCAR AFILIADO";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoAfiliados)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNroAfil;
        private System.Windows.Forms.TextBox txtNroAfil;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView listadoAfiliados;
        private System.Windows.Forms.ToolStripStatusLabel msgBusqueda;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}