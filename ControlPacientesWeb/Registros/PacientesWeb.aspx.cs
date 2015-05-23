using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ControlPacientesWeb.Registros
{
    public partial class PacientesWeb : System.Web.UI.Page
    {
        private Pacientes pacientes = new Pacientes();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = 0;
                int.TryParse(Request.QueryString["Codigo"], out id);
                if (pacientes.Buscar(id))
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
            CodigoTextBox.Text = pacientes.IdPaciente.ToString();
            NombresTextBox.Text = pacientes.Nombres;
            ApellidosTextBox.Text = pacientes.Apellidos;
            //FechaIngresoTextBox.Text = pacientes.FechaIngreso.ToString("MM/dd/yyyy");
            FechaNacimientoTextBox.Text = pacientes.FechaNacimiento.ToString("MM/dd/yyyy");
            GeneroDropDownList.SelectedIndex = pacientes.Genero;
            TelefonoTextBox.Text = pacientes.Telefono;
            CelularTextBox.Text = pacientes.Celular;
            DireccionTextBox.Text = pacientes.Direccion;
            OcupacionTextBox.Text = pacientes.Ocupacion;
            CedulaTextBox.Text = pacientes.Cedula;

        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            int genero = 0;
            int.TryParse(GeneroDropDownList.SelectedValue, out genero);
            pacientes.Genero = genero;
            pacientes.Nombres = NombresTextBox.Text;
            pacientes.Apellidos = ApellidosTextBox.Text;
            pacientes.Cedula = CedulaTextBox.Text;
            pacientes.Celular = CelularTextBox.Text;
            pacientes.Telefono = TelefonoTextBox.Text;
            pacientes.Ocupacion = OcupacionTextBox.Text;
            pacientes.Direccion = DireccionTextBox.Text;
            pacientes.FechaIngreso = DateTime.Now;
            pacientes.FechaNacimiento = DateTime.Now;


            if (CodigoTextBox.Text == string.Empty)
            {
                if (pacientes.Insertar())
                {
                   
                }
            }
            else
            {
                int id = 0;
                int.TryParse(CodigoTextBox.Text, out id);
                pacientes.IdPaciente = id;
                if (pacientes.Modificar())
                {

                }
            }
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(CodigoTextBox.Text, out id);
            pacientes.IdPaciente = id;
            if (pacientes.Eliminar())
            {

            }
        }
}
}