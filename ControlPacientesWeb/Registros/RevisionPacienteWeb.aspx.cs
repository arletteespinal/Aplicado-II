using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ControlPacientesWeb.Registros
{
    public partial class RevisionPacienteWeb : System.Web.UI.Page
    {
        private RevisionPaciente revision = new RevisionPaciente();
        private SistemasFisiologico sistemas = new SistemasFisiologico();
        private Pacientes pacientes = new Pacientes();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                SistemasDropDownList.DataSource = sistemas.Listar("IdSistema as CodigoSistema, Nombre", " 1=1");
                SistemasDropDownList.DataValueField = "CodigoSistema";
                SistemasDropDownList.DataTextField = "Nombre";
                SistemasDropDownList.DataBind();

                PacientesDropDownList.DataSource = pacientes.NombreCompleto();
                PacientesDropDownList.DataValueField = "Codigo";
                PacientesDropDownList.DataTextField = "NombreCompleto";
                PacientesDropDownList.DataBind();
            }

        }
        

        protected void AgregarButton_Click(object sender, EventArgs e)
        {
            DataTable datos = new DataTable();

            if (Session["datos"] == null)
            {
                datos = new DataTable();
                datos.Columns.Add(new DataColumn("Codigo"));
                datos.Columns.Add(new DataColumn("CodigoSistema"));
                datos.Columns.Add(new DataColumn("Sistema"));
                datos.Columns.Add(new DataColumn("Estado"));

            }

            else
            {
                datos = Session["datos"] as DataTable;
            }

            DataRow row = datos.NewRow();
            row["CodigoSistema"] = SistemasDropDownList.SelectedValue;
            row["Sistema"] = SistemasDropDownList.SelectedItem;
            row["Estado"] = EstadoTextBox.Text;
            datos.Rows.Add(row);

            Session["datos"] = datos;
            DetalleGridView.DataSource = datos;
            DetalleGridView.DataBind();
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {

          
        }
        

        protected void QuitarButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}