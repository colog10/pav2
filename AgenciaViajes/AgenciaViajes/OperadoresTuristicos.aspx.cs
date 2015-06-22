using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AgenciaDeViajesBLL;
using AgenciaDeViajesDTO.Entities;
using System.Globalization;
using AgenciaDeViajesDTO.Util;

namespace AgenciaViajes
{
    public partial class OperadoresTuristicos : System.Web.UI.Page
    {
        private string termino = "";

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

        private void InicializarPantalla()
        {
            SectionConsulta.Visible = true;
            SectionAltaModificacion.Visible = false;
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            //txtBuscar.Text = "";
            //txtNombreOperadorTuristico.Text = "";
            //txtNombreContacto.Text = "";
            //txtDomicilio.Text = "";            
        }

      

        private void ReloadData()
        {
            if (termino != txtBuscar.Text)
            {
                termino = txtBuscar.Text;
                List<OperadorTuristicoDTO> operadorTuristico = OperadorTuristicoManager.GetOperadorTuristico(termino);
                gvOperadoresTuristicos.DataSource = operadorTuristico;
                gvOperadoresTuristicos.DataBind();
            }
        }

        private void LoadData()
        {
            LoadOperadoresTuristicos();
            LoadTiposDestino();
            //LoadCalificacion();
        }

        private void LoadCalificacion()
        {
            

        }

        private void LoadTiposDestino()
        {
            List<TipoDestinoDTO> tiposDestinos = TipoDestinoManager.GettiposDeDestino();
            ddlTipoDestino.DataSource = tiposDestinos;
            ddlTipoDestino.DataBind();
            ListItem emptyItem = new ListItem("SELECCIONE", "");
            ddlTipoDestino.Items.Insert(0, emptyItem);
        }

        private void LoadOperadoresTuristicos()
        {
            List<OperadorTuristicoDTO> operadoresTuristicos = OperadorTuristicoManager.GetOperadorTuristico();
            gvOperadoresTuristicos.DataSource = operadoresTuristicos;
            gvOperadoresTuristicos.DataBind();

        }


        private void OcultarMensajes()
        {
            DangerMessage.Visible = false;
            InfoMessage.Visible = false;
            SuccessMessage.Visible = false;
            WarningMessage.Visible = false;
        }
        protected void btnNuevo_Click(object sender, EventArgs e)
        {
           
            HabilitarNuevo();
        }

        private void HabilitarNuevo()
        {

            SectionAltaModificacion.Visible = true;
            SectionConsulta.Visible = false;
            btnGuardar.Visible = true;
            btnModificar.Visible = false;
            
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            OcultarMensajes();

            bool seleccionados = false;

            foreach (GridViewRow row in gvOperadoresTuristicos.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkRow = (row.Cells[0].FindControl("chkElemento") as CheckBox);
                    if (chkRow.Checked)
                    {
                        int id = Convert.ToInt32(gvOperadoresTuristicos.DataKeys[row.RowIndex].Value.ToString());
                        OperadorTuristicoManager.DeleteOperadorTuristico(id);
                        seleccionados = true;
                    }
                }
            }

            if (!seleccionados)
            {
                DangerMessage.Visible = true;
                LblDanger.Text = "Seleccione un operador turistico para eliminarlo.";
                return;
            }
            else
            {
                SuccessMessage.Visible = true;
                LblSuccess.Text = "Datos Eliminados Correctamente.";
            }
            InicializarPantalla();
            LoadOperadoresTuristicos();
        
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            
            DateTime fechaAlta;
            if (!DateTime.TryParseExact(txtFechaAlta.Text, "dd/MM/yyyy", new CultureInfo("es-AR"), DateTimeStyles.None, out fechaAlta))
            {
                DangerMessage.Visible = true;
                LblDanger.Text = "El formato de la fecha de alta debe ser dd/MM/yyyy.";
                return;
            }

            OperadorTuristicoDTO operadorTuristico = new OperadorTuristicoDTO();

