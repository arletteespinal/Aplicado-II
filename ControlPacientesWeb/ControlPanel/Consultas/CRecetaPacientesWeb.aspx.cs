using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ControlPacientesWeb.ControlPanel.Consultas
{
    public partial class CRecetaPacientesWeb : System.Web.UI.Page
    {
        private RecetaPacientes receta = new RecetaPacientes();
        private string filtro = "1=1";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                recetaGridView.DataSource = receta.Listar("IdReceta as Codigo, Fecha, p.Nombres+' '+p.Apellidos as NombreCompleto ", " RecetaPacientes rp join Pacientes p on p.IdPaciente=rp.IdPaciente ", filtro);
                recetaGridView.DataBind();
            }
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
             if (FiltroDropDownList.SelectedIndex == 0)
            {
                filtro = " Nombres like '%" + FiltroTextBox.Text + "%'";
            }

            if (FiltroDropDownList.SelectedIndex == 1)
            {
                filtro = " Apellidos like '%" + FiltroTextBox.Text + "%'";
            }

            recetaGridView.DataSource = receta.Listar("IdReceta as Codigo, Fecha, p.Nombres+' '+p.Apellidos as NombreCompleto", " RecetaPacientes rp join Pacientes p on p.IdPaciente=rp.IdPaciente ", filtro);
            recetaGridView.DataBind();
        }
    }
}