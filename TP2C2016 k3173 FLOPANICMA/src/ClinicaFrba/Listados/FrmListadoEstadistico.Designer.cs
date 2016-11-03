namespace ClinicaFrba.Listado_Estadistico
{
    partial class FrmListadoEstadistico
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

        #region Windows Form Designer geneFLOPANICMAed code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbListaMetodos = new System.Windows.Forms.ComboBox();
            this.listado = new System.Windows.Forms.DataGridView();
            this.cbVisibilidades = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAnio = new System.Windows.Forms.TextBox();
            this.cbTrimestres = new System.Windows.Forms.ComboBox();
            this.cbRubros = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bBuscar = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.msgUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.listado)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbListaMetodos
            // 
            this.cbListaMetodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListaMetodos.FormattingEnabled = true;
            this.cbListaMetodos.Location = new System.Drawing.Point(54, 12);
            this.cbListaMetodos.Name = "cbListaMetodos";
            this.cbListaMetodos.Size = new System.Drawing.Size(311, 21);
            this.cbListaMetodos.TabIndex = 0;
            this.cbListaMetodos.SelectedIndexChanged += new System.EventHandler(this.CbListaMetodos_SelectedIndexChanged);
            // 
            // listado
            // 
            this.listado.AllowUserToAddRows = false;
            this.listado.AllowUserToDeleteRows = false;
            this.listado.AllowUserToOrderColumns = true;
            this.listado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listado.Location = new System.Drawing.Point(12, 107);
            this.listado.Name = "listado";
            this.listado.ReadOnly = true;
            this.listado.RowHeadersVisible = false;
            this.listado.Size = new System.Drawing.Size(635, 138);
            this.listado.TabIndex = 1;
            // 
            // cbVisibilidades
            // 
            this.cbVisibilidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVisibilidades.FormattingEnabled = true;
            this.cbVisibilidades.Location = new System.Drawing.Point(440, 12);
            this.cbVisibilidades.Name = "cbVisibilidades";
            this.cbVisibilidades.Size = new System.Drawing.Size(207, 21);
            this.cbVisibilidades.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "TOP 5";
            // 
            // lbFiltro
            // 
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.Location = new System.Drawing.Point(381, 15);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(53, 13);
            this.lbFiltro.TabIndex = 4;
            this.lbFiltro.Text = "Visibilidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Año";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Trimestre";
            // 
            // tbAnio
            // 
            this.tbAnio.Location = new System.Drawing.Point(54, 42);
            this.tbAnio.Name = "tbAnio";
            this.tbAnio.Size = new System.Drawing.Size(86, 20);
            this.tbAnio.TabIndex = 7;
            this.tbAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAnio_KeyPress);
            // 
            // cbTrimestres
            // 
            this.cbTrimestres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrimestres.FormattingEnabled = true;
            this.cbTrimestres.Location = new System.Drawing.Point(234, 42);
            this.cbTrimestres.Name = "cbTrimestres";
            this.cbTrimestres.Size = new System.Drawing.Size(131, 21);
            this.cbTrimestres.TabIndex = 8;
            // 
            // cbRubros
            // 
            this.cbRubros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRubros.FormattingEnabled = true;
            this.cbRubros.Location = new System.Drawing.Point(440, 42);
            this.cbRubros.Name = "cbRubros";
            this.cbRubros.Size = new System.Drawing.Size(207, 21);
            this.cbRubros.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Rubro";
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(54, 78);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(86, 23);
            this.bBuscar.TabIndex = 11;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(146, 78);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(86, 23);
            this.bLimpiar.TabIndex = 12;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msgUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 259);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(659, 22);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // msgUsuario
            // 
            this.msgUsuario.Name = "msgUsuario";
            this.msgUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // FrmListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 320);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbRubros);
            this.Controls.Add(this.cbTrimestres);
            this.Controls.Add(this.tbAnio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbVisibilidades);
            this.Controls.Add(this.listado);
            this.Controls.Add(this.cbListaMetodos);
            this.MaximumSize = new System.Drawing.Size(675, 320);
            this.MinimumSize = new System.Drawing.Size(675, 320);
            this.Name = "FrmListadoEstadistico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTADO ESTADISTICO";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listado)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbListaMetodos;
        private System.Windows.Forms.DataGridView listado;
        private System.Windows.Forms.ComboBox cbVisibilidades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAnio;
        private System.Windows.Forms.ComboBox cbTrimestres;
        private System.Windows.Forms.ComboBox cbRubros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel msgUsuario;
    }
}