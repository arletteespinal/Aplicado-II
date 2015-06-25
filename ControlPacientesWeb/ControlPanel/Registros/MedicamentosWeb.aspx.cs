using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ControlPacientesWeb.ControlPanel.Registros
{
    public partial class MedicamentosWeb : System.Web.UI.Page
    {
        private Medicamentos medicamentos = new Medicamentos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = 0;
                int.TryParse(Request.QueryString["Codigo"], out id);
                if (medicamentos.Buscar(id))
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
            CodigoTextBox.Text = medicamentos.IdMedicamento.ToString();
            DescripcionTextBox.Text = medicamentos.Descripcion;
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            medicamentos.Descripcion = DescripcionTextBox.Text;
            if (CodigoTextBox.Text == string.Empty)
            {

                if (medicamentos.Insertar())
                {

                }
            }
            else
            {
                medicamentos.IdMedicamento = int.Parse(CodigoTextBox.Text);
                if (medicamentos.Modificar())
                {

                }
            }
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            medicamentos.IdMedicamento = int.Parse(CodigoTextBox.Text);
            if (medicamentos.Eliminar())
            {

            }
        }
    }
}