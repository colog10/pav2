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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                seccionReserva.Visible = true;
                sectionDetalleReserva.Visible = false;
                cargarGrillaPasajeros();
                
            }
        }

        private void cargarGrillaPasajeros()
        {
            ReservaManager.Reservas_getAll();
            List<Reservas> ListaDeReservas = new List<Reservas>();
            gvListaDeReservas.DataSource = ListaDeReservas;
            gvListaDeReservas.DataBind();
        }
    }
}