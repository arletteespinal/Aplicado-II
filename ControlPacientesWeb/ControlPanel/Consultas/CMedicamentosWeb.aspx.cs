using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ControlPacientesWeb.ControlPanel.Consultas
{
    public partial class CMedicamentosWeb : System.Web.UI.Page
    {
        private Medicamentos medicamentos = new Medicamentos();
        protected void Page_Load(object sender, EventArgs e)
        {
            MedicamentosGridView.DataSource = medicamentos.Listar("IdMedicamento as Codigo, Descripcion","1=1");
            MedicamentosGridView.DataBind();
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            MedicamentosGridView.DataSource = medicamentos.Listar("IdMedicamento as Codigo, Descripcion", " Descripcion like '%"+DescripcionTextBox.Text+"%'");
            MedicamentosGridView.DataBind();
        }
    }
}