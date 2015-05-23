using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ControlPacientesWeb.Consultas
{
    public partial class SistemasFisiologicoWeb : System.Web.UI.Page
    {
        SistemasFisiologico sistemas = new SistemasFisiologico();
        private string filtro = "1=1";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SistemasGridView.DataSource = sistemas.Listar("IdSistema as Codigo, Nombre ",filtro);
                SistemasGridView.DataBind();
            }
            
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            SistemasGridView.DataSource = sistemas.Listar("IdSistema as Codigo, Nombre ", " Nombre like '%"+FiltrarTextBox.Text+"%'");
            SistemasGridView.DataBind();
        }
    }
}