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
    public partial class Reservas : System.Web.UI.Page
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
            empleadoNoEspecificado.IdEmpleado = 0;
            empleadoNoEspecificado.Nombre = "SELECCIONE";
            empleados.Add(empleadoNoEspecificado);
            empleados.AddRange(EmpleadoManager.GetEmpleados());
            ddlEmpleado.DataSource = empleados;
            ddlEmpleado.DataTextField = "Nombre";
            ddlEmpleado.DataValueField = "IdEmpleado";
            ddlEmpleado.DataBind();
        }

        
        protected void btnBuscarReserva_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        public void LoadData()
        {


            int idEmpleado = CommonBase.Int_NullValue;
            int monto = CommonBase.Int_NullValue;
            DateTime fecha = CommonBase.DateTime_NullValue;
            bool efectuada = chkEfectuada.Checked;

            if (txtFechaReserva.Text != "" && !DateTime.TryParseExact(txtFechaReserva.Text, "dd/MM/yyyy", new CultureInfo("es-AR"), DateTimeStyles.None, out fecha))
            {
                DangerMessage.Visible = true;
                LblDanger.Text = "El formato de la fecha de compra debe ser dd/MM/yyyy.";
                return;
            }

            if (Convert.ToInt32(ddlEmpleado.SelectedValue) > 0)
            {
                idEmpleado = Convert.ToInt32(ddlEmpleado.SelectedValue);
            }
            if (txtMonto.Text != "") { 
                monto = Convert.ToInt32(txtMonto.Text);
            }
            gvReservas.DataSource = ReservaManager.GetInforme(monto, fecha, efectuada, idEmpleado);
            gvReservas.DataBind();
            
        }
        protected void gvReservas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            LoadData();
        }
    }
}