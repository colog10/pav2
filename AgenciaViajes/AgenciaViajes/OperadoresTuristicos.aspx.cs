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
            if (!IsPostBack)
            {
                LoadData();
                InicializarPantalla();                
            }
            else
            {
                ReloadData();
            }
        }

        private void InicializarPantalla()
        {
            SectionConsulta.Visible = true;
            SectionAltaModificacion.Visible = false;
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            //txtBuscar.Text = "";
            //txtNombreOperadorTuristico.Text = "";
            //txtNombreContacto.Text = "";
            //txtDomicilio.Text = "";            
        }

      

        private void ReloadData()
        {
            if (termino != txtBuscar.Text)
            {
                termino = txtBuscar.Text;
                List<OperadorTuristicoDTO> operadorTuristico = OperadorTuristicoManager.GetOperadorTuristico(termino);
                gvOperadoresTuristicos.DataSource = operadorTuristico;
                gvOperadoresTuristicos.DataBind();
            }
        }

        private void LoadData()
        {
            List<OperadorTuristicoDTO> operadoresTuristicos = OperadorTuristicoManager.GetOperadorTuristico();
            gvOperadoresTuristicos.DataSource = operadoresTuristicos;
            gvOperadoresTuristicos.DataBind();
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            SectionAltaModificacion.Visible = true;
            SectionConsulta.Visible = false;

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            SectionAltaModificacion.Visible = false;
            SectionConsulta.Visible = true;

        }
    }
}