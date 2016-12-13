namespace ClinicaFrba.ABM_Rol
{
    partial class FrmCrearRol
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
            this.checkFuncionalidades = new System.Windows.Forms.CheckedListBox();
            this.lblRolFuncionalidades = new System.Windows.Forms.Label();
            this.txtRolNombre = new System.Windows.Forms.TextBox();
            this.lblRolNombre = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.msgCreacion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkFuncionalidades);
            this.groupBox1.Controls.Add(this.lblRolFuncionalidades);
            this.groupBox1.Controls.Add(this.txtRolNombre);
            this.groupBox1.Controls.Add(this.lblRolNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Campos del Rol";
            // 
            // checkFuncionalidades
            // 
            this.checkFuncionalidades.FormattingEnabled = true;
            this.checkFuncionalidades.Location = new System.Drawing.Point(6, 95);
            this.checkFuncionalidades.Name = "checkFuncionalidades";
            this.checkFuncionalidades.Size = new System.Drawing.Size(323, 154);
            this.checkFuncionalidades.TabIndex = 5;
            // 
            // lblRolFuncionalidades
            // 
            this.lblRolFuncionalidades.AutoSize = true;
            this.lblRolFuncionalidades.Location = new System.Drawing.Point(6, 68);
            this.lblRolFuncionalidades.Name = "lblRolFuncionalidades";
            this.lblRolFuncionalidades.Size = new System.Drawing.Size(108, 13);
            this.lblRolFuncionalidades.TabIndex = 4;
            this.lblRolFuncionalidades.Text = "FUNCIONALIDADES";
            // 
            // txtRolNombre
            // 
            this.txtRolNombre.Location = new System.Drawing.Point(165, 31);
            this.txtRolNombre.MaxLength = 50;
            this.txtRolNombre.Name = "txtRolNombre";
            this.txtRolNombre.ShortcutsEnabled = false;
            this.txtRolNombre.Size = new System.Drawing.Size(153, 20);
            this.txtRolNombre.TabIndex = 3;
            this.txtRolNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRolNombre_KeyPress);
            // 
            // lblRolNombre
            // 
            this.lblRolNombre.AutoSize = true;
            this.lblRolNombre.Location = new System.Drawing.Point(6, 34);
            this.lblRolNombre.Name = "lblRolNombre";
            this.lblRolNombre.Size = new System.Drawing.Size(54, 13);
            this.lblRolNombre.TabIndex = 2;
            this.lblRolNombre.Text = "NOMBRE";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(266, 274);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 274);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msgCreacion,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 306);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(359, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // msgCreacion
            // 
            this.msgCreacion.Name = "msgCreacion";
            this.msgCreacion.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Visible = false;
            // 
            // FrmCrearRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 328);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(375, 367);
            this.MinimumSize = new System.Drawing.Size(375, 367);
            this.Name = "FrmCrearRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INGRESAR ROL";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRolNombre;
        private System.Windows.Forms.Label lblRolFuncionalidades;
        private System.Windows.Forms.TextBox txtRolNombre;
        private System.Windows.Forms.CheckedListBox checkFuncionalidades;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel msgCreacion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}