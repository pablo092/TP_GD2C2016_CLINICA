namespace ClinicaFrba
{
    partial class FrmMenu
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
            this.mnPrincipal = new System.Windows.Forms.MenuStrip();
            this.btnMenuRol = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuRolBusqueda = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuRolAlta = new System.Windows.Forms.ToolStripMenuItem();

            this.btnMenuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuUsuarioBusqueda = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuUsuarioAlta = new System.Windows.Forms.ToolStripMenuItem();

            this.btnMenuRubro = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuRubroBusqueda = new System.Windows.Forms.ToolStripMenuItem();

            this.btnMenuVisibilidad = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuVisibilidadBusqueda = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuVisibilidadAlta = new System.Windows.Forms.ToolStripMenuItem();

            this.btnMenuPublicaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuPublicacionesGenerar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuPublicacionesMisPublicaciones = new System.Windows.Forms.ToolStripMenuItem();

            this.btnMenuOfertar = new System.Windows.Forms.ToolStripMenuItem();

            this.btnMenuHistorialCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.vERHISTORIALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.btnMenuCalificarVendedor = new System.Windows.Forms.ToolStripMenuItem();
            this.cALIFICARCOMPRAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.btnMenuFacturasVendedor = new System.Windows.Forms.ToolStripMenuItem();
            this.bUSCARFACTURASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.btnMenuListadoEstadistico = new System.Windows.Forms.ToolStripMenuItem();
            this.vERESTADISTICASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.btnMenuCliente = new System.Windows.Forms.ToolStripMenuItem();

            this.btnMenuEmpresa = new System.Windows.Forms.ToolStripMenuItem();

            this.btnCambiarPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnPrincipal
            // 
            this.mnPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.btnMenuRol,
                                                                                    this.btnMenuUsuario,
                                                                                    this.btnMenuRubro,
                                                                                    this.btnMenuVisibilidad,
                                                                                    this.btnMenuPublicaciones,
                                                                                    this.btnMenuOfertar,
                                                                                    this.btnMenuHistorialCliente,
                                                                                    this.btnMenuCalificarVendedor,
                                                                                    this.btnMenuFacturasVendedor,
                                                                                    this.btnMenuListadoEstadistico,
                                                                                    this.btnCambiarPassword});
            this.mnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnPrincipal.Name = "mnPrincipal";
            this.mnPrincipal.Size = new System.Drawing.Size(1208, 24);
            this.mnPrincipal.TabIndex = 0;
            this.mnPrincipal.Text = "Menú Principal";
            // 
            // btnMenuRol
            // 
            this.btnMenuRol.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.btnMenuRolBusqueda, this.btnMenuRolAlta});
            this.btnMenuRol.Name = "btnMenuRol";
            this.btnMenuRol.Size = new System.Drawing.Size(41, 20);
            this.btnMenuRol.Text = "ROL";
            // 
            // btnMenuRolBusqueda
            // 
            this.btnMenuRolBusqueda.Name = "btnMenuRolBusqueda";
            this.btnMenuRolBusqueda.Size = new System.Drawing.Size(168, 22);
            this.btnMenuRolBusqueda.Text = "BUSCAR / EDITAR";
            this.btnMenuRolBusqueda.Click += new System.EventHandler(this.btnMenuRolBusqueda_Click);
            // 
            // btnMenuRolAlta
            // 
            this.btnMenuRolAlta.Name = "btnMenuRolAlta";
            this.btnMenuRolAlta.Size = new System.Drawing.Size(168, 22);
            this.btnMenuRolAlta.Text = "INGRESAR";
            this.btnMenuRolAlta.Click += new System.EventHandler(this.btnMenuRolAlta_Click);
            // 
            // btnMenuUsuario
            // 
            this.btnMenuUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuUsuarioBusqueda,
            this.btnMenuUsuarioAlta,
            this.btnMenuCliente,
            this.btnMenuEmpresa});
            this.btnMenuUsuario.Name = "btnMenuUsuario";
            this.btnMenuUsuario.Size = new System.Drawing.Size(68, 20);
            this.btnMenuUsuario.Text = "USUARIO";
            // 
            // btnMenuUsuarioBusqueda
            // 
            this.btnMenuUsuarioBusqueda.Name = "btnMenuUsuarioBusqueda";
            this.btnMenuUsuarioBusqueda.Size = new System.Drawing.Size(222, 22);
            this.btnMenuUsuarioBusqueda.Text = "BUSCAR / EDITAR USUARIO";
            //this.btnMenuUsuarioBusqueda.Click += new System.EventHandler(this.btnMenuUsuarioBusqueda_Click);
            // 
            // btnMenuUsuarioAlta
            // 
            this.btnMenuUsuarioAlta.Name = "btnMenuUsuarioAlta";
            this.btnMenuUsuarioAlta.Size = new System.Drawing.Size(222, 22);
            this.btnMenuUsuarioAlta.Text = "INGRESAR USUARIO";
            //this.btnMenuUsuarioAlta.Click += new System.EventHandler(this.btnMenuUsuarioAlta_Click);
            // 
            // btnMenuRubro
            // 
            this.btnMenuRubro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuRubroBusqueda});
            this.btnMenuRubro.Name = "btnMenuRubro";
            this.btnMenuRubro.Size = new System.Drawing.Size(57, 20);
            this.btnMenuRubro.Text = "RUBRO";
            // 
            // btnMenuRubroBusqueda
            // 
            this.btnMenuRubroBusqueda.Name = "btnMenuRubroBusqueda";
            this.btnMenuRubroBusqueda.Size = new System.Drawing.Size(168, 22);
            this.btnMenuRubroBusqueda.Text = "LISTADO RUBROS";
            //this.btnMenuRubroBusqueda.Click += new System.EventHandler(this.btnMenuRubroBusqueda_Click);
            // 
            // btnMenuVisibilidad
            // 
            this.btnMenuVisibilidad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuVisibilidadBusqueda,
            this.btnMenuVisibilidadAlta});
            this.btnMenuVisibilidad.Name = "btnMenuVisibilidad";
            this.btnMenuVisibilidad.Size = new System.Drawing.Size(81, 20);
            this.btnMenuVisibilidad.Text = "VISIBILIDAD";
            // 
            // btnMenuVisibilidadBusqueda
            // 
            this.btnMenuVisibilidadBusqueda.Name = "btnMenuVisibilidadBusqueda";
            this.btnMenuVisibilidadBusqueda.Size = new System.Drawing.Size(168, 22);
            this.btnMenuVisibilidadBusqueda.Text = "BUSCAR / EDITAR";
            //this.btnMenuVisibilidadBusqueda.Click += new System.EventHandler(this.btnMenuVisibilidadBusqueda_Click);
            // 
            // btnMenuVisibilidadAlta
            // 
            this.btnMenuVisibilidadAlta.Name = "btnMenuVisibilidadAlta";
            this.btnMenuVisibilidadAlta.Size = new System.Drawing.Size(168, 22);
            this.btnMenuVisibilidadAlta.Text = "INGRESAR";
            //this.btnMenuVisibilidadAlta.Click += new System.EventHandler(this.btnMenuVisibilidadAlta_Click);
            // 
            // btnMenuPublicaciones
            // 
            this.btnMenuPublicaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuPublicacionesGenerar,
            this.btnMenuPublicacionesMisPublicaciones});
            this.btnMenuPublicaciones.Name = "btnMenuPublicaciones";
            this.btnMenuPublicaciones.Size = new System.Drawing.Size(107, 20);
            this.btnMenuPublicaciones.Text = "PUBLICACIONES";
            // 
            // btnMenuPublicacionesGenerar
            // 
            this.btnMenuPublicacionesGenerar.Name = "btnMenuPublicacionesGenerar";
            this.btnMenuPublicacionesGenerar.Size = new System.Drawing.Size(191, 22);
            this.btnMenuPublicacionesGenerar.Text = "NUEVA PUBLICACION";
            //this.btnMenuPublicacionesGenerar.Click += new System.EventHandler(this.btnMenuPublicacionesGenerar_Click);
            // 
            // btnMenuPublicacionesMisPublicaciones
            // 
            this.btnMenuPublicacionesMisPublicaciones.Name = "btnMenuPublicacionesMisPublicaciones";
            this.btnMenuPublicacionesMisPublicaciones.Size = new System.Drawing.Size(191, 22);
            this.btnMenuPublicacionesMisPublicaciones.Text = "MIS PUBLICACIONES";
            //this.btnMenuPublicacionesMisPublicaciones.Click += new System.EventHandler(this.btnMenuPublicacionesMisPublicaciones_Click);
            // 
            // btnMenuOfertar
            // 
            this.btnMenuOfertar.Name = "btnMenuOfertar";
            this.btnMenuOfertar.Size = new System.Drawing.Size(137, 20);
            this.btnMenuOfertar.Text = "COMPRAR / OFERTAR";
            //this.btnMenuOfertar.Click += new System.EventHandler(this.btnMenuOfertar_Click);
            // 
            // btnMenuHistorialCliente
            // 
            this.btnMenuHistorialCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vERHISTORIALToolStripMenuItem});
            this.btnMenuHistorialCliente.Name = "btnMenuHistorialCliente";
            this.btnMenuHistorialCliente.Size = new System.Drawing.Size(77, 20);
            this.btnMenuHistorialCliente.Text = "HISTORIAL";
            // 
            // vERHISTORIALToolStripMenuItem
            // 
            this.vERHISTORIALToolStripMenuItem.Name = "vERHISTORIALToolStripMenuItem";
            this.vERHISTORIALToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.vERHISTORIALToolStripMenuItem.Text = "VER HISTORIAL";
            //this.vERHISTORIALToolStripMenuItem.Click += new System.EventHandler(this.vERHISTORIALToolStripMenuItem_Click);
            // 
            // btnMenuCalificarVendedor
            // 
            this.btnMenuCalificarVendedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cALIFICARCOMPRAToolStripMenuItem});
            this.btnMenuCalificarVendedor.Name = "btnMenuCalificarVendedor";
            this.btnMenuCalificarVendedor.Size = new System.Drawing.Size(76, 20);
            this.btnMenuCalificarVendedor.Text = "CALIFICAR";
            // 
            // cALIFICARCOMPRAToolStripMenuItem
            // 
            this.cALIFICARCOMPRAToolStripMenuItem.Name = "cALIFICARCOMPRAToolStripMenuItem";
            this.cALIFICARCOMPRAToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cALIFICARCOMPRAToolStripMenuItem.Text = "CALIFICAR COMPRA";
            //this.cALIFICARCOMPRAToolStripMenuItem.Click += new System.EventHandler(this.cALIFICARCOMPRAToolStripMenuItem_Click);
            // 
            // btnMenuFacturasVendedor
            // 
            this.btnMenuFacturasVendedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bUSCARFACTURASToolStripMenuItem});
            this.btnMenuFacturasVendedor.Name = "btnMenuFacturasVendedor";
            this.btnMenuFacturasVendedor.Size = new System.Drawing.Size(147, 20);
            this.btnMenuFacturasVendedor.Text = "FACTURAS REALIZADAS";
            // 
            // bUSCARFACTURASToolStripMenuItem
            // 
            this.bUSCARFACTURASToolStripMenuItem.Name = "bUSCARFACTURASToolStripMenuItem";
            this.bUSCARFACTURASToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.bUSCARFACTURASToolStripMenuItem.Text = "BUSCAR FACTURAS";
            //this.bUSCARFACTURASToolStripMenuItem.Click += new System.EventHandler(this.bUSCARFACTURASToolStripMenuItem_Click);
            // 
            // btnMenuListadoEstadistico
            // 
            this.btnMenuListadoEstadistico.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vERESTADISTICASToolStripMenuItem});
            this.btnMenuListadoEstadistico.Name = "btnMenuListadoEstadistico";
            this.btnMenuListadoEstadistico.Size = new System.Drawing.Size(140, 20);
            this.btnMenuListadoEstadistico.Text = "LISTADO ESTADISTICO";
            // 
            // vERESTADISTICASToolStripMenuItem
            // 
            this.vERESTADISTICASToolStripMenuItem.Name = "vERESTADISTICASToolStripMenuItem";
            this.vERESTADISTICASToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.vERESTADISTICASToolStripMenuItem.Text = "VER ESTADISTICAS";
            //this.vERESTADISTICASToolStripMenuItem.Click += new System.EventHandler(this.vERESTADISTICASToolStripMenuItem_Click);
            // 
            // btnMenuCliente
            // 
            this.btnMenuCliente.Name = "btnMenuCliente";
            this.btnMenuCliente.Size = new System.Drawing.Size(222, 22);
            this.btnMenuCliente.Text = "BUSCAR / EDITAR CLIENTE";
            //this.btnMenuCliente.Click += new System.EventHandler(this.bUSCAREDITARCLIENTEToolStripMenuItem_Click);
            // 
            // btnMenuEmpresa
            // 
            this.btnMenuEmpresa.Name = "btnMenuEmpresa";
            this.btnMenuEmpresa.Size = new System.Drawing.Size(222, 22);
            this.btnMenuEmpresa.Text = "BUSCAR / EDITAR EMPRESA";
            //this.btnMenuEmpresa.Click += new System.EventHandler(this.bUSCAREDITAREMPRESAToolStripMenuItem_Click);
            // 
            // btnCambiarPassword
            // 
            this.btnCambiarPassword.Name = "btnCambiarPassword";
            this.btnCambiarPassword.Size = new System.Drawing.Size(136, 20);
            this.btnCambiarPassword.Text = "CAMBIAR PASSWORD";
            //this.btnCambiarPassword.Click += new System.EventHandler(this.btnCambiarPassword_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1208, 262);
            this.Controls.Add(this.mnPrincipal);
            this.MainMenuStrip = this.mnPrincipal;
            this.Name = "FrmPrincipal";
            this.Text = "Formulario Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.mnPrincipal.ResumeLayout(false);
            this.mnPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnPrincipal;
        private System.Windows.Forms.ToolStripMenuItem btnMenuRol;
        private System.Windows.Forms.ToolStripMenuItem btnMenuVisibilidad;
        private System.Windows.Forms.ToolStripMenuItem btnMenuUsuario;
        private System.Windows.Forms.ToolStripMenuItem btnMenuRolAlta;
        private System.Windows.Forms.ToolStripMenuItem btnMenuRolBusqueda;
        private System.Windows.Forms.ToolStripMenuItem btnMenuVisibilidadAlta;
        private System.Windows.Forms.ToolStripMenuItem btnMenuVisibilidadBusqueda;
        private System.Windows.Forms.ToolStripMenuItem btnMenuUsuarioAlta;
        private System.Windows.Forms.ToolStripMenuItem btnMenuUsuarioBusqueda;
        private System.Windows.Forms.ToolStripMenuItem btnMenuRubro;
        private System.Windows.Forms.ToolStripMenuItem btnMenuRubroBusqueda;
        private System.Windows.Forms.ToolStripMenuItem btnMenuPublicaciones;
        private System.Windows.Forms.ToolStripMenuItem btnMenuPublicacionesGenerar;
        private System.Windows.Forms.ToolStripMenuItem btnMenuHistorialCliente;
        private System.Windows.Forms.ToolStripMenuItem btnMenuCalificarVendedor;
        private System.Windows.Forms.ToolStripMenuItem btnMenuListadoEstadistico;
        private System.Windows.Forms.ToolStripMenuItem btnMenuOfertar;
        private System.Windows.Forms.ToolStripMenuItem btnMenuFacturasVendedor;
        private System.Windows.Forms.ToolStripMenuItem btnMenuPublicacionesMisPublicaciones;
        private System.Windows.Forms.ToolStripMenuItem vERHISTORIALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cALIFICARCOMPRAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bUSCARFACTURASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vERESTADISTICASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnMenuCliente;
        private System.Windows.Forms.ToolStripMenuItem btnMenuEmpresa;
        private System.Windows.Forms.ToolStripMenuItem btnCambiarPassword;
    }
}