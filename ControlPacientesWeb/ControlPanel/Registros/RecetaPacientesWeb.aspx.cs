using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ControlPacientesWeb.ControlPanel.Registros
{
    public partial class RecetaPacientesWeb : System.Web.UI.Page
    {
        private RecetaPacientes receta = new RecetaPacientes();
        private Medicamentos medicamentos = new Medicamentos();
        private Pacientes pacientes = new Pacientes();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = 0;
                int.TryParse(Request.QueryString["Codigo"], out id);
                if (receta.Buscar(id))
                {
                    Buscar(id);

                }
                if (CodigoTextBox.Text == string.Empty)
                {
                    EliminarButton.Enabled = false;

                }
                else
                {
                    EliminarButton.Enabled = true;

                }

                MedicamentosDropDownList.DataSource = medicamentos.Listar("IdMedicamento as CodigoMedicamento, Descripcion", " 1=1");
                MedicamentosDropDownList.DataValueField = "CodigoMedicamento";
                MedicamentosDropDownList.DataTextField = "Descripcion";
                MedicamentosDropDownList.DataBind();

                PacientesDropDownList.DataSource = pacientes.NombreCompleto();
                PacientesDropDownList.DataValueField = "Codigo";
                PacientesDropDownList.DataTextField = "NombreCompleto";
                PacientesDropDownList.DataBind();

                Session.Abandon();
            }

        }

        private void Buscar(int idR)
        {
            CodigoTextBox.Text = receta.IdRecetaPaciente.ToString();
            FechaTextBox.Text = receta.Fecha.ToString("MM/dd/yyyy");
            PacientesDropDownList.SelectedValue = receta.IdPaciente.ToString();
            DetalleGridView.DataSource = receta.Listar(" m.IdMedicamento as CodigoMedicamento, m.Descripcion as Medicamento, m.Frecuencia ", "  RecetaDetalle rd join Medicamentos m on rd.IdMedicamento=m.IdMedicamento ", " IdReceta='" + idR + "'");
            DetalleGridView.DataBind();

        }

        protected void AgregarButton_Click(object sender, EventArgs e)
        {
            if (CodigoTextBox.Text == string.Empty)
            {

                if (Session["receta"] != null)
                {
                    receta = (RecetaPacientes)Session["receta"];
                }

                receta.agregarRecetaDetalle(Convert.ToInt32(MedicamentosDropDownList.SelectedValue),FrecuenciaTextBox.Text);

                DetalleGridView.DataSource = receta.RecetaDetalle;
                DetalleGridView.DataBind();

                Session["receta"] = receta;
            }
            else
            {

            }
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            // receta.Fecha = Convert.ToDateTime(FechaTextBox.Text);


            if (CodigoTextBox.Text == string.Empty)
            {

                if (Session["receta"] != null)
                {
                    receta = (RecetaPacientes)Session["receta"];
                }

                receta.Fecha = DateTime.Now;
                receta.IdPaciente = Convert.ToInt32(PacientesDropDownList.SelectedValue);


                if (receta.Insertar())
                {

                }

            }
            else
            {
                int id = 0;
                int.TryParse(CodigoTextBox.Text, out id);
                receta.IdRecetaPaciente = id;

                if (receta.Modificar())
                {


                }
            }
            
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                int.TryParse(CodigoTextBox.Text, out id);
                receta.IdRecetaPaciente = id;
                if (receta.Eliminar())
                {

                }
            }
            catch (Exception)
            {

            }
        }
    }
}