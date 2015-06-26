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
                int id = 0;
                int.TryParse(Request.QueryString["Codigo"], out id);
                if (revision.Buscar(id))
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

                SistemasDropDownList.DataSource = sistemas.Listar("IdSistema as CodigoSistema, Nombre", " 1=1");
                SistemasDropDownList.DataValueField = "CodigoSistema";
                SistemasDropDownList.DataTextField = "Nombre";
                SistemasDropDownList.DataBind();

                PacientesDropDownList.DataSource = pacientes.NombreCompleto();
                PacientesDropDownList.DataValueField = "Codigo";
                PacientesDropDownList.DataTextField = "NombreCompleto";
                PacientesDropDownList.DataBind();

                Session.Abandon();
            }

            
        }

        private void Buscar(int idR)
        {
            CodigoTextBox.Text = revision.IdRevision.ToString();
            FechaTextBox.Text = revision.Fecha.ToString("MM/dd/yyyy");
            PacientesDropDownList.SelectedValue = revision.IdPaciente.ToString();
            DetalleGridView.DataSource = revision.Listar(" rv.IdSistema as CodigoSistema, sf.Nombre as Sistema, rv.Estado ", " RevisionDetalle rv join SistemasFisiologico sf on rv.IdSistema=sf.IdSistema ", " IdRevisionPaciente='" + idR + "'");
            DetalleGridView.DataBind();
        }


        protected void AgregarButton_Click(object sender, EventArgs e)
        {
            if (CodigoTextBox.Text == string.Empty)
            {

                if (Session["revision"] != null)
                {
                    revision = (RevisionPaciente)Session["revision"];
                }

                revision.agregarRevisionDetalle(Convert.ToInt32(SistemasDropDownList.SelectedValue),EstadoTextBox.Text);

                DetalleGridView.DataSource = revision.RevisionDetalle;
                DetalleGridView.DataBind();

                Session["revision"] = revision;
            }
            else
            {
                
            }
                
            
        }
       

        protected void GuardarButton_Click(object sender, EventArgs e)
        {

         
           

            if (CodigoTextBox.Text == string.Empty)
            {

                if (Session["revision"] != null)
                {
                    revision = (RevisionPaciente)Session["revision"];
                }

                revision.Fecha = Convert.ToDateTime(FechaTextBox.Text);
                revision.IdPaciente = Convert.ToInt32(PacientesDropDownList.SelectedValue);


                if (revision.Insertar())
                {

                }
                
      
                   
            }
            else
            {
                int id = 0;
                int.TryParse(CodigoTextBox.Text, out id);
                revision.IdRevision = id;

                if (revision.Modificar())
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
                revision.IdRevision = id;
                if (revision.Eliminar())
                {
                    
                }
            }
            catch (Exception)
            {

            }
        }

    }
}