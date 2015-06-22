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

        private void OcultarMensajes()
        {
            DangerMessage.Visible = false;
            InfoMessage.Visible = false;
            SuccessMessage.Visible = false;
            WarningMessage.Visible = false;
        }


        private void InicializarReserva()
        {
            
            List<ReservaDTO> det = ReservaManager.Reservas_getAll();
            gvReserva.DataSource =det ;
            gvReserva.DataBind();

        }

        
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
         
        }


        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            OcultarMensajes();
            try{

                
            List<VentaDetalleDTO> detalles = new List<VentaDetalleDTO>();
            ReservaDTO reserva = (ReservaDTO)Session["Reserva"];
            
            List<ReservaDetalleDTO> detallesReserva = (List<ReservaDetalleDTO>)Session["detalles"];



            foreach (ReservaDetalleDTO dr in detallesReserva)
            {
                if(!dr.Comprada){
                    DangerMessage.Visible = true;
                    LblDanger.Text = "No se puede realizar la venta porque uno o mas items no han sido comprados.";
                    return;
                }

                if (dr.Efectuada)
                {
                    DangerMessage.Visible = true;
                    LblDanger.Text = "No se puede realizar la venta porque uno o mas items ya han sido vendidas.";
                    return;
                }
                VentaDetalleDTO vd = new VentaDetalleDTO();
                dr.IsNew = true;
                vd.idDetalleReservaDTO = dr.IdDetallaReserva;
                vd.idTipoDocumentoViajeDTO = dr.IdDocumentoViaje;
                vd.idPasajeroDTO = dr.IdPasajero;
                vd.idSeguroViajeroDTO = dr.IdSeguroViajero;
                vd.idSeguroViajeroDTO = dr.IdServicioAlojamiento;
                vd.idServicioTrasladoDTO = dr.IdServicioTraslado;
                vd.Monto = dr.Monto;
                detalles.Add(vd);
            }

            VentaDTO venta = new VentaDTO();
            venta.IsNew = true;
            venta.idClienteDTO = reserva.IdCliente;
            venta.fechaVentaDTO = DateTime.Now;
            if (txtComision.Text != "")
                venta.comisionDTO = float.Parse(txtComision.Text);
            venta.NumeroFactura = Convert.ToInt32(txtNroFactura.Text);
            venta.DetallesVenta = detalles;
            VentaManager.SaveVenta(venta);

            SuccessMessage.Visible = true;
            LblSuccess.Text = "La venta se ha guardado correctamente";
            VentaSection.Visible = false;
            SectionDetalleReserva.Visible = false;
            
            }
            catch(Exception){
                DangerMessage.Visible = true;
                LblDanger.Text = "No se pudo guardar la venta, verifique que los datos ingresados sean válidos.";
            }
        }

        
        private void InicializarDetalleReserva(int idReserva)
        {
            OcultarMensajes();
            List<ReservaDetalleDTO> det = DetalleReservaManager.GetDetalleByReserva(idReserva);
            gvDetalleReserva.DataSource = det;
            gvDetalleReserva.DataBind();
            CalcularMonto(det);
            Session["detalles"] = det;
        }

        private void CalcularMonto(List<ReservaDetalleDTO> det)
        {
            decimal MontoTotal=0;
            foreach (ReservaDetalleDTO re in det)
            {
                MontoTotal += re.Monto;
            }
            txtMontoTotal.Text = Convert.ToString(MontoTotal);
        }


        protected void gvReserva_SelectedIndexChanged(object sender, EventArgs e)
        {
            OcultarMensajes();
            VentaSection.Visible = false;
            SectionDetalleReserva.Visible = true;
            int st = Convert.ToInt32(gvReserva.SelectedValue);
            Session["Reserva"] = ReservaManager.GetReservasByID(st);
            InicializarDetalleReserva(st);
        }

        protected void gvReserva_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvDetalleReserva.PageIndex = e.NewPageIndex;
            InicializarReserva();
        }

    }
}