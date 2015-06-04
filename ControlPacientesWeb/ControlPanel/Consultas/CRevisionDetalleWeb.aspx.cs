using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ControlPacientesWeb.Consultas
{
    public partial class CRevisionDetalleWeb : System.Web.UI.Page
    {
        private RevisionPaciente revision = new RevisionPaciente();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                int id = 0;
                int.TryParse(Request.QueryString["Codigo"], out id);
                DetalleGridView.DataSource = revision.Listar(" rv.IdRevisionDetalle as Codigo, rv.IdSistema as CodigoSistema, sf.Nombre as Sistema, rv.Estado ", " RevisionDetalle rv join SistemasFisiologico sf on rv.IdSistema=sf.IdSistema ", " IdRevisionPaciente='" +id + "'");
                DetalleGridView.DataBind();
            }
        }
    }
}