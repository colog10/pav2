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
    public partial class NuevaVenta : System.Web.UI.Page
    {
        List<VentaDetalleDTO> detalles = new List<VentaDetalleDTO>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InicializarReserva();
            }

        }

        private void InicializarReserva()
        {
            gvDetalleReserva.Visible = false;
            List<ReservaDTO> det = ReservaManager.Reservas_getAll();
                      
            gvReserva.DataSource =det ;
            gvReserva.DataBind();

        }

        protected void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            String filtroBusqueda = txtCliente.Text;
            gvReserva.DataSource = ReservaManager.GetCliente(filtroBusqueda);
            gvReserva.DataBind();
        }


        protected void btnCancelar_Click(object sender, EventArgs e)
        {
         
        }


        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            VentaDTO venta = new VentaDTO();
            venta.IsNew = true;
            //venta.NumeroReserva = Convert.ToInt32(txtNumero.Text);
            //venta.IdCliente = Convert.ToInt32(gvDetalleVenta.SelectedDataKey.Value);
            //venta.DetallesReserva = detalles;
            //ReservaManager.Save(venta);
        }



        protected void btnAceptar_Click1(object sender, EventArgs e)
        {
            VentaDetalleDTO detalle = new VentaDetalleDTO();

            //detalle.IdPasajero = Convert.ToInt32(gvPasajeros.SelectedDataKey.Value);
            //detalle.Pasajero = PasajeroManager.GetPasajeroByID(detalle.IdPasajero);

            //detalle.NumeroDocumento = txtNumeroDocumentoViaje.Text;
            //detalle.IdTipoDocumento = Convert.ToInt32(ddlDocumentoViaje.SelectedValue);
            detalles.Add(detalle);
            //gvDetalleReserva.DataSource = detalles;
            //gvDetalleReserva.DataBind();
            //LimpiarCamposDetalle();
            //reservaDetalleSection.Visible = false;
            //reservaSection.Visible = true;
        }

        protected void actualizarDetalle(object sender, EventArgs e)
        {
            ReservaDetalleDTO detalle = new ReservaDetalleDTO();
        }



        private void InicializarDetalleReserva(int idReserva)
        {

            List<ReservaDetalleDTO> det = DetalleReservaManager.GetDetalleByReserva(idReserva);

            gvDetalleReserva.DataSource = det;
            gvDetalleReserva.DataBind();

        }

        protected void gvReserva_SelectedIndexChanged(object sender, EventArgs e)
        {
            VentaSection.Visible = false;
            SectionDetalleReserva.Visible = true;
            int st = Convert.ToInt32(gvReserva.SelectedValue);
            InicializarDetalleReserva(st);

        }

    }
}