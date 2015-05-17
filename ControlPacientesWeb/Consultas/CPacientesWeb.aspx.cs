using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ControlPacientesWeb.Consultas
{
    public partial class CPacientesWeb : System.Web.UI.Page
    {
        private Pacientes pacientes = new Pacientes();
        private string filtro = "1=1";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PacientesGridView.DataSource = pacientes.Listar("IdPaciente as Codigo,FechaIngreso,Nombres,Apellidos,Cedula,FechaNacimiento,(CASE WHEN Genero = 1 THEN 'Masculino' ELSE CASE WHEN Genero = 0 THEN 'Femenino' END END) as Genero,Celular,Telefono,Direccion,Ocupacion", filtro);
                PacientesGridView.DataBind();
            }
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
           
            if (FiltroDropDownList.SelectedIndex == 0)
            {
                filtro = " Nombres like '%"+FiltroTextBox.Text+"%'";
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

            PacientesGridView.DataSource = pacientes.Listar("IdPaciente as Codigo,FechaIngreso,Nombres,Apellidos,Cedula,FechaNacimiento,(CASE WHEN Genero = 1 THEN 'Masculino' ELSE CASE WHEN Genero = 0 THEN 'Femenino' END END) as Genero,Celular,Telefono,Direccion,Ocupacion", filtro);
            PacientesGridView.DataBind();
        }
    }
}