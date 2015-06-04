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
                if (revision.BuscarRevision(id))
                {
                    Buscar(id);

                }
                if (CodigoTextBox.Text == string.Empty)
                {
                    EliminarButton.Enabled = false;
                    DetalleGridView.AutoGenerateSelectButton = false;
                }
                else
                {
                    EliminarButton.Enabled = true;
                    DetalleGridView.AutoGenerateSelectButton = true;
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
            DetalleGridView.DataSource = revision.Listar(" rv.IdRevisionDetalle as Codigo, rv.IdSistema as CodigoSistema, sf.Nombre as Sistema, rv.Estado ", " RevisionDetalle rv join SistemasFisiologico sf on rv.IdSistema=sf.IdSistema ", " IdRevisionPaciente='" + idR + "'");
            DetalleGridView.DataBind();
        }


        protected void AgregarButton_Click(object sender, EventArgs e)
        {
            if (CodigoTextBox.Text == string.Empty)
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
            else
            {
                
                DetalleGridView.Rows[DetalleGridView.SelectedIndex].Cells[2].Text = SistemasDropDownList.SelectedValue;
                DetalleGridView.Rows[DetalleGridView.SelectedIndex].Cells[4].Text = EstadoTextBox.Text;
            }
                
            
        }
       

        protected void GuardarButton_Click(object sender, EventArgs e)
        {

            revision.Fecha = Convert.ToDateTime(FechaTextBox.Text);
            revision.IdPaciente =Convert.ToInt32( PacientesDropDownList.SelectedValue);

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
                           
                            revision.IdSistema  = int.Parse(row["CodigoSistema"].ToString());
                            revision.Estado = row["Estado"].ToString();
                            revision.InsertarRevisionDetalle();
                        }
                        
                    }
                   
            }
            else
            {
                int id = 0;
                int.TryParse(CodigoTextBox.Text, out id);
                revision.IdRevision = id;

                if (revision.ModificarRevision())
                {
                    
                        //foreach ()
                        //{
                            
                        //    //revision.IdRevisionDetalle = Convert.ToInt32(row["Codigo"].ToString());
                        //    //revision.IdSistema = int.Parse(row["CodigoSistema"].ToString());
                        //    //revision.Estado = row["Estado"].ToString();
                        //    revision.ModificarRevisionDetalle();
      
                        //}

                        
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
                if (revision.EliminarRevisionDetalle())
                {
                    revision.EliminarRevision();
                }
            }
            catch (Exception)
            {

            }
        }

        protected void DetalleGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            SistemasDropDownList.SelectedValue = DetalleGridView.Rows[DetalleGridView.SelectedIndex].Cells[2].Text;
            EstadoTextBox.Text = DetalleGridView.Rows[DetalleGridView.SelectedIndex].Cells[4].Text;

        }

    }
}