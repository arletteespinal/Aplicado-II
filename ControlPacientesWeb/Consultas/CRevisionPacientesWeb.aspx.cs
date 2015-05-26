using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ControlPacientesWeb.Consultas
{
    public partial class CRevisionPacientesWeb : System.Web.UI.Page
    {
        private RevisionPaciente revision = new RevisionPaciente();
        private string filtro = "1=1";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RevisionGridView.DataSource = revision.Listar("IdRevision as Codigo, Fecha, p.Nombres+' '+p.Apellidos as NombreCompleto "," RevisionPaciente rp join Pacientes p on p.IdPaciente=rp.IdPaciente ",filtro);
                RevisionGridView.DataBind();
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

            if (FiltroDropDownList.SelectedIndex == 2)
            {
                filtro = " Cedula='" + FiltroTextBox.Text + "'";
            }

            if (FiltroDropDownList.SelectedIndex == 3)
            {
                filtro = "FechaIngreso between '2015-05-16' and '2015-05-16'";
            }

            RevisionGridView.DataSource = revision.Listar("IdRevision as Codigo, Fecha, p.Nombres+' '+p.Apellidos as NombreCompleto", " RevisionPaciente rp join Pacientes p on p.IdPaciente=rp.IdPaciente ", filtro);
            RevisionGridView.DataBind();
        }
    }
}