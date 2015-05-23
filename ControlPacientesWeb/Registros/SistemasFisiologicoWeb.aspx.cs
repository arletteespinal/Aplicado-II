using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ControlPacientesWeb.Registros
{
    public partial class SistemasFisiologicoWeb : System.Web.UI.Page
    {
        SistemasFisiologico sistema = new SistemasFisiologico();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = 0;
                int.TryParse(Request.QueryString["Codigo"], out id);
                if (sistema.Buscar(id))
                {
                    Buscar();

                }
                if (CodigoTextBox.Text == string.Empty)
                {
                    EliminarButton.Enabled = false;
                }
                else
                {
                    EliminarButton.Enabled = true;
                }
            }
        }

        private void Buscar()
        {
            NombreTextBox.Text = sistema.Nombre;
            CodigoTextBox.Text = sistema.IdSistema.ToString();
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            sistema.Nombre = NombreTextBox.Text;
            if (CodigoTextBox.Text == string.Empty)
            {
                if (sistema.Insertar())
                {
                    
                }
            }
            else
            {
                int id = 0;
                int.TryParse(CodigoTextBox.Text, out id);
                sistema.IdSistema = id;
                if (sistema.Modificar())
                {

                }
            }
        }
       

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(CodigoTextBox.Text, out id);
            sistema.IdSistema = id;
            if (sistema.Eliminar())
            {

            }
        }
    }
}