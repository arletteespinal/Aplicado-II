using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Usuarios
    {
        public int IdUsuario { set; get; }
        public string NombreUsuario { set; get; }
        public string Contrasena { set; get; }
        private Conexion conexion = new Conexion();

        public Usuarios()
        {
            IdUsuario = 0;
            NombreUsuario = null;
            Contrasena = null;
        }

        public bool Insertar()
        {
            return conexion.EjecuctarDB("insert into Usuarios (NombreUsuario,Contrasena) values ('"+this.NombreUsuario+"','"+this.Contrasena+"')");
        }

        public bool Buscar(int id)
        {
            bool Retorno = false;
            DataTable dt = new DataTable();

            dt = conexion.BuscarDb("Select * from Usuarios where IdUsuario = " + id);
            if (dt.Rows.Count > 0)
            {
                Retorno = true;
                this.IdUsuario = (int)dt.Rows[0]["IdUsuario"];
                this.NombreUsuario = (string)dt.Rows[0]["NombreUsuario"];
                this.Contrasena = (string)dt.Rows[0]["Contrasena"];
            }

            return Retorno;
        }

        public Boolean Autenticar(string NombreUsuario, string Contrasena)
        {
            bool Retorno = false;
            DataTable dt = new DataTable();

            dt = conexion.BuscarDb("SELECT IdUsuario from Usuarios Where NombreUsuario = '" + NombreUsuario + "' And Contrasena = '" + Contrasena + "'");

            if (dt.Rows.Count>0)
            {
                Retorno = true;
            }

            return Retorno;
        }
    }
}
