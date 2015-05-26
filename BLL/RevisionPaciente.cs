using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class RevisionPaciente
    {
        public int IdRevision { set; get; }
        public int IdRevisionDetalle { set; get; }
        public int IdPaciente { set; get; }
        public DateTime Fecha { set; get; }
        public int IdSistema { get; set; }
        public string Estado { set; get; }
        private Conexion conexion = new Conexion();

        public RevisionPaciente()
        {
            IdPaciente = 0;
            IdRevision = 0;
            IdRevisionDetalle = 0;
            IdSistema = 0;
            Estado = null;
        }


        public bool InsertarRevision()
        {
            return conexion.EjecutarDB("insert into RevisionPaciente (Fecha,IdPaciente) values('" + this.Fecha.ToString("MM/dd/yyyy") + "','" + this.IdPaciente + "')");
        }

        public bool InsertarRevisionDetalle()
        {
            return conexion.EjecutarDB("insert into RevisionDetalle (IdRevisionPaciente,IdSistema,Estado) values('" + this.IdRevision+ "','" + this.IdSistema+"','"+this.Estado + "')");
        }

        public bool ModificarRevision()
        {
            return conexion.EjecutarDB("update RevisionPaciente set Fecha='" + this.Fecha.ToString("MM/dd/yyyy") + "', IdPaciente='" + this.IdPaciente + "' where IdRevision='" + IdRevision + "'");
        }

        public bool ModificarRevisionDetalle()
        {
            return conexion.EjecutarDB("update RevisionDetalle set IdRevisionPaciente='" + this.IdRevision + "', IdSistema='" + this.IdSistema + "', Estado='" + this.Estado + "' where IdRevisionDetalle='" + IdRevisionDetalle + "'");
        }

        public bool EliminarRevision()
        {
            return conexion.EjecutarDB("delete from RevisionPaciente where IdRevision='" + this.IdRevision.ToString() + "'");
        }

        public bool EliminarRevisionDetalle()
        {
            return conexion.EjecutarDB("delete from RevisionDetalle where IdRevisionPaciente='" + this.IdRevision.ToString() + "'");
        }

        public bool BuscarIdRevision()
        {
            bool Retorno = false;
            DataTable dt = new DataTable();

            dt = conexion.BuscarDb("select Max(IdRevision) as IdRevision from RevisionPaciente");

            if (dt.Rows.Count > 0)
            {
                Retorno = true;
                IdRevision = (int)dt.Rows[0]["IdRevision"];

            }

            return Retorno;
        }


        public bool BuscarRevision(int id)
        {
            bool Retorno = false;
            DataTable dt = new DataTable();

            dt = conexion.BuscarDb("select * from RevisionPaciente where IdRevision='" + id + "'");

            if (dt.Rows.Count > 0)
            {
                Retorno = true;
                IdRevision = (int)dt.Rows[0]["IdRevision"];
                Fecha =(DateTime) dt.Rows[0]["Fecha"];
                IdPaciente = (int)dt.Rows[0]["IdPaciente"];

            }

            return Retorno;
        }

        public DataTable Listar(String Campos,String tabla ,String FiltroWhere)
        {
            Conexion ConexionDB = new Conexion();
            return ConexionDB.BuscarDb("Select " + Campos + " from "+tabla+" where " + FiltroWhere);
        }

    }
}
