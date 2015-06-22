using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AgenciaDeViajesDAL.DAL;
using AgenciaDeViajesDTO.Entities;
using AgenciaDeViajesBLL;

namespace AgenciaViajes
{
    public partial class NuevaCompra : System.Web.UI.Page
    {
        List<CompraDetalleDTO> detalles = new List<CompraDetalleDTO>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InicializarReserva();
                CargarCombos();
            }

        }

        private void CargarCombos()
        {
            ddlOperadorTuristico.DataSource = OperadorTuristicoManager.GetOperadorTuristico();
            ddlOperadorTuristico.DataValueField = "IdOperadorTuristico";
            ddlOperadorTuristico.DataTextField = "Descripcion";
            ddlOperadorTuristico.DataBind();
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
            gvReserva.DataSource = det;
            gvReserva.DataBind();

        }


        protected void btnCancelar_Click(object sender, EventArgs e)
        {

        }


        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try{
                decimal montoCompra = 0;
                OcultarMensajes();
                List<CompraDetalleDTO> detalles = new List<CompraDetalleDTO>();
                ReservaDTO reserva = (ReservaDTO)Session["Reserva"];

                List<ReservaDetalleDTO> detallesReserva = (List<ReservaDetalleDTO>)Session["detalles"];

                foreach (ReservaDetalleDTO dr in detallesReserva)
                {

                    if (dr.Comprada)
                    {
                        DangerMessage.Visible = true;
                        LblDanger.Text = "No se puede realizar la compra porque uno o mas items ya han sido comprados.";
                        return;
                    }


                    CompraDetalleDTO cd = new CompraDetalleDTO();
                    dr.IsNew = true;
                    cd.idDetalleReservaDTO = dr.IdDetallaReserva;
                    cd.Monto = Math.Round(dr.Monto / (decimal)1.10, 2);
                    cd.descripcionDTO = "Pasajero: " + dr.NombrePasajero + " - Translado: " + dr.NombreTraslado + " - Alojamiento: " + dr.NombreAlojamiento + " - Seguro: " + dr.NombreSeguro; 
                    detalles.Add(cd);
                    montoCompra += cd.Monto;
                }

                CompraDTO compra = new CompraDTO();
                compra.IsNew = true;
                compra.idOperadorTuristicoDTO = Convert.ToInt32(ddlOperadorTuristico.SelectedValue);
                compra.fechaCompraDTO = DateTime.Now;
                compra.montoDTO = montoCompra;
                compra.saldoDTO = montoCompra;
                compra.Detalles = detalles;
                compra.IdReserva = reserva.IdReserva;
            
                compra.NumeroFactura = Convert.ToInt32(txtNroFactura.Text);
            
                CompraManager.SaveCompra(compra);

                SuccessMessage.Visible = true;
                LblSuccess.Text = "La compra se ha guardado correctamente";
                CompraSection.Visible = false;
                SectionDetalleReserva.Visible = false;
            }
            catch (Exception)
            {
                DangerMessage.Visible = true;
                LblDanger.Text = "No se pudo guardar la compra, verifique que los datos ingresados sean válidos.";
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
            decimal MontoTotal = 0;
            foreach (ReservaDetalleDTO re in det)
            {
                MontoTotal += (re.Monto / (decimal)1.10);
            }
            txtMontoTotal.Text = Convert.ToString(Math.Round(MontoTotal, 2));
        }


        protected void gvReserva_SelectedIndexChanged(object sender, EventArgs e)
        {
            OcultarMensajes();
            CompraSection.Visible = false;
            SectionDetalleReserva.Visible = true;
            int st = Convert.ToInt32(gvReserva.SelectedValue);
            Session["Reserva"] = ReservaManager.GetReservasByID(st);
            InicializarDetalleReserva(st);
        }

    }
}