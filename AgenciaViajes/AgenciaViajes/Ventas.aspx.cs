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
    public partial class Ventas : System.Web.UI.Page
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
            List<EmpleadoDTO> empleados = new List<EmpleadoDTO>();
            EmpleadoDTO empleadoNoEspecificado = new EmpleadoDTO();
            empleadoNoEspecificado.Nombre = "SELECCIONE";
            empleadoNoEspecificado.IdEmpleado = 0;
            empleados.Add(empleadoNoEspecificado);
            empleados.AddRange(EmpleadoManager.GetEmpleados());
            ddlVendedor.DataSource = empleados;
            ddlVendedor.DataValueField = "IdEmpleado";
            ddlVendedor.DataTextField = "Nombre";
            ddlVendedor.DataBind();
        }

        protected void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            DateTime fechaVenta = CommonBase.DateTime_NullValue;
            string nombreCliente = CommonBase.String_NullValue;
            int nroFactura = CommonBase.Int_NullValue;
            int idVendedor = CommonBase.Int_NullValue;


            if (txtFechaVenta.Text != "" && !DateTime.TryParseExact(txtFechaVenta.Text, "dd/MM/yyyy", new CultureInfo("es-AR"), DateTimeStyles.None, out fechaVenta))
            {
                DangerMessage.Visible = true;
                LblDanger.Text = "El formato de la fecha de venta debe ser dd/MM/yyyy.";
                return;
            }

            
            if (txtNumeroFactura.Text != "")
            {
                nroFactura = Convert.ToInt32(txtNumeroFactura.Text);
            }

            if (txtCliente.Text != "")
            {
                nombreCliente = txtCliente.Text;
            }

            if (Convert.ToInt32(ddlVendedor.SelectedValue) > 0)
            {
                idVendedor = Convert.ToInt32(ddlVendedor.SelectedValue);
            }

            gvVentas.DataSource = VentaManager.GetVentas(fechaVenta, nroFactura, nombreCliente, idVendedor); ;
            gvVentas.DataBind();

        }

    }
}