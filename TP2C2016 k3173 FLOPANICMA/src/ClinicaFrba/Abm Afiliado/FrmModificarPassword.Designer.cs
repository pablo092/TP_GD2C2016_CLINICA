namespace ClinicaFrba.ABM_Afiliado
{
    partial class FrmModificarPassword
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbDatosUsuario = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPasswordConfirmacionNueva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPasswordNueva = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPasswordActual = new System.Windows.Forms.TextBox();
            this.gbDatosUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(228, 135);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(147, 135);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gbDatosUsuario
            // 
            this.gbDatosUsuario.Controls.Add(this.label3);
            this.gbDatosUsuario.Controls.Add(this.txtPasswordConfirmacionNueva);
            this.gbDatosUsuario.Controls.Add(this.label1);
            this.gbDatosUsuario.Controls.Add(this.txtPasswordNueva);
            this.gbDatosUsuario.Controls.Add(this.lblPassword);
            this.gbDatosUsuario.Controls.Add(this.txtPasswordActual);
            this.gbDatosUsuario.Location = new System.Drawing.Point(12, 12);
            this.gbDatosUsuario.Name = "gbDatosUsuario";
            this.gbDatosUsuario.Size = new System.Drawing.Size(397, 117);
            this.gbDatosUsuario.TabIndex = 20;
            this.gbDatosUsuario.TabStop = false;
            this.gbDatosUsuario.Text = "Datos Usuario";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(27, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "CONFIRMAR PASSWORD NUEVA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPasswordConfirmacionNueva
            // 
            this.txtPasswordConfirmacionNueva.Location = new System.Drawing.Point(216, 71);
            this.txtPasswordConfirmacionNueva.Name = "txtPasswordConfirmacionNueva";
            this.txtPasswordConfirmacionNueva.Size = new System.Drawing.Size(155, 20);
            this.txtPasswordConfirmacionNueva.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(71, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "NUEVA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPasswordNueva
            // 
            this.txtPasswordNueva.Location = new System.Drawing.Point(216, 45);
            this.txtPasswordNueva.Name = "txtPasswordNueva";
            this.txtPasswordNueva.Size = new System.Drawing.Size(155, 20);
            this.txtPasswordNueva.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(71, 20);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(139, 17);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "ACTUAL";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPasswordActual
            // 
            this.txtPasswordActual.Location = new System.Drawing.Point(216, 19);
            this.txtPasswordActual.Name = "txtPasswordActual";
            this.txtPasswordActual.Size = new System.Drawing.Size(155, 20);
            this.txtPasswordActual.TabIndex = 2;
            // 
            // FrmModificarPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 168);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbDatosUsuario);
            this.MaximumSize = new System.Drawing.Size(437, 207);
            this.MinimumSize = new System.Drawing.Size(437, 207);
            this.Name = "FrmModificarPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAMBIAR PASSWORD";
            this.gbDatosUsuario.ResumeLayout(false);
            this.gbDatosUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbDatosUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPasswordActual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPasswordConfirmacionNueva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPasswordNueva;

    }
}