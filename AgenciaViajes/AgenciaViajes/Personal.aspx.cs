﻿using AgenciaDeViajesBLL;
using AgenciaDeViajesDTO.Entities;
using System;
using System.Collections.Generic;
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
            LimpiarCampos();
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
            List<EmpleadoDTO> empleados = EmpleadoManager.GetEmpleados();
            gvEmpleados.DataSource = empleados;
            gvEmpleados.DataBind();
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            ConsultaSection.Visible = false;
            altaModificacionSection.Visible = true;

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            EmpleadoDTO empleado = new EmpleadoDTO();
            UsuarioDTO usuario = new UsuarioDTO();
            empleado.Activo = chkActivo.Checked;
            empleado.Apellido = txtApellido.Text;
            empleado.FechaAlta = cldFechaAlta.SelectedDate;
            empleado.FechaBaja = cldFechaBaja.SelectedDate;
            empleado.IsNew = true;
            empleado.Supervisor = chkSupervisor.Checked;

            empleado.IdUsuario = Convert.ToInt32(ddlUsuario.SelectedValue);

            EmpleadoManager.SaveEmpleado(empleado);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarPantalla();
        }
    }
}