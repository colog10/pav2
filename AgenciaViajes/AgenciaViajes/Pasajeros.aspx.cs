using AgenciaDeViajesBLL;
using AgenciaDeViajesDTO.Entities;
using System;
using System.Collections.Generic;
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
            txtNumeroDocumento.Text = "";
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
            pasajero.Activo = chkActivo.Checked;
            pasajero.Apellido = txtApellido.Text;
            pasajero.Nombre = txtNombre.Text;
            pasajero.FechaNacimiento = cldFechaAlta.SelectedDate;
            pasajero.Cuilcuit1 = txtCuil.Text;
            pasajero.Cuilcuit2 = txtCuil.Text;
            pasajero.Cuilcuit3 = txtCuil.Text;
            pasajero.Domicilio = txtDomicilio.Text;
            pasajero.Email = txtEmail.Text;
            pasajero.Movil = txtMovil.Text;
            pasajero.IdTipoDocumento = Convert.ToInt32(ddlTipoDoc.SelectedValue);
            pasajero.IdEstadoCivil = Convert.ToInt32(ddlEstadoCivil.SelectedValue);
            pasajero.IdNacionalidad = Convert.ToString(ddlNacionalidad.SelectedValue);
            pasajero.IsNew = true;
            PasajeroManager.SavePasajero(pasajero);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarPantalla();
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            PasajeroDTO pasajero = new PasajeroDTO();
            TipoDocumentoDTO usuario = new TipoDocumentoDTO();
            EstadoCivilDTO estadoCivil = new EstadoCivilDTO();
            pasajero.Activo = chkActivo.Checked;
            pasajero.Apellido = txtApellido.Text;
            pasajero.Nombre = txtNombre.Text;
            pasajero.FechaNacimiento = cldFechaAlta.SelectedDate;
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
    }
}