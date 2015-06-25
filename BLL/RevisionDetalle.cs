using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class RevisionDetalle
    {
        public int IdRevisionDetalle { set; get; }
        public int IdSistema { get; set; }
        public string Estado { set; get; }

        public RevisionDetalle( int IdSistema, string Estado)
        {
            this.IdSistema = IdSistema;
            this.Estado = Estado;
        }


        //public bool Modificar()
        //{
        //    return conexion.EjecutarDB("update RevisionDetalle set IdRevisionPaciente='" + this.IdRevision + "', IdSistema='" + this.IdSistema + "', Estado='" + this.Estado + "' where IdRevisionDetalle='" + IdRevisionDetalle + "'");
        //}
    }
}
