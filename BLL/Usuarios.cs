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

        public bool Buscar(int id)
        {
            bool Retorno = false;
            DataTable Datos = new DataTable();

            Datos = conexion.BuscarDb("Select * from Usuarios where IdUsuario = " + id);
            if (Datos.Rows.Count > 0)
            {
                Retorno = true;
                this.IdUsuario = (int)Datos.Rows[0]["IdUsuario"];
                this.NombreUsuario = (string)Datos.Rows[0]["NombreUsuario"];
                this.Contrasena = (string)Datos.Rows[0]["Contrasena"];
            }

            return Retorno;
        }

        public Boolean Autenticar(string NombreUsuario, string Contrasena)
        {
            Boolean retorno = false;
            object idUsuario = conexion.ObtenerValorDb("SELECT IdUsuario from Usuarios Where NombreUsuario = '" + NombreUsuario + "' And Contrasena = '" + Contrasena + "'");

            if (idUsuario != null)
            {
                retorno = this.Buscar((int)idUsuario);
            }

            return retorno;
        }
    }
}