            operadorTuristico.Activo = chkActivo.Checked;
            operadorTuristico.Calificacion = 1;
            operadorTuristico.Descripcion = txtNombreOperadorTuristico.Text;
            operadorTuristico.Direccion = txtDomicilioOperador.Text;
            operadorTuristico.Email =  TextMailContacto.Text;
            operadorTuristico.FechaAlta = fechaAlta;
            operadorTuristico.IdTipoDestino = Convert.ToInt32(ddlTipoDestino.SelectedValue);
            operadorTuristico.IsNew = true;
            operadorTuristico.Nombre = txtNombreContacto.Text;
            operadorTuristico.PaginaWeb = eMail.Text;
            operadorTuristico.Telefono = txtTelefono.Text;
            
            OperadorTuristicoManager.SaveOperadorTuristico(operadorTuristico);
            InicializarPantalla();
            LoadData();
            OcultarMensajes();
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            DateTime fechaAlta;
            if (!DateTime.TryParseExact(txtFechaAlta.Text, "dd/MM/yyyy", new CultureInfo("es-AR"), DateTimeStyles.None, out fechaAlta))
            {
                DangerMessage.Visible = true;
                LblDanger.Text = "El formato de la fecha de alta debe ser dd/MM/yyyy.";
                return;
            }

            OperadorTuristicoDTO operadorTuristico = new OperadorTuristicoDTO();

            operadorTuristico.Activo = chkActivo.Checked;
            operadorTuristico.Calificacion = Convert.ToInt32(txtCalificacion.Text);
            operadorTuristico.Descripcion = txtNombreOperadorTuristico.Text;
            operadorTuristico.Direccion = txtDomicilioOperador.Text;
            operadorTuristico.Email = TextMailContacto.Text;
            operadorTuristico.FechaAlta = fechaAlta;
            if(ddlTipoDestino.SelectedValue != "")
                operadorTuristico.IdTipoDestino = Convert.ToInt32(ddlTipoDestino.SelectedValue);
            operadorTuristico.IsNew = false;
            operadorTuristico.Nombre = txtNombreContacto.Text;
            operadorTuristico.PaginaWeb = eMail.Text;
            operadorTuristico.Telefono = txtTelefono.Text;
            operadorTuristico.IdOperadorTuristico = Convert.ToInt32(hdId.Value);

            OperadorTuristicoManager.UpdateOperadorTuristico(operadorTuristico);
            InicializarPantalla();
            LoadData();
            OcultarMensajes();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            SectionAltaModificacion.Visible = false;
            SectionConsulta.Visible = true;

        }

        protected void btnModificarSeleccionado_Click(object sender, EventArgs e)
        {
            OcultarMensajes();
            int id = 0;
            int cantidadSeleccionados = 0;

            foreach (GridViewRow row in gvOperadoresTuristicos.Rows)
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
                            LblDanger.Text = "No es posible modificar mas de un operador turistico al mismo tiempo.";
                            return;
                        }
                        id = Convert.ToInt32(gvOperadoresTuristicos.DataKeys[row.RowIndex].Value.ToString());


                    }
                }
            }
            if (cantidadSeleccionados == 0)
            {
                DangerMessage.Visible = true;
                LblDanger.Text = "Seleccione un operador turistico para modificar sus datos.";
                return;
            }
            CargarDatos(OperadorTuristicoManager.GetOperadorTuristico(id));
            HabilitarModificacion();
        }


        private void HabilitarModificacion()
        {
            SectionConsulta.Visible = false;
            SectionAltaModificacion.Visible = true;
            btnGuardar.Visible = false;
            btnModificar.Visible = true;
         
        }

        private void CargarDatos(OperadorTuristicoDTO value)
        {
            chkActivo.Checked = value.Activo;
            txtNombreOperadorTuristico.Text = value.Descripcion;
            txtDomicilioOperador.Text = value.Direccion;
            if (value.FechaAlta != CommonBase.DateTime_NullValue)
            {
                txtFechaAlta.Text = Convert.ToString(value.FechaAlta.ToShortDateString());
            }
               
                
            
            if(value.IdTipoDestino != CommonBase.Int_NullValue)
             ddlTipoDestino.SelectedIndex = Convert.ToInt32(value.IdTipoDestino);
            txtNombreContacto.Text = value.Nombre;
            eMail.Text = value.PaginaWeb;
            txtTelefono.Text = value.Telefono;
            TextMailContacto.Text = value.Email;
            hdId.Value = Convert.ToString(value.IdOperadorTuristico);
            
        }

        protected void gvOperadoresTuristicos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            
            gvOperadoresTuristicos.PageIndex = e.NewPageIndex;
            LoadData();
        }
    }
}