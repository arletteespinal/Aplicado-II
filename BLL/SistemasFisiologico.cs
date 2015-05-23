using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class SistemasFisiologico
    {
        public int IdSistema {set;get;}
        public string Nombre { set; get; }
        private Conexion conexion = new Conexion();

        public SistemasFisiologico()
        {
            IdSistema = 0;
            Nombre = null;
        }

        public SistemasFisiologico(string nombre)
        {
            this.Nombre = nombre;
        }

        public bool Insertar()
        {
            return conexion.EjecutarDB("insert into SistemasFisiologico (Nombre) values('"+ this.Nombre+ "')");
        }

        public bool Modificar()
        {
            return conexion.EjecutarDB("update SistemasFisiologico set Nombre='" + this.Nombre + "' where IdSistema='"+IdSistema+"'");
        }

        public bool Eliminar()
        {
            return conexion.EjecutarDB("delete from SistemasFisiologico where IdSistema='" + this.IdSistema.ToString()+"'");
        }

        public bool Buscar(int id)
        {
            bool Retorno = false;
            DataTable dt = new DataTable();

            dt = conexion.BuscarDb("select * from SistemasFisiologico where IdSistema='" + id + "'");

            if (dt.Rows.Count > 0)
            {
                Retorno = true;
                IdSistema = (int)dt.Rows[0]["IdSistema"];
                Nombre = dt.Rows[0]["Nombre"].ToString();

            }

            return Retorno;
        }

        public DataTable Listar(String Campos, String FiltroWhere)
        {
            Conexion ConexionDB = new Conexion();
            return ConexionDB.BuscarDb("Select " + Campos + " from SistemasFisiologico where " + FiltroWhere);
        }

    }
}
