using AgenciaDeViajesBLL;
using AgenciaDeViajesDTO.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AgenciaViajes
{
    public partial class Pasajero : System.Web.UI.Page
    {
        private bool isNew = false;
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
                List<PasajeroDTO> pasajero = PasajeroManager.GetPasajeros(Termino);
                gvPasajero.DataSource = pasajero;
                gvPasajero.DataBind();
            }
        }

        private void InicializarPantalla()
        {
            Consulta.Visible = true;
            alta.Visible = false;
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
            txtBuscar.Text = "";
            txtNombre.Text = "";
            txtCuil.Text = "";
            txtDomicilio.Text = "";
            txtEmail.Text = "";
            txtMovil.Text = "";

            txtProfesion.Text = "";
            txtTelefono.Text = "";
            chkActivo.Checked = true;



        }

        private void LoadData()
        {
            LoadTipoDocumento();
            loadEstadoCivil();
            loadNacinalidad();
            LoadPasajeros();


        }

        private void LoadTipoDocumento()
        {
            List<TipoDocumentoDTO> tipodoc = TipoDocumentoManager.GetTipoDocumento();
            ddlTipoDoc.DataSource = tipodoc;
            ddlTipoDoc.DataBind();
            ListItem emptyItem = new ListItem("SELECCIONE", "");
            ddlTipoDoc.Items.Insert(0, emptyItem);
        }
        private void loadEstadoCivil()
        {
            List<EstadoCivilDTO> estadoCivil = EstadoCivilManager.GetEstadoCivil();
            ddlEstadoCivil.DataSource = estadoCivil;
            ddlEstadoCivil.DataBind();
            ListItem emptyItem = new ListItem("SELECCIONE", "");
            ddlEstadoCivil.Items.Insert(0, emptyItem);
        }

        private void loadNacinalidad()
        {
            List<PaisDTO> pais = PaislManager.GetPais();
            ddlNacionalidad.DataSource = pais;
            ddlNacionalidad.DataBind();
            ListItem emptyItem = new ListItem("SELECCIONE", "");
            ddlNacionalidad.Items.Insert(0, emptyItem);
        }

        private void LoadPasajeros()
        {
            List<PasajeroDTO> pasajero = PasajeroManager.GetPasajeros();
            gvPasajero.DataSource = pasajero;
            gvPasajero.DataBind();

        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Consulta.Visible = false;
            alta.Visible = true;
            btnGuardar.Visible = true;
            //btnModificar.Visible = false;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            PasajeroDTO pasajero = new PasajeroDTO();
            TipoDocumentoDTO usuario = new TipoDocumentoDTO();
            EstadoCivilDTO estadoCivil = new EstadoCivilDTO();

            DateTime fechaNac;
            if (!DateTime.TryParseExact(txtNacimiento.Text, "dd/MM/yyyy", new CultureInfo("es-AR"), DateTimeStyles.None, out fechaNac))
            {
                DangerMessage.Visible = true;
                LblDanger.Text = "El formato de la fecha de alta debe ser dd/MM/yyyy.";
                return;
            }
            string[] split = txtCuil.Text.Split(new Char[] { '-' });

            pasajero.Activo = chkActivo.Checked;
            pasajero.Apellido = txtApellido.Text;
            pasajero.Nombre = txtNombre.Text;
            pasajero.FechaNacimiento = fechaNac;
            pasajero.Cuilcuit1 = split[0]; ;
            pasajero.Cuilcuit2 = split[1]; ;
            pasajero.Cuilcuit3 = split[2]; ;
            pasajero.Domicilio = txtDomicilio.Text;
            pasajero.Email = txtEmail.Text;
            pasajero.Movil = txtMovil.Text;
            pasajero.IdTipoDocumento = Convert.ToInt32(ddlTipoDoc.SelectedValue);
            pasajero.IdEstadoCivil = Convert.ToInt32(ddlEstadoCivil.SelectedValue);
            pasajero.IdNacionalidad = Convert.ToString(ddlNacionalidad.SelectedValue);
            pasajero.Eliminado = "0";
            pasajero.IsNew = true;
            PasajeroManager.SavePasajero(pasajero);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarPantalla();
        }



        protected void btnModificar_Click(object sender, EventArgs e)
        {
            int movil;

            if (!txtMovil.Text.Equals(""))
            {
                if (!Int32.TryParse(txtMovil.Text, out movil))
                {
                    DangerMessage.Visible = true;
                    LblDanger.Text = "El movil debe ser un valor numérico.";
                    return;
                }

            }
            
            if (!new EmailAddressAttribute().IsValid(txtEmail.Text))
            {
                DangerMessage.Visible = true;
                LblDanger.Text = "formato mail incorrecto.";
                return;

            }
            int telefono;
            if (!txtTelefono.Text.Equals(""))
            {
                if (!Int32.TryParse(txtTelefono.Text, out telefono))
                {
                    DangerMessage.Visible = true;
                    LblDanger.Text = "El telefono debe ser un valor numérico.";
                    return;
                }
            }
            DateTime fechaNacimiento;
            if (!DateTime.TryParseExact(txtNacimiento.Text, "dd/MM/yyyy", new CultureInfo("es-AR"), DateTimeStyles.None, out fechaNacimiento))
            {
                DangerMessage.Visible = true;
                LblDanger.Text = "El formato de la fecha debe ser dd/MM/yyyy.";
                return;
            }


            PasajeroDTO pasajero = new PasajeroDTO();

            pasajero.Activo = chkActivo.Checked;
            pasajero.Apellido = txtApellido.Text;
            pasajero.Nombre = txtNombre.Text;
            pasajero.FechaNacimiento = fechaNacimiento;
            pasajero.Cuilcuit1 = txtCuil.Text;
            pasajero.Cuilcuit2 = txtCuil.Text;
            pasajero.Cuilcuit3 = txtCuil.Text;
            pasajero.Domicilio = txtDomicilio.Text;
            pasajero.Email = txtEmail.Text;
            pasajero.Movil = txtMovil.Text;
            pasajero.IdTipoDocumento = Convert.ToInt32(ddlTipoDoc.SelectedValue);
            pasajero.IdEstadoCivil = Convert.ToInt32(ddlEstadoCivil.SelectedValue);
            pasajero.IdNacionalidad = ddlNacionalidad.SelectedValue;
            pasajero.IsNew = false;
            PasajeroManager.SavePasajero(pasajero);
        }


        protected void btnModificarSeleccionado_Click(object sender, EventArgs e)
        {
            OcultarMensajes();
            int idPasajero = 0;
            int cantidadSeleccionados = 0;

            foreach (GridViewRow row in gvPasajero.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkRow = (row.Cells[0].FindControl("chkPasajero") as CheckBox);
                    if (chkRow.Checked)
                    {
                        cantidadSeleccionados++;
                        if (cantidadSeleccionados > 1)
                        {
                            DangerMessage.Visible = true;
                            LblDanger.Text = "No es posible modificar mas de un Pasajero al mismo tiempo.";
                            return;
                        }
                        idPasajero = Convert.ToInt32(gvPasajero.DataKeys[row.RowIndex].Value.ToString());


                    }
                }
            }
            if (cantidadSeleccionados == 0)
            {
                DangerMessage.Visible = true;
                LblDanger.Text = "Seleccione un Pasajero para modificar sus datos.";
                return;
            }
            CargarDatos(PasajeroManager.GetPasajeroByID(idPasajero));
            HabilitarModificacion();
        }

        private void HabilitarModificacion()
        {
            Consulta.Visible = false;
            alta.Visible = true;
            btnGuardar.Visible = false;
            btnModificar.Visible = true;
            ddlEstadoCivil.Enabled = false;
            ddlNacionalidad.Enabled = false;
            ddlTipoDoc.Enabled = false;
        }

        private void CargarDatos(PasajeroDTO pasajero)
        {

            chkActivo.Checked = pasajero.Activo;
            txtApellido.Text = pasajero.Apellido;
            txtNombre.Text = pasajero.Nombre;
            txtNacimiento.Text = Convert.ToString(pasajero.FechaNacimiento);
            txtCuil.Text = pasajero.Cuilcuit1;
            txtCuil.Text = pasajero.Cuilcuit2;
            txtCuil.Text = pasajero.Cuilcuit3;
            txtDomicilio.Text = pasajero.Domicilio;
            txtEmail.Text = pasajero.Email;
            txtMovil.Text = pasajero.Movil;
            ddlTipoDoc.SelectedValue = Convert.ToString(pasajero.IdTipoDocumento); ;
            ddlEstadoCivil.SelectedValue = Convert.ToString(pasajero.IdEstadoCivil);
            ddlNacionalidad.SelectedValue = Convert.ToString(pasajero.IdNacionalidad);

        }


    }
}