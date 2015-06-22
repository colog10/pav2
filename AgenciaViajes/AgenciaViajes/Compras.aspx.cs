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
    public partial class Compras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarCombos();
            }
        }

        private void CargarCombos()
        {
            List<OperadorTuristicoDTO> operadores = new List<OperadorTuristicoDTO>();
            OperadorTuristicoDTO operadorNoEspecificado = new OperadorTuristicoDTO();
            operadorNoEspecificado.Descripcion = "SELECCIONE";
            operadorNoEspecificado.IdOperadorTuristico = 0;
            operadores.Add(operadorNoEspecificado);
            operadores.AddRange(OperadorTuristicoManager.GetOperadorTuristico());
            ddlOperadorTuristico.DataSource = operadores;
            ddlOperadorTuristico.DataValueField = "idOperadorTuristico";
            ddlOperadorTuristico.DataTextField = "descripcion";
            ddlOperadorTuristico.DataBind();
        }

        protected void btnBuscarCompra_Click(object sender, EventArgs e)
        {
            DateTime fechaCompra = CommonBase.DateTime_NullValue;
            DateTime fechaReserva = CommonBase.DateTime_NullValue;
            int nroFactura = CommonBase.Int_NullValue;
            int idOperadorTuristico = CommonBase.Int_NullValue;


            if (txtFechaCompra.Text != "" && !DateTime.TryParseExact(txtFechaCompra.Text, "dd/MM/yyyy", new CultureInfo("es-AR"), DateTimeStyles.None, out fechaCompra))
            {
                DangerMessage.Visible = true;
                LblDanger.Text = "El formato de la fecha de compra debe ser dd/MM/yyyy.";
                return;
            }

            if (txtFechaReserva.Text != "" && !DateTime.TryParseExact(txtFechaReserva.Text, "dd/MM/yyyy", new CultureInfo("es-AR"), DateTimeStyles.None, out fechaReserva))
            {
                DangerMessage.Visible = true;
                LblDanger.Text = "El formato de la fecha de reserva debe ser dd/MM/yyyy.";
                return;
            }

            if(txtNumeroFactura.Text != ""){
                nroFactura = Convert.ToInt32(txtNumeroFactura.Text);
            }

            if(Convert.ToInt32(ddlOperadorTuristico.SelectedValue) > 0){
                idOperadorTuristico = Convert.ToInt32(ddlOperadorTuristico.SelectedValue);
            }

            gvCompras.DataSource = CompraManager.GetCompras(fechaCompra, fechaReserva, nroFactura, idOperadorTuristico);
            gvCompras.DataBind();

        }
    }
}