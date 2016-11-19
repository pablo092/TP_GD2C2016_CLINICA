namespace ClinicaFrba.Listados
{
    partial class ListadoEstadistico
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.L_Semestre = new System.Windows.Forms.Label();
            this.Semestre = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.L_Mes = new System.Windows.Forms.Label();
            this.Mes = new System.Windows.Forms.ComboBox();
            this.L_Filtro_Extra = new System.Windows.Forms.Label();
            this.Filtro_Extra = new System.Windows.Forms.ComboBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // L_Tipo_Listado
            // 
            this.L_Tipo_Listado.AutoSize = true;
            this.L_Tipo_Listado.Location = new System.Drawing.Point(18, 24);
            this.L_Tipo_Listado.Name = "L_Tipo_Listado";
            this.L_Tipo_Listado.Size = new System.Drawing.Size(140, 13);
            this.L_Tipo_Listado.TabIndex = 0;
            this.L_Tipo_Listado.Text = "Selecccionar tipo de listado:";
            // 
            // Tipo_Listado
            // 
            this.Tipo_Listado.FormattingEnabled = true;
            this.Tipo_Listado.Location = new System.Drawing.Point(171, 21);
            this.Tipo_Listado.Name = "Tipo_Listado";
            this.Tipo_Listado.Size = new System.Drawing.Size(121, 21);
            this.Tipo_Listado.TabIndex = 1;
            this.Tipo_Listado.Text = "Elija tipo de listado";
            this.Tipo_Listado.SelectedIndexChanged += new System.EventHandler(this.Tipo_Listado_SelectedIndexChanged);
            // 
            // L_Anio
            // 
            this.L_Anio.AutoSize = true;
            this.L_Anio.Location = new System.Drawing.Point(18, 58);
            this.L_Anio.Name = "L_Anio";
            this.L_Anio.Size = new System.Drawing.Size(29, 13);
            this.L_Anio.TabIndex = 2;
            this.L_Anio.Text = "Año:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(171, 58);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // L_Semestre
            // 
            this.L_Semestre.AutoSize = true;
            this.L_Semestre.Location = new System.Drawing.Point(385, 58);
            this.L_Semestre.Name = "L_Semestre";
            this.L_Semestre.Size = new System.Drawing.Size(54, 13);
            this.L_Semestre.TabIndex = 4;
            this.L_Semestre.Text = "Semestre:";
            // 
            // Semestre
            // 
            this.Semestre.FormattingEnabled = true;
            this.Semestre.Items.AddRange(new object[] {
            "1er Semestre",
            "2do Semestre"});
            this.Semestre.Location = new System.Drawing.Point(459, 57);
            this.Semestre.Name = "Semestre";
            this.Semestre.Size = new System.Drawing.Size(121, 21);
            this.Semestre.TabIndex = 5;
            // 
            // L_Mes
            // 
            this.L_Mes.AutoSize = true;
            this.L_Mes.Location = new System.Drawing.Point(385, 101);
            this.L_Mes.Name = "L_Mes";
            this.L_Mes.Size = new System.Drawing.Size(30, 13);
            this.L_Mes.TabIndex = 6;
            this.L_Mes.Text = "Mes:";
            // 
            // Mes
            // 
            this.Mes.FormattingEnabled = true;
            this.Mes.Items.AddRange(new object[] {
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
            this.Mes.Location = new System.Drawing.Point(459, 100);
            this.Mes.Name = "Mes";
            this.Mes.Size = new System.Drawing.Size(121, 21);
            this.Mes.TabIndex = 7;
            // 
            // L_Filtro_Extra
            // 
            this.L_Filtro_Extra.AutoSize = true;
            this.L_Filtro_Extra.Location = new System.Drawing.Point(387, 24);
            this.L_Filtro_Extra.Name = "L_Filtro_Extra";
            this.L_Filtro_Extra.Size = new System.Drawing.Size(32, 13);
            this.L_Filtro_Extra.TabIndex = 8;
            this.L_Filtro_Extra.Text = "Filtro:";
            // 
            // Filtro_Extra
            // 
            this.Filtro_Extra.FormattingEnabled = true;
            this.Filtro_Extra.Location = new System.Drawing.Point(459, 21);
            this.Filtro_Extra.Name = "Filtro_Extra";
            this.Filtro_Extra.Size = new System.Drawing.Size(200, 21);
            this.Filtro_Extra.TabIndex = 9;
            this.Filtro_Extra.SelectedIndexChanged += new System.EventHandler(this.Filtro_Extra_SelectedIndexChanged);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(21, 115);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 10;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(171, 115);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 11;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 242);
            this.dataGridView1.TabIndex = 12;
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 445);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Filtro_Extra);
            this.Controls.Add(this.L_Filtro_Extra);
            this.Controls.Add(this.Mes);
            this.Controls.Add(this.L_Mes);
            this.Controls.Add(this.Semestre);
            this.Controls.Add(this.L_Semestre);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.L_Anio);
            this.Controls.Add(this.Tipo_Listado);
            this.Controls.Add(this.L_Tipo_Listado);
            this.Name = "ListadoEstadistico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Estadistico";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Tipo_Listado;
        private System.Windows.Forms.ComboBox Tipo_Listado;
        private System.Windows.Forms.Label L_Anio;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label L_Semestre;
        private System.Windows.Forms.ComboBox Semestre;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label L_Mes;
        private System.Windows.Forms.ComboBox Mes;
        private System.Windows.Forms.Label L_Filtro_Extra;
        private System.Windows.Forms.ComboBox Filtro_Extra;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}