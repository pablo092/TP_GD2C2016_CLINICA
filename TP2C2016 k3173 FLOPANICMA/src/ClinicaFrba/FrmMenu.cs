using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

using ClinicaFrba.DAO;
using ClinicaFrba.DTO;
using ClinicaFrba.ABM_Rol;
using ClinicaFrba.Common;


namespace ClinicaFrba
{
    public partial class FrmMenu : Form
    {
        private Usuario usuario;
        private FrmLogin frmLogin;
        
        /// <summary>
        /// Form menu, contiene todos los menues para acceder a las pantallas individualmente
        /// Con el usuario logueado, se recuperan sus funcionalidades habilitadas, las que dependen del rol seleccionado, 
        ///  y se setea el mismo en UsuarioLogueado.
        ///  Luego, se deshabilitan todos los menues, y se habilitan sólo los correspondientes a su rol.
        /// </summary>
        /// <param name="usr"></param>
        /// <param name="frmLogin"></param>
        public FrmMenu(Usuario usr, FrmLogin frmLogin)
        {
            InitializeComponent();

            this.frmLogin = frmLogin;
            usuario = usr;
            this.Text = "CLÍNICA-FRBA";
            FuncionalidadDAO funcionalidadDAO = new FuncionalidadDAO();

            /* Recupero las funcionalidades del usuario logueado */
            Respuesta respuesta = funcionalidadDAO.getFuncionalidadesByRol(usuario.Rol.Descripcion);
            DataTable dt = respuesta.Resultado;

            List<String> funcionalidades = dt.Rows.OfType<DataRow>().Select(dr => dr.Field<String>("DESCRIPCION")).ToList();

            /* Seteo el usuario logueado */
            UsuarioLogueado.usuario = usr;
            UsuarioLogueado.funcionalidades = funcionalidades;

            /*Se inhbilitan los menues*/
            inhabilitarTodo();

            /*Se habilitn solo los menues corrspondientes a las funcionalidades del usuario*/
            habilitarPanelesPorRol();
        }

        /// <summary>
        /// Se ocultan todos los menues del form principal
        /// </summary>
        private void inhabilitarTodo()
        {
            btnMenuCalificarVendedor.Visible = false;
            btnMenuCliente.Visible = false;
            btnMenuEmpresa.Visible = false;
            btnMenuFacturasVendedor.Visible = false;
            btnMenuHistorialCliente.Visible = false;
            btnMenuListadoEstadistico.Visible = false;
            btnMenuOfertar.Visible = false;
            btnMenuPublicaciones.Visible = false;
            btnMenuRol.Visible = false;
            btnMenuRubro.Visible = false;
            btnMenuUsuario.Visible = false;
            btnMenuVisibilidad.Visible = false;
        }

        /// <summary>
        /// A partir de las funcionalidades que tenga el usuario logueado (las cuales dependen de su rol), 
        /// se pasan a visibles los menues correspondientes
        /// </summary>
        private void habilitarPanelesPorRol()
        {
            if (UsuarioLogueado.funcionalidades.Contains("ABM DE ROL")){
                btnMenuRol.Visible = true;                
            }
            if (UsuarioLogueado.funcionalidades.Contains("ABM DE USUARIO"))
            {
                btnMenuUsuario.Visible = true;
            }
            if (UsuarioLogueado.funcionalidades.Contains("ABM DE RUBRO"))
            {
                btnMenuRubro.Visible = true;
            }
            if (UsuarioLogueado.funcionalidades.Contains("ABM DE VISIBILIDAD"))
            {
                btnMenuVisibilidad.Visible = true;
            }
            if (UsuarioLogueado.funcionalidades.Contains("BUSQUEDA CLIENTE"))
            {
                btnMenuCliente.Visible = true;
            }
            if (UsuarioLogueado.funcionalidades.Contains("BUSQUEDA EMPRESA"))
            {
                btnMenuEmpresa.Visible = true;           
            }
            if (UsuarioLogueado.funcionalidades.Contains("GENERAR PUBLICACION"))
            {
                btnMenuPublicaciones.Visible = true;
            }
            if (UsuarioLogueado.funcionalidades.Contains("COMPRAR OFERTAR"))
            {
                btnMenuOfertar.Visible = true;             
            }
            if (UsuarioLogueado.funcionalidades.Contains("HISTORIAL"))
            {
                btnMenuHistorialCliente.Visible = true;
            }
            if (UsuarioLogueado.funcionalidades.Contains("CALIFICAR"))
            {
                btnMenuCalificarVendedor.Visible = true;
            }
            if (UsuarioLogueado.funcionalidades.Contains("FACTURAS REALIZADAS"))
            {
                btnMenuFacturasVendedor.Visible = true;
            }
            if (UsuarioLogueado.funcionalidades.Contains("LISTADO ESTADISTICO"))
            {
                btnMenuListadoEstadistico.Visible = true;
            }
        }

