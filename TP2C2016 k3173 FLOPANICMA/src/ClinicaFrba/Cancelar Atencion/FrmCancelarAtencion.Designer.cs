namespace ClinicaFrba.Cancelar_Atencion
{
    partial class FrmCancelarAtencion
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
            this.label1 = new System.Windows.Forms.Label();
            this.CHBPeriodo = new System.Windows.Forms.CheckBox();
            this.CHBDia = new System.Windows.Forms.CheckBox();
            this.DTPFin = new System.Windows.Forms.DateTimePicker();
            this.DTPInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblInicial = new System.Windows.Forms.Label();
            this.lblPersona = new System.Windows.Forms.Label();
            this.BTNAceptar = new System.Windows.Forms.Button();
            this.BTNCerrar = new System.Windows.Forms.Button();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.TXTMotivo = new System.Windows.Forms.TextBox();
            this.CMBFamiliar = new System.Windows.Forms.ComboBox();
            this.CHBPersonal = new System.Windows.Forms.CheckBox();
            this.CHBFamiliar = new System.Windows.Forms.CheckBox();
            this.CMBTurno = new System.Windows.Forms.ComboBox();
            this.lblFamiliar = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccione tipo de cancelacion";
            // 
            // CHBPeriodo
            // 
            this.CHBPeriodo.AutoSize = true;
            this.CHBPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHBPeriodo.Location = new System.Drawing.Point(306, 88);
            this.CHBPeriodo.Name = "CHBPeriodo";
            this.CHBPeriodo.Size = new System.Drawing.Size(82, 24);
            this.CHBPeriodo.TabIndex = 6;
            this.CHBPeriodo.Text = "Periodo";
            this.CHBPeriodo.UseVisualStyleBackColor = true;
            this.CHBPeriodo.Visible = false;
            this.CHBPeriodo.CheckedChanged += new System.EventHandler(this.CHBPeriodo_CheckedChanged);
            // 
            // CHBDia
            // 
            this.CHBDia.AutoSize = true;
            this.CHBDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHBDia.Location = new System.Drawing.Point(149, 88);
            this.CHBDia.Name = "CHBDia";
            this.CHBDia.Size = new System.Drawing.Size(52, 24);
            this.CHBDia.TabIndex = 5;
            this.CHBDia.Text = "Dia";
            this.CHBDia.UseVisualStyleBackColor = true;
            this.CHBDia.Visible = false;
            this.CHBDia.CheckedChanged += new System.EventHandler(this.CHBDia_CheckedChanged);
            // 
            // DTPFin
            // 
            this.DTPFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFin.Location = new System.Drawing.Point(182, 177);
            this.DTPFin.Name = "DTPFin";
            this.DTPFin.Size = new System.Drawing.Size(312, 26);
            this.DTPFin.TabIndex = 4;
            this.DTPFin.Visible = false;
            // 
            // DTPInicio
            // 
            this.DTPInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPInicio.Location = new System.Drawing.Point(182, 145);
            this.DTPInicio.Name = "DTPInicio";
            this.DTPInicio.Size = new System.Drawing.Size(312, 26);
            this.DTPInicio.TabIndex = 3;
            this.DTPInicio.Visible = false;
            this.DTPInicio.ValueChanged += new System.EventHandler(this.DTPInicio_ValueChanged);
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinal.Location = new System.Drawing.Point(61, 182);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(87, 20);
            this.lblFinal.TabIndex = 2;
            this.lblFinal.Text = "Fecha final";
            this.lblFinal.Visible = false;
            // 
            // lblInicial
            // 
            this.lblInicial.AutoSize = true;
            this.lblInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicial.Location = new System.Drawing.Point(61, 150);
            this.lblInicial.Name = "lblInicial";
            this.lblInicial.Size = new System.Drawing.Size(96, 20);
            this.lblInicial.TabIndex = 1;
            this.lblInicial.Text = "Fecha inicial";
            this.lblInicial.Visible = false;
            // 
            // lblPersona
            // 
            this.lblPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersona.Location = new System.Drawing.Point(62, 26);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(416, 20);
            this.lblPersona.TabIndex = 0;
            this.lblPersona.Text = "Bienvenido a la cancelacion de turnosprofesionalafilia";
            this.lblPersona.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BTNAceptar
            // 
            this.BTNAceptar.Enabled = false;
            this.BTNAceptar.Location = new System.Drawing.Point(102, 363);
            this.BTNAceptar.Name = "BTNAceptar";
            this.BTNAceptar.Size = new System.Drawing.Size(99, 36);
            this.BTNAceptar.TabIndex = 8;
            this.BTNAceptar.Text = "&Aceptar";
            this.BTNAceptar.UseVisualStyleBackColor = true;
            this.BTNAceptar.Click += new System.EventHandler(this.BTNAceptar_Click);
            // 
            // BTNCerrar
            // 
            this.BTNCerrar.Location = new System.Drawing.Point(306, 363);
            this.BTNCerrar.Name = "BTNCerrar";
            this.BTNCerrar.Size = new System.Drawing.Size(99, 36);
            this.BTNCerrar.TabIndex = 9;
            this.BTNCerrar.Text = "&Cerrar";
            this.BTNCerrar.UseVisualStyleBackColor = true;
            this.BTNCerrar.Click += new System.EventHandler(this.BTNCerrar_Click);
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(61, 242);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(165, 20);
            this.lblMotivo.TabIndex = 8;
            this.lblMotivo.Text = "Motivo de cancelacion";
            this.lblMotivo.Visible = false;
            // 
            // TXTMotivo
            // 
            this.TXTMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTMotivo.Location = new System.Drawing.Point(232, 243);
            this.TXTMotivo.MaxLength = 255;
            this.TXTMotivo.Multiline = true;
            this.TXTMotivo.Name = "TXTMotivo";
            this.TXTMotivo.ShortcutsEnabled = false;
            this.TXTMotivo.Size = new System.Drawing.Size(262, 101);
            this.TXTMotivo.TabIndex = 9;
            this.TXTMotivo.Text = "Detalle motivo (Opcional)";
            this.TXTMotivo.Visible = false;
            this.TXTMotivo.Click += new System.EventHandler(this.TXTMotivo_Enter);
            this.TXTMotivo.Enter += new System.EventHandler(this.TXTMotivo_Enter);
            this.TXTMotivo.Leave += new System.EventHandler(this.TXTMotivo_Leave);
            // 
            // CMBFamiliar
            // 
            this.CMBFamiliar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBFamiliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBFamiliar.FormattingEnabled = true;
            this.CMBFamiliar.Location = new System.Drawing.Point(182, 145);
            this.CMBFamiliar.Name = "CMBFamiliar";
            this.CMBFamiliar.Size = new System.Drawing.Size(312, 28);
            this.CMBFamiliar.TabIndex = 10;
            this.CMBFamiliar.Visible = false;
            this.CMBFamiliar.SelectedIndexChanged += new System.EventHandler(this.CMBFamiliar_SelectedIndexChanged);
            // 
            // CHBPersonal
            // 
            this.CHBPersonal.AutoSize = true;
            this.CHBPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHBPersonal.Location = new System.Drawing.Point(149, 88);
            this.CHBPersonal.Name = "CHBPersonal";
            this.CHBPersonal.Size = new System.Drawing.Size(90, 24);
            this.CHBPersonal.TabIndex = 11;
            this.CHBPersonal.Text = "Personal";
            this.CHBPersonal.UseVisualStyleBackColor = true;
            this.CHBPersonal.Visible = false;
            this.CHBPersonal.CheckedChanged += new System.EventHandler(this.CHBPersonal_CheckedChanged);
            // 
            // CHBFamiliar
            // 
            this.CHBFamiliar.AutoSize = true;
            this.CHBFamiliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHBFamiliar.Location = new System.Drawing.Point(306, 88);
            this.CHBFamiliar.Name = "CHBFamiliar";
            this.CHBFamiliar.Size = new System.Drawing.Size(83, 24);
            this.CHBFamiliar.TabIndex = 12;
            this.CHBFamiliar.Text = "Familiar";
            this.CHBFamiliar.UseVisualStyleBackColor = true;
            this.CHBFamiliar.Visible = false;
            this.CHBFamiliar.CheckedChanged += new System.EventHandler(this.CHBFamiliar_CheckedChanged);
            // 
            // CMBTurno
            // 
            this.CMBTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBTurno.Enabled = false;
            this.CMBTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBTurno.FormattingEnabled = true;
            this.CMBTurno.Location = new System.Drawing.Point(182, 179);
            this.CMBTurno.Name = "CMBTurno";
            this.CMBTurno.Size = new System.Drawing.Size(312, 28);
            this.CMBTurno.TabIndex = 13;
            this.CMBTurno.Visible = false;
            // 
            // lblFamiliar
            // 
            this.lblFamiliar.AutoSize = true;
            this.lblFamiliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamiliar.Location = new System.Drawing.Point(62, 148);
            this.lblFamiliar.Name = "lblFamiliar";
            this.lblFamiliar.Size = new System.Drawing.Size(64, 20);
            this.lblFamiliar.TabIndex = 14;
            this.lblFamiliar.Text = "Familiar";
            this.lblFamiliar.Visible = false;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.Location = new System.Drawing.Point(62, 182);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(50, 20);
            this.lblTurno.TabIndex = 15;
            this.lblTurno.Text = "Turno";
            this.lblTurno.Visible = false;
            // 
            // FrmCancelarAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 456);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblFamiliar);
            this.Controls.Add(this.CMBTurno);
            this.Controls.Add(this.CHBFamiliar);
            this.Controls.Add(this.CHBPersonal);
            this.Controls.Add(this.CMBFamiliar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTMotivo);
            this.Controls.Add(this.CHBPeriodo);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.CHBDia);
            this.Controls.Add(this.BTNCerrar);
            this.Controls.Add(this.DTPFin);
            this.Controls.Add(this.DTPInicio);
            this.Controls.Add(this.BTNAceptar);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblPersona);
            this.Controls.Add(this.lblInicial);
            this.MaximizeBox = false;
            this.Name = "FrmCancelarAtencion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CANCELAR ATENCIÓN";
            this.Load += new System.EventHandler(this.FrmCancelarAtencion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CHBPeriodo;
        private System.Windows.Forms.CheckBox CHBDia;
        private System.Windows.Forms.DateTimePicker DTPFin;
        private System.Windows.Forms.DateTimePicker DTPInicio;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblInicial;
        private System.Windows.Forms.Label lblPersona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNAceptar;
        private System.Windows.Forms.Button BTNCerrar;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox TXTMotivo;
        private System.Windows.Forms.ComboBox CMBFamiliar;
        private System.Windows.Forms.CheckBox CHBPersonal;
        private System.Windows.Forms.CheckBox CHBFamiliar;
        private System.Windows.Forms.ComboBox CMBTurno;
        private System.Windows.Forms.Label lblFamiliar;
        private System.Windows.Forms.Label lblTurno;

    }
}