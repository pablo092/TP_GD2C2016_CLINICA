namespace ClinicaFrba.Pedir_Turno
{
    partial class frmPedidoTurno
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
            this.components = new System.ComponentModel.Container();
            this.lblProfesional = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.cmbProfesional = new System.Windows.Forms.ComboBox();
            this.lblFechasDisponibles = new System.Windows.Forms.Label();
            this.cmbFechasDisponibles = new System.Windows.Forms.ComboBox();
            this.btnAsignarTurno = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblNumeroAfiliado = new System.Windows.Forms.Label();
            this.tbNumeroAfiliado = new System.Windows.Forms.TextBox();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.epNroAfiliadoNull = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epNroAfiliadoNull)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProfesional
            // 
            this.lblProfesional.AutoSize = true;
            this.lblProfesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesional.Location = new System.Drawing.Point(20, 99);
            this.lblProfesional.Name = "lblProfesional";
            this.lblProfesional.Size = new System.Drawing.Size(92, 20);
            this.lblProfesional.TabIndex = 1;
            this.lblProfesional.Text = "Profesional:";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidad.Location = new System.Drawing.Point(20, 60);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(103, 20);
            this.lblEspecialidad.TabIndex = 2;
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // cmbProfesional
            // 
            this.cmbProfesional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfesional.Enabled = false;
            this.cmbProfesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProfesional.FormattingEnabled = true;
            this.cmbProfesional.Location = new System.Drawing.Point(171, 95);
            this.cmbProfesional.Name = "cmbProfesional";
            this.cmbProfesional.Size = new System.Drawing.Size(265, 28);
            this.cmbProfesional.Sorted = true;
            this.cmbProfesional.TabIndex = 3;
            this.cmbProfesional.SelectedIndexChanged += new System.EventHandler(this.cmbProfesional_SelectedIndexChanged);
            // 
            // lblFechasDisponibles
            // 
            this.lblFechasDisponibles.AutoSize = true;
            this.lblFechasDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechasDisponibles.Location = new System.Drawing.Point(20, 138);
            this.lblFechasDisponibles.Name = "lblFechasDisponibles";
            this.lblFechasDisponibles.Size = new System.Drawing.Size(149, 20);
            this.lblFechasDisponibles.TabIndex = 5;
            this.lblFechasDisponibles.Text = "Fechas disponibles:";
            // 
            // cmbFechasDisponibles
            // 
            this.cmbFechasDisponibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFechasDisponibles.Enabled = false;
            this.cmbFechasDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFechasDisponibles.FormattingEnabled = true;
            this.cmbFechasDisponibles.Location = new System.Drawing.Point(171, 134);
            this.cmbFechasDisponibles.Name = "cmbFechasDisponibles";
            this.cmbFechasDisponibles.Size = new System.Drawing.Size(265, 28);
            this.cmbFechasDisponibles.TabIndex = 4;
            this.cmbFechasDisponibles.SelectedIndexChanged += new System.EventHandler(this.cmbFechasDisponibles_SelectedIndexChanged);
            // 
            // btnAsignarTurno
            // 
            this.btnAsignarTurno.Enabled = false;
            this.btnAsignarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarTurno.Location = new System.Drawing.Point(209, 215);
            this.btnAsignarTurno.Name = "btnAsignarTurno";
            this.btnAsignarTurno.Size = new System.Drawing.Size(93, 31);
            this.btnAsignarTurno.TabIndex = 5;
            this.btnAsignarTurno.Text = "&Asignar turno";
            this.btnAsignarTurno.UseVisualStyleBackColor = true;
            this.btnAsignarTurno.Click += new System.EventHandler(this.btnAsignarTurno_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(308, 215);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(87, 31);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblNumeroAfiliado
            // 
            this.lblNumeroAfiliado.AutoSize = true;
            this.lblNumeroAfiliado.CausesValidation = false;
            this.lblNumeroAfiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroAfiliado.Location = new System.Drawing.Point(20, 22);
            this.lblNumeroAfiliado.Name = "lblNumeroAfiliado";
            this.lblNumeroAfiliado.Size = new System.Drawing.Size(145, 20);
            this.lblNumeroAfiliado.TabIndex = 10;
            this.lblNumeroAfiliado.Text = "Numero de afiliado:";
            // 
            // tbNumeroAfiliado
            // 
            this.tbNumeroAfiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumeroAfiliado.Location = new System.Drawing.Point(171, 19);
            this.tbNumeroAfiliado.MaxLength = 15;
            this.tbNumeroAfiliado.Name = "tbNumeroAfiliado";
            this.tbNumeroAfiliado.Size = new System.Drawing.Size(175, 26);
            this.tbNumeroAfiliado.TabIndex = 1;
            this.tbNumeroAfiliado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeroAfiliado_KeyPress);
            this.tbNumeroAfiliado.Validated += new System.EventHandler(this.tbNumeroAfiliado_Validated);
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(171, 56);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(265, 28);
            this.cmbEspecialidad.Sorted = true;
            this.cmbEspecialidad.TabIndex = 2;
            this.cmbEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidad_SelectedIndexChanged);
            // 
            // epNroAfiliadoNull
            // 
            this.epNroAfiliadoNull.ContainerControl = this;
            // 
            // frmPedidoTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 258);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.tbNumeroAfiliado);
            this.Controls.Add(this.lblNumeroAfiliado);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAsignarTurno);
            this.Controls.Add(this.cmbFechasDisponibles);
            this.Controls.Add(this.lblFechasDisponibles);
            this.Controls.Add(this.cmbProfesional);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.lblProfesional);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPedidoTurno";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PEDIDO DE TURNO";
            this.Load += new System.EventHandler(this.FrmPedidoTurno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epNroAfiliadoNull)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfesional;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.ComboBox cmbProfesional;
        private System.Windows.Forms.Label lblFechasDisponibles;
        private System.Windows.Forms.ComboBox cmbFechasDisponibles;
        private System.Windows.Forms.Button btnAsignarTurno;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblNumeroAfiliado;
        private System.Windows.Forms.TextBox tbNumeroAfiliado;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.ErrorProvider epNroAfiliadoNull;
    }
}