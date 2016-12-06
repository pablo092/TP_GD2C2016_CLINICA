using ClinicaFrba.DAO;
using ClinicaFrba.DTO;
namespace ClinicaFrba.Abm_Profesional
{
    partial class FrmABMProfesional
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private TipoEspecialidadDAO ted = new TipoEspecialidadDAO();

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
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelDocumento = new System.Windows.Forms.Label();
            this.comboBoxDNI = new System.Windows.Forms.ComboBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.labelEspecialidad = new System.Windows.Forms.Label();
            this.labelFecNac = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.dateTimePickerNac = new System.Windows.Forms.DateTimePicker();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.checkedListBoxEspecialidades = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(249, 474);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(139, 34);
            this.buttonGuardar.TabIndex = 0;
            this.buttonGuardar.Text = "&Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(217, 45);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(225, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(217, 82);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(225, 20);
            this.textBoxApellido.TabIndex = 2;
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(299, 124);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(143, 20);
            this.textBoxDNI.TabIndex = 3;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(217, 162);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(225, 20);
            this.textBoxDireccion.TabIndex = 4;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(217, 203);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(225, 20);
            this.textBoxTelefono.TabIndex = 5;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(49, 45);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 6;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(49, 82);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(47, 13);
            this.labelApellido.TabIndex = 7;
            this.labelApellido.Text = "Apellido:";
            // 
            // labelDocumento
            // 
            this.labelDocumento.AutoSize = true;
            this.labelDocumento.Location = new System.Drawing.Point(49, 124);
            this.labelDocumento.Name = "labelDocumento";
            this.labelDocumento.Size = new System.Drawing.Size(88, 13);
            this.labelDocumento.TabIndex = 8;
            this.labelDocumento.Text = "Nro. Documento:";
            // 
            // comboBoxDNI
            // 
            this.comboBoxDNI.FormattingEnabled = true;
            this.comboBoxDNI.Location = new System.Drawing.Point(217, 122);
            this.comboBoxDNI.Name = "comboBoxDNI";
            this.comboBoxDNI.Size = new System.Drawing.Size(76, 21);
            this.comboBoxDNI.TabIndex = 9;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(49, 162);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(55, 13);
            this.labelDireccion.TabIndex = 10;
            this.labelDireccion.Text = "Dirección:";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(49, 203);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(52, 13);
            this.labelTelefono.TabIndex = 11;
            this.labelTelefono.Text = "Teléfono:";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(217, 241);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(225, 20);
            this.textBoxMail.TabIndex = 12;
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(217, 335);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(225, 20);
            this.textBoxMatricula.TabIndex = 13;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(52, 241);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(29, 13);
            this.labelMail.TabIndex = 15;
            this.labelMail.Text = "Mail:";
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.Location = new System.Drawing.Point(49, 335);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(55, 13);
            this.labelMatricula.TabIndex = 16;
            this.labelMatricula.Text = "Matrícula:";
            // 
            // labelEspecialidad
            // 
            this.labelEspecialidad.AutoSize = true;
            this.labelEspecialidad.Location = new System.Drawing.Point(49, 371);
            this.labelEspecialidad.Name = "labelEspecialidad";
            this.labelEspecialidad.Size = new System.Drawing.Size(70, 13);
            this.labelEspecialidad.TabIndex = 17;
            this.labelEspecialidad.Text = "Especialidad:";
            // 
            // labelFecNac
            // 
            this.labelFecNac.AutoSize = true;
            this.labelFecNac.Location = new System.Drawing.Point(49, 273);
            this.labelFecNac.Name = "labelFecNac";
            this.labelFecNac.Size = new System.Drawing.Size(111, 13);
            this.labelFecNac.TabIndex = 18;
            this.labelFecNac.Text = "Fecha de Nacimiento:";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(49, 304);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(34, 13);
            this.labelSexo.TabIndex = 19;
            this.labelSexo.Text = "Sexo:";
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Location = new System.Drawing.Point(217, 304);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSexo.TabIndex = 20;
            // 
            // dateTimePickerNac
            // 
            this.dateTimePickerNac.Location = new System.Drawing.Point(217, 273);
            this.dateTimePickerNac.Name = "dateTimePickerNac";
            this.dateTimePickerNac.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerNac.TabIndex = 21;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(394, 474);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(139, 34);
            this.buttonCancelar.TabIndex = 23;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // checkedListBoxEspecialidades
            // 
            this.checkedListBoxEspecialidades.FormattingEnabled = true;
            this.checkedListBoxEspecialidades.Location = new System.Drawing.Point(217, 374);
            this.checkedListBoxEspecialidades.Name = "checkedListBoxEspecialidades";
            this.checkedListBoxEspecialidades.Size = new System.Drawing.Size(224, 94);
            this.checkedListBoxEspecialidades.TabIndex = 24;
            // 
            // FrmABMProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 520);
            this.Controls.Add(this.checkedListBoxEspecialidades);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.dateTimePickerNac);
            this.Controls.Add(this.comboBoxSexo);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.labelFecNac);
            this.Controls.Add(this.labelEspecialidad);
            this.Controls.Add(this.labelMatricula);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.textBoxMatricula);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.comboBoxDNI);
            this.Controls.Add(this.labelDocumento);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.buttonGuardar);
            this.MaximizeBox = false;
            this.Name = "FrmABMProfesional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "REGISTRAR PROFESIONAL";
            this.Load += new System.EventHandler(this.FrmABMProfesional_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelDocumento;
        private System.Windows.Forms.ComboBox comboBoxDNI;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.Label labelEspecialidad;
        private System.Windows.Forms.Label labelFecNac;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.ComboBox comboBoxSexo;
        private System.Windows.Forms.DateTimePicker dateTimePickerNac;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.CheckedListBox checkedListBoxEspecialidades;
    }
}