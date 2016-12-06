namespace ClinicaFrba.Abm_Afiliado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNroAfiliado = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.nudFamiliares = new System.Windows.Forms.NumericUpDown();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.chbAsociar = new System.Windows.Forms.CheckBox();
            this.chbAsociarFamiliar = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbPlanMedico = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudFamiliares)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de afiliado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modificaciones de afiliados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estado civil";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 40);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cantidad de hijos/\r\nFamiliares a cargo";
            // 
            // txtNroAfiliado
            // 
            this.txtNroAfiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroAfiliado.Location = new System.Drawing.Point(259, 73);
            this.txtNroAfiliado.MaxLength = 255;
            this.txtNroAfiliado.Name = "txtNroAfiliado";
            this.txtNroAfiliado.ShortcutsEnabled = false;
            this.txtNroAfiliado.Size = new System.Drawing.Size(213, 26);
            this.txtNroAfiliado.TabIndex = 1;
            this.txtNroAfiliado.Text = "Ingrese numero de afiliado";
            this.txtNroAfiliado.Click += new System.EventHandler(this.txtNroAfiliado_Enter);
            this.txtNroAfiliado.Enter += new System.EventHandler(this.txtNroAfiliado_Enter);
            this.txtNroAfiliado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroAfiliado_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(259, 139);
            this.txtDireccion.MaxLength = 255;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ShortcutsEnabled = false;
            this.txtDireccion.Size = new System.Drawing.Size(213, 57);
            this.txtDireccion.TabIndex = 3;
            this.txtDireccion.Click += new System.EventHandler(this.txtDireccion_Enter);
            this.txtDireccion.Enter += new System.EventHandler(this.txtDireccion_Enter);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(259, 204);
            this.txtTelefono.MaxLength = 255;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ShortcutsEnabled = false;
            this.txtTelefono.Size = new System.Drawing.Size(213, 26);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.Click += new System.EventHandler(this.txtTelefono_Enter);
            this.txtTelefono.Enter += new System.EventHandler(this.txtTelefono_Enter);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtMail
            // 
            this.txtMail.Enabled = false;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(259, 240);
            this.txtMail.MaxLength = 255;
            this.txtMail.Name = "txtMail";
            this.txtMail.ShortcutsEnabled = false;
            this.txtMail.Size = new System.Drawing.Size(212, 26);
            this.txtMail.TabIndex = 5;
            this.txtMail.Click += new System.EventHandler(this.txtMail_Enter);
            this.txtMail.Enter += new System.EventHandler(this.txtMail_Enter);
            // 
            // nudFamiliares
            // 
            this.nudFamiliares.Enabled = false;
            this.nudFamiliares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFamiliares.Location = new System.Drawing.Point(259, 432);
            this.nudFamiliares.Name = "nudFamiliares";
            this.nudFamiliares.Size = new System.Drawing.Size(56, 26);
            this.nudFamiliares.TabIndex = 8;
            this.nudFamiliares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudFamiliares.ValueChanged += new System.EventHandler(this.nudFamiliares_ValueChanged);
            // 
            // cmbEstado
            // 
            this.cmbEstado.Enabled = false;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(259, 385);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(213, 28);
            this.cmbEstado.TabIndex = 6;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            this.cmbEstado.Enter += new System.EventHandler(this.cmbEstado_Enter);
            this.cmbEstado.Leave += new System.EventHandler(this.cmbEstado_Leave);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(476, 73);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(77, 27);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "&Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nombre del afiliado";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(260, 109);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(211, 19);
            this.txtNombre.TabIndex = 15;
            // 
            // chbAsociar
            // 
            this.chbAsociar.AutoSize = true;
            this.chbAsociar.Location = new System.Drawing.Point(483, 384);
            this.chbAsociar.Name = "chbAsociar";
            this.chbAsociar.Size = new System.Drawing.Size(61, 30);
            this.chbAsociar.TabIndex = 7;
            this.chbAsociar.Text = "Asociar\r\npareja";
            this.chbAsociar.UseVisualStyleBackColor = true;
            this.chbAsociar.Visible = false;
            // 
            // chbAsociarFamiliar
            // 
            this.chbAsociarFamiliar.AutoSize = true;
            this.chbAsociarFamiliar.Location = new System.Drawing.Point(321, 438);
            this.chbAsociarFamiliar.Name = "chbAsociarFamiliar";
            this.chbAsociarFamiliar.Size = new System.Drawing.Size(61, 17);
            this.chbAsociarFamiliar.TabIndex = 9;
            this.chbAsociarFamiliar.Text = "Asociar";
            this.chbAsociarFamiliar.UseVisualStyleBackColor = true;
            this.chbAsociarFamiliar.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(136, 513);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(88, 27);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(321, 513);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 27);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Plan Medico";
            // 
            // cmbPlanMedico
            // 
            this.cmbPlanMedico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbPlanMedico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPlanMedico.Enabled = false;
            this.cmbPlanMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlanMedico.FormattingEnabled = true;
            this.cmbPlanMedico.Location = new System.Drawing.Point(259, 274);
            this.cmbPlanMedico.Name = "cmbPlanMedico";
            this.cmbPlanMedico.Size = new System.Drawing.Size(213, 28);
            this.cmbPlanMedico.TabIndex = 21;
            this.cmbPlanMedico.SelectedIndexChanged += new System.EventHandler(this.cmbPlanMedico_SelectedIndexChanged);
            this.cmbPlanMedico.Leave += new System.EventHandler(this.cmbPlanMedico_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 40);
            this.label10.TabIndex = 22;
            this.label10.Text = "Detalle razon\r\npor cambio de plan";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Enabled = false;
            this.txtDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalle.Location = new System.Drawing.Point(259, 308);
            this.txtDetalle.MaxLength = 255;
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.ShortcutsEnabled = false;
            this.txtDetalle.Size = new System.Drawing.Size(212, 71);
            this.txtDetalle.TabIndex = 23;
            this.txtDetalle.DoubleClick += new System.EventHandler(this.txtDetalle_Enter);
            this.txtDetalle.Enter += new System.EventHandler(this.txtDetalle_Enter);
            // 
            // FrmBuscarAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 564);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbPlanMedico);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.chbAsociarFamiliar);
            this.Controls.Add(this.chbAsociar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.nudFamiliares);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNroAfiliado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmBuscarAfiliado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MODIFICAR AFILIADO";
            this.Load += new System.EventHandler(this.FrmBuscarAfiliado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFamiliares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNroAfiliado;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.NumericUpDown nudFamiliares;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckBox chbAsociar;
        private System.Windows.Forms.CheckBox chbAsociarFamiliar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbPlanMedico;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDetalle;
    }
}