using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Pacientes
    {
        public int IdPaciente { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Ocupacion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public int Genero { get; set; }
        public string Cedula { get; set; }
        private Conexion conexion = new Conexion();

        public Pacientes()
        {
            this.IdPaciente = 0;
            this.Nombres = null;
            this.Apellidos = null;
            this.Direccion = null;
            this.Telefono = null;
            this.Celular = null;
            this.Genero = 0;
            this.Ocupacion = null;
            this.Cedula = null;
        }

        public Pacientes(DateTime FechaIngreso, string Nombres, string Apellidos,string Cedula, DateTime FechaNacimiento, int Genero, string Direccion, string Email, string Telefono, string Celular)
        {
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
            this.Celular = Celular;
            this.FechaNacimiento = FechaNacimiento;
            this.Genero = Genero;
            this.Ocupacion = Email;
            this.FechaIngreso = FechaIngreso;
            this.Cedula = Cedula;
        }
        public bool Insertar()
        {

            return conexion.EjecutarDB("insert into Pacientes (FechaIngreso,Nombres,Apellidos,Cedula,FechaNacimiento,Genero,Celular,Telefono, Direccion,Ocupacion) values('" + this.FechaIngreso.ToString("MM/dd/yyyy") + "','" + this.Nombres + "','" + this.Apellidos + "','" + this.Cedula + "','" + this.FechaNacimiento.ToString("MM/dd/yyyy") + "','" + this.Genero.ToString() + "','" + this.Celular + "','" + this.Telefono + "','" + this.Direccion + "','" + this.Ocupacion + "')");
        }

        public bool Modificar()
        {
            return conexion.EjecutarDB("update Pacientes set  FechaIngreso='" + this.FechaIngreso.ToString("MM/dd/yyyy") + "', Nombres='" + this.Nombres + "', Apellidos='" + this.Apellidos + "', Cedula='" + this.Cedula + "', FechaNacimiento='" + this.FechaNacimiento.ToString("MM/dd/yyyy") + "', Genero='" + this.Genero + "',Celular='" + this.Celular + "',Telefono='" + this.Telefono + "',Direccion='" + this.Direccion + "',Ocupacion='" + this.Ocupacion + "' where IdPaciente='" + this.IdPaciente + "'");

        }

        public bool Eliminar()
        {
            return conexion.EjecutarDB("delete from Pacientes where IdPaciente=" + this.IdPaciente.ToString());
        }

        public bool Buscar(int id)
        {
            bool Retorno = false;
            DataTable dt = new DataTable();

            dt = conexion.BuscarDb("select * from Pacientes where IdPaciente='" + id+"'");

            if (dt.Rows.Count > 0)
            {
                Retorno = true;
                IdPaciente = (int)dt.Rows[0]["IdPaciente"];
                Nombres = dt.Rows[0]["Nombres"].ToString();
                Apellidos = dt.Rows[0]["Apellidos"].ToString();
                FechaNacimiento = (DateTime)dt.Rows[0]["FechaNacimiento"];
                FechaNacimiento = (DateTime)dt.Rows[0]["FechaIngreso"];
                Genero = (int)dt.Rows[0]["Genero"];
                Direccion = dt.Rows[0]["Direccion"].ToString();
                Ocupacion = dt.Rows[0]["Ocupacion"].ToString();
                Telefono = dt.Rows[0]["Telefono"].ToString();
                Celular = dt.Rows[0]["Celular"].ToString();
                Cedula = dt.Rows[0]["Cedula"].ToString();

            }

            return Retorno;
        }



        public  DataTable Listar(String Campos, String FiltroWhere)
        {
            Conexion ConexionDB = new Conexion();
            return ConexionDB.BuscarDb("Select " + Campos + " from Pacientes where " + FiltroWhere);
        }

    }
}
