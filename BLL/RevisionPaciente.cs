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
        public int IdPaciente { set; get; }
        public DateTime Fecha { set; get; }
        public List<RevisionDetalle> RevisionDetalle { get;set;}
        private Conexion conexion = new Conexion();

        public RevisionPaciente()
        {
            IdPaciente = 0;
            IdRevision = 0;
            RevisionDetalle = new List<RevisionDetalle>();
        }


        public bool Insertar()
        {
            String Comando;
            Comando = "insert into RevisionPaciente (Fecha,IdPaciente) values('" + this.Fecha.ToString("MM/dd/yyyy") + "','" + this.IdPaciente + "')"; 
      
            foreach (RevisionDetalle detalle in RevisionDetalle)
            {

                Comando += "insert into RevisionDetalle (IdRevisionPaciente,IdSistema,Estado) values((select max(IdRevision) as IdRevision from RevisionPaciente),'" + detalle.IdSistema + "','" + detalle.Estado + "')";
            }
        
            return conexion.EjecutarDB(Comando);
            
        }

        public void agregarRevisionDetalle(int idSistema, string estado)
        {
            RevisionDetalle.Add( new RevisionDetalle(idSistema,estado));
        }

        public bool Modificar()
        {
            String Comando;
            Comando = "update RevisionPaciente set Fecha='" + this.Fecha.ToString("MM/dd/yyyy") + "', IdPaciente='" + this.IdPaciente + "' where IdRevision='" + IdRevision + "'";

            foreach (RevisionDetalle detalle in RevisionDetalle)
            {

                Comando += "insert into RevisionDetalle (IdRevisionPaciente,IdSistema,Estado) values('"+this.IdRevision+"','" + detalle.IdSistema + "','" + detalle.Estado + "')";
            }

            return conexion.EjecutarDB(Comando);
        }

        public bool Eliminar()
        {
            String Comando;
            Comando = "delete from RevisionDetalle where IdRevisionPaciente='" + this.IdRevision.ToString() + "'";
            Comando += "delete from RevisionPaciente where IdRevision='" + this.IdRevision.ToString() + "'";

            return conexion.EjecutarDB(Comando);
        }

        public bool Buscar(int id)
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

        public DataTable Listar(String Campos,String Tabla ,String FiltroWhere)
        {
            Conexion ConexionDB = new Conexion();
            return ConexionDB.BuscarDb("Select " + Campos + " from "+Tabla+" where " + FiltroWhere);
        }

    }
}
