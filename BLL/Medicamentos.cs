using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class Medicamentos
    {
        public int IdMedicamento { set; get; }
        public string Descripcion { set; get; }
        private Conexion conexion = new Conexion();

        public Medicamentos()
        {
            IdMedicamento = 0;
            Descripcion = null;
        }

        public bool Insertar()
        {
            return conexion.EjecutarDB("Insert into Medicamentos(Descripcion)values('"+this.Descripcion+"')");
        }

        public bool Modificar()
        {
            return conexion.EjecutarDB("update Medicamentos set Descripcion='"+this.Descripcion+"' where IdMedicamento='"+this.IdMedicamento.ToString()+"'");
        }

        public bool Eliminar()
        {
            return conexion.EjecutarDB("delete from Medicamentos where IdMedicamento='"+this.IdMedicamento.ToString()+"'");
        }

        public bool Buscar(int id)
        {
            bool Retorno = false;
            DataTable dt = new DataTable();
            dt = conexion.BuscarDb("Select * from Medicamentos where IdMedicamento='"+id+"'");
          
            if (dt.Rows.Count > 0)
            {
                Retorno = true;
                IdMedicamento = (int)dt.Rows[0]["IdMedicamento"];
                Descripcion = dt.Rows[0]["Descripcion"].ToString();
            }
            return Retorno;
        }

        public DataTable Listar(string campos, string where)
        {
            return conexion.BuscarDb("Select "+campos+" from Medicamentos where "+where);
        }


    }
}
