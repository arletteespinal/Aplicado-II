using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ControlPacientesWeb.ControlPanel.Consultas
{
    public partial class CRecetaDetalleWeb : System.Web.UI.Page
    {
        private RecetaPacientes receta = new RecetaPacientes();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                int id = 0;
                int.TryParse(Request.QueryString["Codigo"], out id);
                DetalleGridView.DataSource = receta.Listar(" rd.IdRecetaDetalle as Codigo, m.IdMedicamento as CodigoMedicamento, m.Descripcion as Medicamento,rd.Frecuencia ", " RecetaDetalle rd join Medicamentos m on m.IdMedicamento = rd.IdMedicamento ", " IdReceta='" + id + "'");
                DetalleGridView.DataBind();
            }
        }
    }
}