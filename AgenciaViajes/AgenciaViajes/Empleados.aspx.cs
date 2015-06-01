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
    public partial class Empleados : System.Web.UI.Page
    {
        private string Termino = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
                ConsultaSection.Visible = true;
                altaModificacionSection.Visible = false;
                
            } else{
                ReloadData();
            }
        }

        private void ReloadData()
        {
            if (Termino != txtBuscar.Text) {
                Termino = txtBuscar.Text;
                List<EmpleadoDTO> empleados = EmpleadoManager.GetEmpleados(Termino);
                gvEmpleados.DataSource = empleados;
                gvEmpleados.DataBind();
            }
        }

        private void LoadData()
        {
            List<EmpleadoDTO> empleados = EmpleadoManager.GetEmpleados();
            gvEmpleados.DataSource = empleados;
            gvEmpleados.DataBind();
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            ConsultaSection.Visible = false;
            altaModificacionSection.Visible = true;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

        }


    }
}