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
                Session["detalles"] = new List<ReservaDetalleDTO>();
            }

        }

        private void InicializarCombos()
        {
            CargarComboDocumentoViaje();
            CargarComboPaises();
            CargarComboTransportes();
         //   CargarComboAlojamiento();
            CargarComboSeguros();
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
            txtFechaSalida.Text = "";
            txtFechaRegreso.Text = "";
            txtMontoDetalle.Text = "";
            txtFechaDesdeAlojamiento.Text = "";
            txtFechaHastaAlojamiento.Text = "";
            
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

            ServicioTrasladoDTO servicioTraslado = new ServicioTrasladoDTO();
            DateTime fechaSalida = CommonBase.DateTime_NullValue;
            DateTime fechaLlegada = CommonBase.DateTime_NullValue;

            if (Session["detalles"] != null) { 
                detalles = (List<ReservaDetalleDTO>)Session["detalles"];
            }
            
            detalle.IdPasajero = Convert.ToInt32(gvPasajeros.SelectedDataKey.Value);
            detalle.Pasajero = PasajeroManager.GetPasajeroByID(detalle.IdPasajero);
            detalle.IdTipoDocumento = Convert.ToInt32(ddlDocumentoViaje.SelectedValue);
            detalle.Monto = decimal.Parse(txtMontoDetalle.Text);

            servicioTraslado.IsNew = true;
            servicioTraslado.destinoDTO = Int32.Parse(ddlDestino.SelectedValue);
            servicioTraslado.origenDTO = Int32.Parse(ddlOrigen.SelectedValue);

            if (txtFechaSalida.Text != "" && !DateTime.TryParseExact(txtFechaSalida.Text, "dd/MM/yyyy", new CultureInfo("es-AR"), DateTimeStyles.None, out fechaSalida))
            {
                DangerMessage.Visible = true;
                LblDanger.Text = "El formato de la fecha de salida debe ser dd/MM/yyyy.";
                return;
            }

            if (txtFechaRegreso.Text != "" && !DateTime.TryParseExact(txtFechaRegreso.Text, "dd/MM/yyyy", new CultureInfo("es-AR"), DateTimeStyles.None, out fechaLlegada))
            {
                DangerMessage.Visible = true;
                LblDanger.Text = "El formato de la fecha de regreso debe ser dd/MM/yyyy.";
                return;
            }

            servicioTraslado.fechaSalidaDTO = fechaSalida;
            servicioTraslado.fechaLlegadaDTO = fechaLlegada;
            
            servicioTraslado.idCompaniaAereaDTO = Convert.ToInt32(ddlTransporte.SelectedValue);

            detalle.ServicioTraslado = servicioTraslado;

            if (ddlAlojamiento.SelectedValue != "")
            {
                DateTime fechaDesdeAlojamiento = CommonBase.DateTime_NullValue;
                DateTime fechaHastaAlojamiento = CommonBase.DateTime_NullValue;

                ServicioAlojamientoDTO alojamiento = new ServicioAlojamientoDTO();
                alojamiento.IsNew = true;
                alojamiento.idAlojamientoDTO = Int32.Parse(ddlAlojamiento.SelectedValue);

                if (txtFechaDesdeAlojamiento.Text != "" && !DateTime.TryParseExact(txtFechaDesdeAlojamiento.Text, "dd/MM/yyyy", new CultureInfo("es-AR"), DateTimeStyles.None, out fechaDesdeAlojamiento))
                {
                    DangerMessage.Visible = true;
                    LblDanger.Text = "El formato de la fecha desde del alojamiento debe ser dd/MM/yyyy.";
                    return;
                }

                if (txtFechaHastaAlojamiento.Text != "" && !DateTime.TryParseExact(txtFechaHastaAlojamiento.Text, "dd/MM/yyyy", new CultureInfo("es-AR"), DateTimeStyles.None, out fechaHastaAlojamiento))
                {
                    DangerMessage.Visible = true;
                    LblDanger.Text = "El formato de la fecha hasta del alojamiento debe ser dd/MM/yyyy.";
                    return;
                }

                alojamiento.fechaDesdeDTO = fechaDesdeAlojamiento;
                alojamiento.fechaHastaDTO = fechaHastaAlojamiento;


                detalle.Alojamiento = alojamiento;
            }


            if (ddlTipoSeguro.SelectedValue != "")
            {
                SeguroViajeroDTO seguro = new SeguroViajeroDTO();
                seguro.IsNew = true;
                
                if (Int32.Parse(ddlTipoSeguro.SelectedValue) > 0)
                {
                    seguro.TipoSeguroViajero = Int32.Parse(ddlTipoSeguro.SelectedValue);
                }
                if (txtObservaciones.Text != "")
                {
                    seguro.Descripcion = txtObservaciones.Text;
                }


            }



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