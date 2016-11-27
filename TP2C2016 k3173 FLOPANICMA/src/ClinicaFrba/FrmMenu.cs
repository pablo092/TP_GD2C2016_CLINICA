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
using ClinicaFrba.ABM_Afiliado;
using ClinicaFrba.Abm_Profesional;
using ClinicaFrba.Pedir_Turno;
using ClinicaFrba.Registrar_Agenta_Medico;
using ClinicaFrba.Registro_Resultado;
using ClinicaFrba.Cancelar_Atencion;
using ClinicaFrba.Registro_Llegada;
using ClinicaFrba.Compra_Bono;
using ClinicaFrba.Abm_Planes;
using ClinicaFrba.Abm_Especialidades_Medicas;
using ClinicaFrba.Abm_Afiliado;
using ClinicaFrba.Listados;
using ClinicaFrba.HistorialModificacionesPlan;


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
            btnMenuPedidoTurno.Visible = false;
            btnMenuRegistrarLlegadaAM.Visible = false;
            btnMenuRegistrarResultadoAM.Visible = false;
            btnMenuRegistrarAgenda.Visible = false;
            btnMenuListadoEstadistico.Visible = false;
            btnMenuComprarBono.Visible = false;
            btnMenuEspecialidadesMedicas.Visible = false;
            btnMenuRol.Visible = false;
            btnMenuPlan.Visible = false;
            btnMenuAfiliado.Visible = false;
            btnMenuProfesional.Visible = false;
            btnMenuCancelarAtencion.Visible = false;
            btnMenuHistorialModificacionesPlanAfiliado.Visible = false;

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
            if (UsuarioLogueado.funcionalidades.Contains("ABM DE AFILIADO"))
            {
                btnMenuAfiliado.Visible = true;
                btnMenuHistorialModificacionesPlanAfiliado.Visible = true;
            }
            if (UsuarioLogueado.funcionalidades.Contains("ABM DE PLANES MEDICOS"))
            {
                btnMenuPlan.Visible = true;
            }
            if (UsuarioLogueado.funcionalidades.Contains("ABM DE PROFESIONAL"))
            {
                btnMenuProfesional.Visible = true;
            }
            if (UsuarioLogueado.funcionalidades.Contains("ABM DE ESPECIALIDADES MEDICAS"))
            {
                btnMenuEspecialidadesMedicas.Visible = true;
            }
            if (UsuarioLogueado.funcionalidades.Contains("COMPRA DE BONOS"))
            {
                btnMenuComprarBono.Visible = true;             
            }
            if (UsuarioLogueado.funcionalidades.Contains("REGISTRAR AGENDA PROFESIONAL"))
            {
                btnMenuRegistrarAgenda.Visible = true;
            }
            if (UsuarioLogueado.funcionalidades.Contains("PEDIR TURNO"))
            {
                btnMenuPedidoTurno.Visible = true;
            }
            if (UsuarioLogueado.funcionalidades.Contains("REGISTRAR LLEGADA"))
            {
                btnMenuRegistrarLlegadaAM.Visible = true;
            }
            if (UsuarioLogueado.funcionalidades.Contains("LISTADOS"))
            {
                btnMenuListadoEstadistico.Visible = true;
            }
            if (UsuarioLogueado.funcionalidades.Contains("REGISTRAR RESULTADO"))
            {
                btnMenuRegistrarResultadoAM.Visible = true;
            }
            if (UsuarioLogueado.funcionalidades.Contains("CANCELAR ATENCION"))
            {
                btnMenuCancelarAtencion.Visible = true;
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

        private void btnMenuAfiliadoAlta_Click(object sender, EventArgs e)
        {
            FrmCrearAfiliado frmAfiliadoCrear = new FrmCrearAfiliado();
            frmAfiliadoCrear.ShowDialog();
        }

        private void btnMenuAfiliadoBusqueda_Click(object sender, EventArgs e)
        {
            FrmBuscarAfiliado frmBuscarAfiliado = new FrmBuscarAfiliado();
            frmBuscarAfiliado.ShowDialog();
        }

        private void btnMenuPlanBusqueda_Click(object sender, EventArgs e)
        {
            FrmBuscarPlan frmPlanBusqueda = new FrmBuscarPlan();
            frmPlanBusqueda.ShowDialog();
        }

        private void btnMenuProfesionalAlta_Click(object sender, EventArgs e)
        {
            FrmABMProfesional frmAbmProfesional = new FrmABMProfesional();
            frmAbmProfesional.ShowDialog();
        }

        private void btnMenuComprarBono_Click(object sender, EventArgs e)
        {
            FrmComprarBono frmComprar = new FrmComprarBono();
            frmComprar.ShowDialog();
        }

        private void btnMenuDesconectar_Click(object sender, EventArgs e)
        {
            new FrmLogin(this).ShowDialog();
        }       

        private void btnMenuEspecialidadesMedicasBusqueda_Click(object sender, EventArgs e)
        {
            FrmBuscarEspecialidadesMedicas frmEMBusqueda = new FrmBuscarEspecialidadesMedicas();
            frmEMBusqueda.ShowDialog();
        }

        private void btnMenuRegistrarLlegadaAM_Click(object sender, EventArgs e)
        {
            FrmRegistrarLlegada frmRegistrarLlegada = new FrmRegistrarLlegada();
            frmRegistrarLlegada.ShowDialog();
        }

        private void btnMenuRegistrarResultadoAM_Click(object sender, EventArgs e)
        {
            FrmRegistrarResultado frmRegistrarRersultado = new FrmRegistrarResultado();
            frmRegistrarRersultado.ShowDialog();
        }

        private void btnMenuRegistrarAgenda_Click(object sender, EventArgs e)
        {
            FrmRegistrarAgenda frmRegistarAgenda = new FrmRegistrarAgenda();
            frmRegistarAgenda.ShowDialog();
        }

        private void btnMenuPedidoTurno_Click(object sender, EventArgs e)
        {
            FrmPedidoTurno frmPedirTurno = new FrmPedidoTurno();
            frmPedirTurno.ShowDialog();
        }

        private void btnMenuCancelarAtencion_Click(object sender, EventArgs e)
        {
            FrmCancelarAtencion frmCancelarAt = new FrmCancelarAtencion();
            frmCancelarAt.ShowDialog();
        }

        private void btnMenuListadoEstadistico_Click(object sender, EventArgs e)
        {
            ListadoEstadistico frmListadoEstadistico = new ListadoEstadistico();
            frmListadoEstadistico.ShowDialog();
        }

        private void btnMenuHistorialModificacionesPlanAfiliado_Click(object sender, EventArgs e)
        {
            FrmHistModifPlan frmHistModifPlan = new FrmHistModifPlan();
            frmHistModifPlan.ShowDialog();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.frmLogin.Close();
        }
    }
}
