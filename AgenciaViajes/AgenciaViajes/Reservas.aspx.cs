using AgenciaDeViajesBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AgenciaViajes
{
    public partial class Reservas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        
        protected void btnBuscarReserva_Click(object sender, EventArgs e)
        {
            int monto = 0;
            Int32.TryParse(txtMonto.Text, out monto);
            DateTime fecha;
            DateTime.TryParse(txtFechaReserva.Text, out fecha); 
            bool efectuada = chkEfectuada.Checked;
            gvReservas.DataSource = ReservaManager.GetInforme(monto, fecha, efectuada);
            gvReservas.DataBind();
            
        }
    }
}