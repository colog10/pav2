using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AgenciaDeViajesBLL;
using AgenciaDeViajesDTO.Entities;

namespace AgenciaViajes
{
    public partial class OperadoresTuristicos : System.Web.UI.Page
    {
        private string termino = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    LoadData();
            //    ConsultaSection.Visible = true;
            //    altaModificacionSection.Visible = false;

            //}
            //else
            //{
            //    ReloadData();
            //}
        }

        private void ReloadData()
        {
            //if (termino != txtBuscar.Text)
            //{
            //    termino = txtBuscar.Text;
            //    List<OperadorTuristicoDTO> operadorTuristico = OperadorTuristicoManager.GetOperadorTuristico(termino);
            //    gvOperadoresTuristicos.DataSource = operadorTuristico;
            //    gvOperadoresTuristicos.DataBind();
            //}
        }

        private void LoadData()
        {
            //throw new NotImplementedException();
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {


        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}