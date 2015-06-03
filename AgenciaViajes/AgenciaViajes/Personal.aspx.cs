using AgenciaDeViajesBLL;
using AgenciaDeViajesDTO.Entities;
using AgenciaDeViajesDTO.Util;
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
            HabilitarNuevo();
        }

        private void HabilitarNuevo()
        {

            ConsultaSection.Visible = false;
            altaModificacionSection.Visible = true;
            btnGuardar.Visible = true;
            btnModificar.Visible = false;
            ddlUsuario.Enabled = true;
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
            OcultarMensajes();
            int idEmpleado = 0;
            int cantidadSeleccionados = 0;

            foreach (GridViewRow row in gvEmpleados.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkRow = (row.Cells[0].FindControl("chkElemento") as CheckBox);
                    if (chkRow.Checked)
                    {
                        cantidadSeleccionados++;
                        if (cantidadSeleccionados > 1)
                        {
                            DangerMessage.Visible = true;
                            LblDanger.Text = "No es posible modificar mas de un empleado al mismo tiempo.";
                            return;
                        }
                        idEmpleado = Convert.ToInt16(row.Cells[1].Text);
                    }
                }
            }
            if (cantidadSeleccionados == 0)
            {
                DangerMessage.Visible = true;
                LblDanger.Text = "Seleccione un empleado para modificar sus datos.";
                return;
            }
            CargarDatos(EmpleadoManager.GetEmpleado(idEmpleado));
            HabilitarModificacion();
        }

        private void HabilitarModificacion()
        {
            ConsultaSection.Visible = false;
            altaModificacionSection.Visible = true;
            btnGuardar.Visible = false;
            btnModificar.Visible = true;
            ddlUsuario.Enabled = false;
        }

        private void CargarDatos(EmpleadoDTO empleadoDTO)
        {
            chkActivo.Checked = empleadoDTO.Activo;
            chkSupervisor.Checked = empleadoDTO.Supervisor;
            txtFechaAlta.Text = empleadoDTO.FechaAlta.ToString().Split(' ')[0];
            if (empleadoDTO.FechaBaja != CommonBase.DateTime_NullValue)
                txtFechaBaja.Text = empleadoDTO.FechaBaja.Value.ToString().Split(' ')[0];
            txtApellido.Text = empleadoDTO.Apellido;
            txtLegajo.Text = Convert.ToString(empleadoDTO.Legajo);
            txtNombre.Text = empleadoDTO.Nombre;
            ddlUsuario.SelectedValue = Convert.ToString(empleadoDTO.IdUsuario);
            hdIdEmpleado.Value = Convert.ToString(empleadoDTO.IdEmpleado);
        }
    }
}