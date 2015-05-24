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

            revision.Fecha = DateTime.Now;
            revision.IdPaciente =Convert.ToInt32( PacientesDropDownList.SelectedValue);
            revision.IdSistema = 1;
            revision.Estado = "hola";
            revision.IdSistema = 1;
            revision.Estado = "no se";

            if (CodigoTextBox.Text == string.Empty)
            {
                if (revision.InsertarRevision())
                {
                    if (revision.BuscarIdRevision())
                    {
                        CodigoTextBox.Text = revision.IdRevision.ToString();
                    }
                    DataTable datos = Session["datos"] as DataTable;
                    foreach (DataRow row in datos.Rows)
                    {

                        revision.IdSistema = int.Parse(row["CodigoSistema"].ToString());
                        revision.Estado = row["Estado"].ToString();
                        revision.InsertarRevisionDetalle();
                    }
                }
            }
            else
            {
                int id = 0;
                int.TryParse(CodigoTextBox.Text, out id);
                revision.IdSistema = id;
                if (revision.ModificarRevision())
                {

                    DataTable datos = Session["datos"] as DataTable;
                    foreach (DataRow row in datos.Rows)
                    {
                        revision.IdSistema = int.Parse(row["CodigoSistema"].ToString());
                        revision.Estado = row["Estado"].ToString();
                        revision.ModificarRevisionDetalle();
                    }
                }
            }
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(CodigoTextBox.Text, out id);
            revision.IdRevision = id;
            if (revision.EliminarRevisionDetalle())
            {
                revision.EliminarRevision();
            }
        }

    }
}