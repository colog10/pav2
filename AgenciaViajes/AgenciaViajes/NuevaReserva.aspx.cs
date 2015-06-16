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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                reservaDetalleSection.Visible = false;
                InicializarDetalleReserva();
            }

        }

        private void InicializarDetalleReserva()
        {
            gvPasajeros.DataSource = new List<PasajeroDTO>();
            gvPasajeros.DataBind();
        }

        protected void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string filtroBusqueda = txtCliente.Text;
            gvClientes.DataSource = ClienteManager.GetClienteByRazonSocialOrCuil(filtroBusqueda);
            gvClientes.DataBind();
        }
    }
}