﻿namespace ClinicaFrba
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
            this.btnMenuAbm = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuRol = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuRolBusqueda = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuRolAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuAfiliado = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuAfiliadoBusqueda = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuAfiliadoAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.aSOCIARAFILIADOSEXISTENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuProfesional = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuProfesionalAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuEspecialidadesMedicas = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuEspecialidadesMedicasBusqueda = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuPlanBusqueda = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuRegistrarAgenda = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuRegistrarLlegadaAM = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuRegistrarResultadoAM = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuComprarBono = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuPedidoTurno = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuCancelarAtencion = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuListadoEstadistico = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModifPlanes = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCambiarPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.mnPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnPrincipal
            // 
            this.mnPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuAbm,
            this.btnMenuRegistrar,
            this.btnMenuComprarBono,
            this.btnMenuPedidoTurno,
            this.btnMenuCancelarAtencion,
            this.btnMenuListadoEstadistico,
            this.btnModifPlanes,
            this.btnCambiarPassword});
            this.mnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnPrincipal.Name = "mnPrincipal";
            this.mnPrincipal.Size = new System.Drawing.Size(944, 24);
            this.mnPrincipal.TabIndex = 0;
            this.mnPrincipal.Text = "Menú Principal";
            // 
            // btnMenuAbm
            // 
            this.btnMenuAbm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuRol,
            this.btnMenuAfiliado,
            this.btnMenuProfesional,
            this.btnMenuEspecialidadesMedicas,
            this.btnMenuPlan});
            this.btnMenuAbm.Name = "btnMenuAbm";
            this.btnMenuAbm.Size = new System.Drawing.Size(45, 20);
            this.btnMenuAbm.Text = "ABM";
            // 
            // btnMenuRol
            // 
            this.btnMenuRol.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuRolBusqueda,
            this.btnMenuRolAlta});
            this.btnMenuRol.Name = "btnMenuRol";
            this.btnMenuRol.Size = new System.Drawing.Size(216, 22);
            this.btnMenuRol.Text = "ROL";
            // 
            // btnMenuRolBusqueda
            // 
            this.btnMenuRolBusqueda.Name = "btnMenuRolBusqueda";
            this.btnMenuRolBusqueda.Size = new System.Drawing.Size(167, 22);
            this.btnMenuRolBusqueda.Text = "BUSCAR / EDITAR";
            this.btnMenuRolBusqueda.Click += new System.EventHandler(this.btnMenuRolBusqueda_Click);
            // 
            // btnMenuRolAlta
            // 
            this.btnMenuRolAlta.Name = "btnMenuRolAlta";
            this.btnMenuRolAlta.Size = new System.Drawing.Size(167, 22);
            this.btnMenuRolAlta.Text = "INGRESAR";
            this.btnMenuRolAlta.Click += new System.EventHandler(this.btnMenuRolAlta_Click);
            // 
            // btnMenuAfiliado
            // 
            this.btnMenuAfiliado.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuAfiliadoBusqueda,
            this.btnMenuAfiliadoAlta,
            this.aSOCIARAFILIADOSEXISTENTESToolStripMenuItem});
            this.btnMenuAfiliado.Name = "btnMenuAfiliado";
            this.btnMenuAfiliado.Size = new System.Drawing.Size(216, 22);
            this.btnMenuAfiliado.Text = "AFILIADO";
            // 
            // btnMenuAfiliadoBusqueda
            // 
            this.btnMenuAfiliadoBusqueda.Name = "btnMenuAfiliadoBusqueda";
            this.btnMenuAfiliadoBusqueda.Size = new System.Drawing.Size(249, 22);
            this.btnMenuAfiliadoBusqueda.Text = "BUSCAR / EDITAR AFILIADO";
            this.btnMenuAfiliadoBusqueda.Click += new System.EventHandler(this.btnMenuAfiliadoBusqueda_Click);
            // 
            // btnMenuAfiliadoAlta
            // 
            this.btnMenuAfiliadoAlta.Name = "btnMenuAfiliadoAlta";
            this.btnMenuAfiliadoAlta.Size = new System.Drawing.Size(249, 22);
            this.btnMenuAfiliadoAlta.Text = "INGRESAR AFILIADO";
            this.btnMenuAfiliadoAlta.Click += new System.EventHandler(this.btnMenuAfiliadoAlta_Click);
            // 
            // aSOCIARAFILIADOSEXISTENTESToolStripMenuItem
            // 
            this.aSOCIARAFILIADOSEXISTENTESToolStripMenuItem.Name = "aSOCIARAFILIADOSEXISTENTESToolStripMenuItem";
            this.aSOCIARAFILIADOSEXISTENTESToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.aSOCIARAFILIADOSEXISTENTESToolStripMenuItem.Text = "ASOCIAR AFILIADOS EXISTENTES";
            this.aSOCIARAFILIADOSEXISTENTESToolStripMenuItem.Click += new System.EventHandler(this.aSOCIARAFILIADOSEXISTENTESToolStripMenuItem_Click);
            // 
            // btnMenuProfesional
            // 
            this.btnMenuProfesional.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuProfesionalAlta});
            this.btnMenuProfesional.Name = "btnMenuProfesional";
            this.btnMenuProfesional.Size = new System.Drawing.Size(216, 22);
            this.btnMenuProfesional.Text = "PROFESIONAL";
            // 
            // btnMenuProfesionalAlta
            // 
            this.btnMenuProfesionalAlta.Name = "btnMenuProfesionalAlta";
            this.btnMenuProfesionalAlta.Size = new System.Drawing.Size(207, 22);
            this.btnMenuProfesionalAlta.Text = "INGRESAR PROFESIONAL";
            this.btnMenuProfesionalAlta.Click += new System.EventHandler(this.btnMenuProfesionalAlta_Click);
            // 
            // btnMenuEspecialidadesMedicas
            // 
            this.btnMenuEspecialidadesMedicas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuEspecialidadesMedicasBusqueda});
            this.btnMenuEspecialidadesMedicas.Name = "btnMenuEspecialidadesMedicas";
            this.btnMenuEspecialidadesMedicas.Size = new System.Drawing.Size(216, 22);
            this.btnMenuEspecialidadesMedicas.Text = "ESPECIALIDADES MÉDICAS";
            // 
            // btnMenuEspecialidadesMedicasBusqueda
            // 
            this.btnMenuEspecialidadesMedicasBusqueda.Name = "btnMenuEspecialidadesMedicasBusqueda";
            this.btnMenuEspecialidadesMedicasBusqueda.Size = new System.Drawing.Size(282, 22);
            this.btnMenuEspecialidadesMedicasBusqueda.Text = "LISTADO DE ESPECIALIDADES MÉDICAS";
            this.btnMenuEspecialidadesMedicasBusqueda.Click += new System.EventHandler(this.btnMenuEspecialidadesMedicasBusqueda_Click);
            // 
            // btnMenuPlan
            // 
            this.btnMenuPlan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuPlanBusqueda});
            this.btnMenuPlan.Name = "btnMenuPlan";
            this.btnMenuPlan.Size = new System.Drawing.Size(216, 22);
            this.btnMenuPlan.Text = "PLAN";
            // 
            // btnMenuPlanBusqueda
            // 
            this.btnMenuPlanBusqueda.Name = "btnMenuPlanBusqueda";
            this.btnMenuPlanBusqueda.Size = new System.Drawing.Size(236, 22);
            this.btnMenuPlanBusqueda.Text = "LISTADO DE PLANES MÉDICOS";
            this.btnMenuPlanBusqueda.Click += new System.EventHandler(this.btnMenuPlanBusqueda_Click);
            // 
            // btnMenuRegistrar
            // 
            this.btnMenuRegistrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuRegistrarAgenda,
            this.btnMenuRegistrarLlegadaAM,
            this.btnMenuRegistrarResultadoAM});
            this.btnMenuRegistrar.Name = "btnMenuRegistrar";
            this.btnMenuRegistrar.Size = new System.Drawing.Size(78, 20);
            this.btnMenuRegistrar.Text = "REGISTRAR";
            // 
            // btnMenuRegistrarAgenda
            // 
            this.btnMenuRegistrarAgenda.Name = "btnMenuRegistrarAgenda";
            this.btnMenuRegistrarAgenda.Size = new System.Drawing.Size(262, 22);
            this.btnMenuRegistrarAgenda.Text = "AGENDA";
            this.btnMenuRegistrarAgenda.Click += new System.EventHandler(this.btnMenuRegistrarAgenda_Click);
            // 
            // btnMenuRegistrarLlegadaAM
            // 
            this.btnMenuRegistrarLlegadaAM.Name = "btnMenuRegistrarLlegadaAM";
            this.btnMenuRegistrarLlegadaAM.Size = new System.Drawing.Size(262, 22);
            this.btnMenuRegistrarLlegadaAM.Text = "LLEGADA A ATENCIÓN MÉDICA";
            this.btnMenuRegistrarLlegadaAM.Click += new System.EventHandler(this.btnMenuRegistrarLlegadaAM_Click);
            // 
            // btnMenuRegistrarResultadoAM
            // 
            this.btnMenuRegistrarResultadoAM.Name = "btnMenuRegistrarResultadoAM";
            this.btnMenuRegistrarResultadoAM.Size = new System.Drawing.Size(262, 22);
            this.btnMenuRegistrarResultadoAM.Text = "RESULTADO DE ATENCIÓN MÉDICA";
            this.btnMenuRegistrarResultadoAM.Click += new System.EventHandler(this.btnMenuRegistrarResultadoAM_Click);
            // 
            // btnMenuComprarBono
            // 
            this.btnMenuComprarBono.Name = "btnMenuComprarBono";
            this.btnMenuComprarBono.Size = new System.Drawing.Size(119, 20);
            this.btnMenuComprarBono.Text = "COMPRAR BONOS";
            this.btnMenuComprarBono.Click += new System.EventHandler(this.btnMenuComprarBono_Click);
            // 
            // btnMenuPedidoTurno
            // 
            this.btnMenuPedidoTurno.Name = "btnMenuPedidoTurno";
            this.btnMenuPedidoTurno.Size = new System.Drawing.Size(126, 20);
            this.btnMenuPedidoTurno.Text = "PEDIDO DE TURNOS";
            this.btnMenuPedidoTurno.Click += new System.EventHandler(this.btnMenuPedidoTurno_Click);
            // 
            // btnMenuCancelarAtencion
            // 
            this.btnMenuCancelarAtencion.Name = "btnMenuCancelarAtencion";
            this.btnMenuCancelarAtencion.Size = new System.Drawing.Size(113, 20);
            this.btnMenuCancelarAtencion.Text = "CANCELACIONES";
            this.btnMenuCancelarAtencion.Click += new System.EventHandler(this.btnMenuCancelarAtencion_Click_1);
            // 
            // btnMenuListadoEstadistico
            // 
            this.btnMenuListadoEstadistico.Name = "btnMenuListadoEstadistico";
            this.btnMenuListadoEstadistico.Size = new System.Drawing.Size(138, 20);
            this.btnMenuListadoEstadistico.Text = "LISTADO ESTADISTICO";
            this.btnMenuListadoEstadistico.Click += new System.EventHandler(this.btnMenuListadoEstadistico_Click);
            // 
            // btnModifPlanes
            // 
            this.btnModifPlanes.Name = "btnModifPlanes";
            this.btnModifPlanes.Size = new System.Drawing.Size(175, 20);
            this.btnModifPlanes.Text = "HISTORIAL PLANES AFILIADO";
            this.btnModifPlanes.Click += new System.EventHandler(this.btnModifPlanes_Click);
            // 
            // btnCambiarPassword
            // 
            this.btnCambiarPassword.Name = "btnCambiarPassword";
            this.btnCambiarPassword.Size = new System.Drawing.Size(135, 20);
            this.btnCambiarPassword.Text = "CAMBIAR PASSWORD";
            this.btnCambiarPassword.Click += new System.EventHandler(this.btnCambiarPassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 65);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido/a";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNombreUsuario.Location = new System.Drawing.Point(30, 96);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(0, 25);
            this.lblNombreUsuario.TabIndex = 2;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.White;
            this.btnLogOut.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Image = global::ClinicaFrba.Properties.Resources.logout1;
            this.btnLogOut.Location = new System.Drawing.Point(12, 556);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(52, 58);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.TabStop = false;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::ClinicaFrba.Properties.Resources.simboloClinicaFRBA;
            this.ClientSize = new System.Drawing.Size(944, 467);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnPrincipal);
            this.MainMenuStrip = this.mnPrincipal;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.mnPrincipal.ResumeLayout(false);
            this.mnPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnPrincipal;
        private System.Windows.Forms.ToolStripMenuItem btnMenuAbm;
        private System.Windows.Forms.ToolStripMenuItem btnMenuRol;       
        private System.Windows.Forms.ToolStripMenuItem btnMenuRolAlta;
        private System.Windows.Forms.ToolStripMenuItem btnMenuRolBusqueda;

        private System.Windows.Forms.ToolStripMenuItem btnMenuEspecialidadesMedicas;
        private System.Windows.Forms.ToolStripMenuItem btnMenuEspecialidadesMedicasBusqueda;

        private System.Windows.Forms.ToolStripMenuItem btnMenuAfiliado;
        private System.Windows.Forms.ToolStripMenuItem btnMenuAfiliadoAlta;
        private System.Windows.Forms.ToolStripMenuItem btnMenuAfiliadoBusqueda;

        private System.Windows.Forms.ToolStripMenuItem btnMenuProfesional;
        private System.Windows.Forms.ToolStripMenuItem btnMenuProfesionalAlta;

        private System.Windows.Forms.ToolStripMenuItem btnMenuPlan;
        private System.Windows.Forms.ToolStripMenuItem btnMenuPlanBusqueda;

        private System.Windows.Forms.ToolStripMenuItem btnMenuPedidoTurno;
        private System.Windows.Forms.ToolStripMenuItem btnMenuComprarBono;

        private System.Windows.Forms.ToolStripMenuItem btnMenuRegistrar;
        private System.Windows.Forms.ToolStripMenuItem btnMenuRegistrarAgenda;
        private System.Windows.Forms.ToolStripMenuItem btnMenuRegistrarResultadoAM;
        private System.Windows.Forms.ToolStripMenuItem btnMenuRegistrarLlegadaAM;

        private System.Windows.Forms.ToolStripMenuItem btnMenuListadoEstadistico;
        private System.Windows.Forms.ToolStripMenuItem btnCambiarPassword;
        private System.Windows.Forms.ToolStripMenuItem btnMenuCancelarAtencion;
        private System.Windows.Forms.ToolStripMenuItem btnModifPlanes;
        private System.Windows.Forms.ToolStripMenuItem aSOCIARAFILIADOSEXISTENTESToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Button btnLogOut;
    }
}