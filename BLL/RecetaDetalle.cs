using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class RecetaDetalle
    {
        public int IdRecetaDetalle { set; get; }
        public int IdMedicamento { set; get; }
        public string Frecuencia { set; get; }

        public RecetaDetalle(int IdMedicamento,string Frecuencia)
        {
            this.IdMedicamento = IdMedicamento;
            this.Frecuencia = Frecuencia;
        }
    }
}