        private void btnMenuRolBusqueda_Click(object sender, EventArgs e)
        {
            FrmBuscarRol frmRolBusqueda = new FrmBuscarRol();
            frmRolBusqueda.ShowDialog();
        }

        private void btnMenuRolAlta_Click(object sender, EventArgs e)
        {
            FrmCrearRol frmRolCrear = new FrmCrearRol();
            frmRolCrear.ShowDialog();
        }

        //private void btnMenuUsuarioAlta_Click(object sender, EventArgs e)
        //{
        //    FrmModificarUsuario frmUsuarioCrear = new FrmModificarUsuario();
        //    frmUsuarioCrear.ShowDialog();
        //}

        //private void btnMenuRubroBusqueda_Click(object sender, EventArgs e)
        //{
        //    FrmBuscarRubro frmRubroBusqueda = new FrmBuscarRubro();
        //    frmRubroBusqueda.ShowDialog();
        //}

        //private void btnMenuUsuarioBusqueda_Click(object sender, EventArgs e)
        //{
        //    FrmBuscarUsuario frmBuscarUsuario = new FrmBuscarUsuario();
        //    frmBuscarUsuario.ShowDialog();
        //}

        //private void btnMenuPublicacionesGenerar_Click(object sender, EventArgs e)
        //{
        //    FrmPublicacion frmPublicacion = new FrmPublicacion( );
        //    frmPublicacion.ShowDialog();
        //}

        //private void btnMenuVisibilidadAlta_Click(object sender, EventArgs e)
        //{
        //    FrmABMVisibilidad frmAbmVisibilidad  = new FrmABMVisibilidad();
        //    frmAbmVisibilidad.ShowDialog();
        //}

        //private void btnMenuVisibilidadBusqueda_Click(object sender, EventArgs e)
        //{
        //    FrmBuscarVisibilidad frmBusquedaVisibilidad = new FrmBuscarVisibilidad();
        //    frmBusquedaVisibilidad.ShowDialog();
        //}

        //private void btnMenuOfertar_Click(object sender, EventArgs e)
        //{
        //    FrmComprarOfertar frmOfertar = new FrmComprarOfertar();
        //    frmOfertar.ShowDialog();
        //}

        //private void btnMenuDesconectar_Click(object sender, EventArgs e)
        //{
        //    new FrmAutentificacion(this).ShowDialog();
        //}

        //private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    this.frmAutentificacion.Close();
        //}

        //private void btnMenuPublicacionesMisPublicaciones_Click(object sender, EventArgs e)
        //{
        //    new FrmMisPublicaciones().ShowDialog();
        //}

        //private void vERESTADISTICASToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmListadoEstadistico frmListadoEstadistico = new FrmListadoEstadistico();
        //    frmListadoEstadistico.ShowDialog();
        //}

        //private void bUSCARFACTURASToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmFacturasVendedor frmFacturasVendedor = new FrmFacturasVendedor();
        //    frmFacturasVendedor.ShowDialog();
        //}

        //private void cALIFICARCOMPRAToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmCalificar frmCalificar = new FrmCalificar();
        //    frmCalificar.ShowDialog();
        //}

        //private void vERHISTORIALToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmHistorialCliente frmHistorialCliente = new FrmHistorialCliente();
        //    frmHistorialCliente.ShowDialog();
        //}

        //private void bUSCAREDITARCLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmBuscarCliente frmBuscarCliente = new FrmBuscarCliente();
        //    frmBuscarCliente.ShowDialog();
        //}

        //private void bUSCAREDITAREMPRESAToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmBuscarEmpresa frmBuscarEmpresa = new FrmBuscarEmpresa();
        //    frmBuscarEmpresa.Show();
        //}

        //private void btnCambiarPassword_Click(object sender, EventArgs e)
        //{
        //    FrmModificarPassword frmModificarPassword = new FrmModificarPassword();
        //    frmModificarPassword.Show();
        //}

    }
}
