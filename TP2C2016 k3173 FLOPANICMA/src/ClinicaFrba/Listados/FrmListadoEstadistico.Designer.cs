namespace ClinicaFrba.Listados
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.L_Tipo_Listado = new System.Windows.Forms.Label();
            this.Tipo_Listado = new System.Windows.Forms.ComboBox();
            this.L_Anio = new System.Windows.Forms.Label();
            this.NUDAnio = new System.Windows.Forms.NumericUpDown();
            this.L_Semestre = new System.Windows.Forms.Label();
            this.CMBSemestre = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.L_Mes = new System.Windows.Forms.Label();
            this.CMBMes = new System.Windows.Forms.ComboBox();
            this.L_Filtro_Extra = new System.Windows.Forms.Label();
            this.Filtro_Extra = new System.Windows.Forms.ComboBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.DGVListados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListados)).BeginInit();
            this.SuspendLayout();
            // 
            // L_Tipo_Listado
            // 
            this.L_Tipo_Listado.AutoSize = true;
            this.L_Tipo_Listado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.L_Tipo_Listado.Location = new System.Drawing.Point(12, 23);
            this.L_Tipo_Listado.Name = "L_Tipo_Listado";
            this.L_Tipo_Listado.Size = new System.Drawing.Size(236, 17);
            this.L_Tipo_Listado.TabIndex = 0;
            this.L_Tipo_Listado.Text = "Selecccionar tipo de listado (Top 5):";
            // 
            // Tipo_Listado
            // 
            this.Tipo_Listado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tipo_Listado.FormattingEnabled = true;
            this.Tipo_Listado.Location = new System.Drawing.Point(11, 50);
            this.Tipo_Listado.Name = "Tipo_Listado";
            this.Tipo_Listado.Size = new System.Drawing.Size(333, 24);
            this.Tipo_Listado.TabIndex = 1;
            this.Tipo_Listado.Text = "Seleccione listado";
            this.Tipo_Listado.SelectedIndexChanged += new System.EventHandler(this.Tipo_Listado_SelectedIndexChanged);
            // 
            // L_Anio
            // 
            this.L_Anio.AutoSize = true;
            this.L_Anio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.L_Anio.Location = new System.Drawing.Point(386, 24);
            this.L_Anio.Name = "L_Anio";
            this.L_Anio.Size = new System.Drawing.Size(37, 17);
            this.L_Anio.TabIndex = 2;
            this.L_Anio.Text = "Año:";
            // 
            // NUDAnio
            // 
            this.NUDAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NUDAnio.Location = new System.Drawing.Point(472, 21);
            this.NUDAnio.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.NUDAnio.Minimum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.NUDAnio.Name = "NUDAnio";
            this.NUDAnio.Size = new System.Drawing.Size(120, 23);
            this.NUDAnio.TabIndex = 3;
            this.NUDAnio.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            // 
            // L_Semestre
            // 
            this.L_Semestre.AutoSize = true;
            this.L_Semestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.L_Semestre.Location = new System.Drawing.Point(385, 61);
            this.L_Semestre.Name = "L_Semestre";
            this.L_Semestre.Size = new System.Drawing.Size(72, 17);
            this.L_Semestre.TabIndex = 4;
            this.L_Semestre.Text = "Semestre:";
            // 
            // CMBSemestre
            // 
            this.CMBSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CMBSemestre.FormattingEnabled = true;
            this.CMBSemestre.Items.AddRange(new object[] {
            "1er Semestre",
            "2do Semestre"});
            this.CMBSemestre.Location = new System.Drawing.Point(472, 57);
            this.CMBSemestre.Name = "CMBSemestre";
            this.CMBSemestre.Size = new System.Drawing.Size(179, 24);
            this.CMBSemestre.TabIndex = 5;
            this.CMBSemestre.Text = "Seleccione Semestre";
            this.CMBSemestre.SelectedIndexChanged += new System.EventHandler(this.CMBSemestre_SelectedIndexChanged);
            // 
            // L_Mes
            // 
            this.L_Mes.AutoSize = true;
            this.L_Mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.L_Mes.Location = new System.Drawing.Point(386, 101);
            this.L_Mes.Name = "L_Mes";
            this.L_Mes.Size = new System.Drawing.Size(38, 17);
            this.L_Mes.TabIndex = 6;
            this.L_Mes.Text = "Mes:";
            // 
            // CMBMes
            // 
            this.CMBMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CMBMes.FormattingEnabled = true;
            this.CMBMes.Items.AddRange(new object[] {
            "Semestre",
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.CMBMes.Location = new System.Drawing.Point(471, 97);
            this.CMBMes.Name = "CMBMes";
            this.CMBMes.Size = new System.Drawing.Size(180, 24);
            this.CMBMes.TabIndex = 7;
            this.CMBMes.Text = "Seleccione mes";
            // 
            // L_Filtro_Extra
            // 
            this.L_Filtro_Extra.AutoSize = true;
            this.L_Filtro_Extra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.L_Filtro_Extra.Location = new System.Drawing.Point(11, 101);
            this.L_Filtro_Extra.Name = "L_Filtro_Extra";
            this.L_Filtro_Extra.Size = new System.Drawing.Size(43, 17);
            this.L_Filtro_Extra.TabIndex = 8;
            this.L_Filtro_Extra.Text = "Filtro:";
            // 
            // Filtro_Extra
            // 
            this.Filtro_Extra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Filtro_Extra.FormattingEnabled = true;
            this.Filtro_Extra.Location = new System.Drawing.Point(65, 97);
            this.Filtro_Extra.Name = "Filtro_Extra";
            this.Filtro_Extra.Size = new System.Drawing.Size(279, 24);
            this.Filtro_Extra.Sorted = true;
            this.Filtro_Extra.TabIndex = 9;
            this.Filtro_Extra.Text = "Seleccion filtro";
            // 
            // Buscar
            // 
            this.Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Buscar.Location = new System.Drawing.Point(224, 142);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(80, 29);
            this.Buscar.TabIndex = 10;
            this.Buscar.Text = "&Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cancelar.Location = new System.Drawing.Point(374, 142);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(80, 29);
            this.Cancelar.TabIndex = 11;
            this.Cancelar.Text = "&Cerrar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // DGVListados
            // 
            this.DGVListados.AllowUserToOrderColumns = true;
            this.DGVListados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListados.Location = new System.Drawing.Point(17, 177);
            this.DGVListados.Name = "DGVListados";
            this.DGVListados.Size = new System.Drawing.Size(642, 242);
            this.DGVListados.TabIndex = 12;
            // 
            // FrmListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 445);
            this.Controls.Add(this.DGVListados);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Filtro_Extra);
            this.Controls.Add(this.L_Filtro_Extra);
            this.Controls.Add(this.CMBMes);
            this.Controls.Add(this.L_Mes);
            this.Controls.Add(this.CMBSemestre);
            this.Controls.Add(this.L_Semestre);
            this.Controls.Add(this.NUDAnio);
            this.Controls.Add(this.L_Anio);
            this.Controls.Add(this.Tipo_Listado);
            this.Controls.Add(this.L_Tipo_Listado);
            this.MaximizeBox = false;
            this.Name = "FrmListadoEstadistico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listado Estadistico";
            this.Load += new System.EventHandler(this.FrmListadoEstadistico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Tipo_Listado;
        private System.Windows.Forms.ComboBox Tipo_Listado;
        private System.Windows.Forms.Label L_Anio;
        private System.Windows.Forms.NumericUpDown NUDAnio;
        private System.Windows.Forms.Label L_Semestre;
        private System.Windows.Forms.ComboBox CMBSemestre;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label L_Mes;
        private System.Windows.Forms.ComboBox CMBMes;
        private System.Windows.Forms.Label L_Filtro_Extra;
        private System.Windows.Forms.ComboBox Filtro_Extra;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.DataGridView DGVListados;
    }
}