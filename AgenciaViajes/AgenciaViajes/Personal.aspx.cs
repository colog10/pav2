using AgenciaDeViajesBLL;
using AgenciaDeViajesDTO.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AgenciaViajes
{
    public partial class Personal : System.Web.UI.Page
    {
        private string Termino = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
                InicializarPantalla();
            }
            else
            {
                ReloadData();
            }
        }

        private void ReloadData()
        {
            if (Termino != txtBuscar.Text)
            {
                Termino = txtBuscar.Text;
                List<EmpleadoDTO> empleados = EmpleadoManager.GetEmpleados(Termino);
                gvEmpleados.DataSource = empleados;
                gvEmpleados.DataBind();
            }
        }

        private void InicializarPantalla()
        {
            ConsultaSection.Visible = true;
            altaModificacionSection.Visible = false;
            OcultarMensajes();
            LimpiarCampos();
        }

        private void OcultarMensajes()
        {
            DangerMessage.Visible = false;
            InfoMessage.Visible = false;
            SuccessMessage.Visible = false;
            WarningMessage.Visible = false;
        }

        private void LimpiarCampos()
        {
            txtApellido.Text = "";
            txtBuscar.Text = "";
            txtLegajo.Text = "";
            txtNombre.Text = "";
            ddlUsuario.SelectedIndex = -1;
            chkActivo.Checked = true;
            chkSupervisor.Checked = false;

        }

        private void LoadData()
        {
            LoadEmpleados();
            LoadUsuarios();
        }

        private void LoadUsuarios()
        {
            List<UsuarioDTO> usuarios = UsuarioManager.GetUsuarios();
            ddlUsuario.DataSource = usuarios;
            ddlUsuario.DataBind();
            ListItem emptyItem = new ListItem("SELECCIONE", "");
            ddlUsuario.Items.Insert(0, emptyItem);
        }

        private void LoadEmpleados()
        {
            List<EmpleadoDTO> empleados = EmpleadoManager.GetEmpleados();
            gvEmpleados.DataSource = empleados;
            gvEmpleados.DataBind();
            
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            ConsultaSection.Visible = false;
            altaModificacionSection.Visible = true;
            btnGuardar.Visible = true;
            btnModificar.Visible = false;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            int legajo;

            if (!Int32.TryParse(txtLegajo.Text, out legajo))
            {
                DangerMessage.Visible = true;
                LblDanger.Text = "El legajo debe ser un valor numérico.";
                return;
            }
            DateTime fechaAlta;
            if (!DateTime.TryParseExact(txtFechaAlta.Text, "dd/MM/yyyy", new CultureInfo("es-AR"), DateTimeStyles.None, out fechaAlta))
            {
                DangerMessage.Visible = true;
                LblDanger.Text = "El formato de la fecha de alta debe ser dd/MM/yyyy.";
                return;
            }

            DateTime? fechaBaja = null;
            if (txtFechaBaja.Text != "" && !DateTime.TryParseExact(txtFechaBaja.Text, "dd/MM/yyyy", new CultureInfo("es-AR"), DateTimeStyles.None, out fechaAlta))
            {
                DangerMessage.Visible = true;
                LblDanger.Text = "El formato de la fecha de baja debe ser dd/MM/yyyy.";
                return;
            }
            
            
            EmpleadoDTO empleado = new EmpleadoDTO();
            UsuarioDTO usuario = new UsuarioDTO();
            empleado.Activo = chkActivo.Checked;
            empleado.Apellido = txtApellido.Text;
            empleado.Nombre = txtNombre.Text;
            empleado.FechaAlta = fechaAlta;
            if(fechaBaja != null)
                empleado.FechaBaja = fechaBaja;
            empleado.Legajo = legajo;
            empleado.IsNew = true;
            empleado.Supervisor = chkSupervisor.Checked;
            if (ddlUsuario.SelectedValue != "") { 
                empleado.IdUsuario = Convert.ToInt32(ddlUsuario.SelectedValue);
            }
            EmpleadoManager.SaveEmpleado(empleado);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarPantalla();
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {

        }

        
        protected void btnModificarSeleccionado_Click(object sender, EventArgs e)
        {

        }
    }
}