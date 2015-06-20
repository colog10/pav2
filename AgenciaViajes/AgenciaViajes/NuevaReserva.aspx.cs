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
    public partial class NuevaReserva : System.Web.UI.Page
    {
        List<ReservaDetalleDTO> detalles = new List<ReservaDetalleDTO>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                reservaDetalleSection.Visible = false;
                alojamientoSection.Visible = false;
                seguroViajeroSection.Visible = false;
                InicializarDetalleReserva();
                InicializarCombos();
                OcultarMensajes();
            }

        }

        private void InicializarCombos()
        {
            CargarComboDocumentoViaje();
            CargarComboPaises();
            CargarComboTransportes();
         //   CargarComboAlojamiento();
         //   CargarComboSeguros();
        }

        private void CargarComboSeguros()
        {
            ddlTipoSeguro.DataSource = TipoSeguroViajeroManager.GetAll();
            ddlTipoSeguro.DataValueField = "tipoSeguroViajeroDTO";
            ddlTipoSeguro.DataTextField = "descripcionDTO";
            ddlTipoSeguro.DataBind();
        }

        private void CargarComboAlojamiento()
        {
            ddlAlojamiento.DataSource = AlojamientoManager.GetAll();
            ddlAlojamiento.DataValueField = "idAlojamientoDTO";
            ddlAlojamiento.DataTextField = "nombreDTO";
            ddlAlojamiento.DataBind();
        }

        private void CargarComboTransportes()
        {
            ddlTransporte.DataSource = CompaniaAereaManager.GetAll();
            ddlTransporte.DataTextField = "nombreDTO";
            ddlTransporte.DataValueField = "idCompaniaAereaDTO";
            ddlTransporte.DataBind();
        }

        private void CargarComboDocumentoViaje()
        {
            ddlDocumentoViaje.DataSource = TipoDocumentoManager.GetTipoDocumento();
            ddlDocumentoViaje.DataTextField = "descripcionDTO";
            ddlDocumentoViaje.DataValueField = "idTipoDocumentoDTO";
            ddlDocumentoViaje.DataBind();
        }

        private void CargarComboPaises()
        {
            List<PaisDTO> paises = PaislManager.GetPais();
            ddlPaisOrigen.DataSource = paises;
            ddlPaisOrigen.DataTextField = "PaisNombre";
            ddlPaisOrigen.DataValueField = "PaisCodigo";
            ddlPaisOrigen.DataBind();
            ddlPaisDestino.DataSource = paises;
            ddlPaisDestino.DataTextField = "PaisNombre";
            ddlPaisDestino.DataValueField = "PaisCodigo";
            ddlPaisDestino.DataBind();
        }



        private void InicializarDetalleReserva()
        {
            gvDetalleReserva.DataSource = new List<PasajeroDTO>();
            gvDetalleReserva.DataBind();
            gvPasajeros.DataSource = new List<PasajeroDTO>();
            gvPasajeros.DataBind();
        }

        protected void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string filtroBusqueda = txtCliente.Text;
            gvClientes.DataSource = ClienteManager.GetClienteByRazonSocialOrCuil(filtroBusqueda);
            gvClientes.DataBind();
            
        }

        protected void btnBuscarPasajero_Click(object sender, EventArgs e)
        {
            string filtroBusqueda = txtPasajero.Text;
            gvPasajeros.DataSource = PasajeroManager.GetPasajeros(filtroBusqueda);
            gvPasajeros.DataBind();   
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            reservaDetalleSection.Visible = true;
            reservaSection.Visible = false;

            
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCamposDetalle();
            reservaDetalleSection.Visible = false;
            reservaSection.Visible = true;
        }

        private void LimpiarCamposDetalle()
        {
            txtPasajero.Text = "";
            gvPasajeros.DataSource = new List<PasajeroDTO>();
            gvPasajeros.DataBind();
            txtNumeroDocumentoViaje.Text = "";
            txtFechaSalida.Text = "";
            txtFechaRegreso.Text = "";
            txtFechaVencimientoReserva.Text = "";
            txtMonto.Text = "";
            txtFechaDesdeAlojamiento.Text = "";
            txtFechaHastaAlojamiento.Text = "";
            txtFechaVencimientoReservaAlojamiento.Text = "";
            txtMontoAlojamiento.Text = "";
            txtMontoSeguro.Text = "";
        }

        protected void ddlPaisOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlOrigen.DataSource = CiudadManager.GetByPais(ddlPaisOrigen.SelectedValue);
            ddlOrigen.DataValueField = "idCiudadDTO";
            ddlOrigen.DataTextField = "ciudadNombreDTO";
            ddlOrigen.DataBind();
        }


        private void OcultarMensajes()
        {
            DangerMessage.Visible = false;
            InfoMessage.Visible = false;
            SuccessMessage.Visible = false;
            WarningMessage.Visible = false;
        }


        protected void ddlPaisDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlDestino.DataSource = CiudadManager.GetByPais(ddlPaisDestino.SelectedValue);
            ddlDestino.DataValueField = "idCiudadDTO";
            ddlDestino.DataTextField = "ciudadNombreDTO";
            ddlDestino.DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            ReservaDTO reserva = new ReservaDTO();
            reserva.IsNew = true;
            reserva.NumeroReserva = Convert.ToInt32(txtNumero.Text);
            reserva.IdCliente = Convert.ToInt32(gvClientes.SelectedDataKey.Value);
            reserva.DetallesReserva = (List<ReservaDetalleDTO>)Session["detalles"];
            ReservaManager.Save(reserva);
            LblSuccess.Text = "La Reserva se guardo con exito";
            reservaSection.Visible = false;

            SuccessMessage.Visible = true;
        }

        

        protected void btnAceptar_Click1(object sender, EventArgs e)
        {
            ReservaDetalleDTO detalle = new ReservaDetalleDTO();
            
            detalle.IdPasajero = Convert.ToInt32(gvPasajeros.SelectedDataKey.Value);
            detalle.Pasajero = PasajeroManager.GetPasajeroByID(detalle.IdPasajero);
            detalle.NumeroDocumento = txtNumeroDocumentoViaje.Text;
            detalle.IdTipoDocumento = Convert.ToInt32(ddlDocumentoViaje.SelectedValue);
            detalles.Add(detalle);
            gvDetalleReserva.DataSource = detalles;
            gvDetalleReserva.DataBind();
            LimpiarCamposDetalle();
            reservaDetalleSection.Visible = false;
            reservaSection.Visible = true;
            Session["detalles"] = detalles;
        }
    }
}