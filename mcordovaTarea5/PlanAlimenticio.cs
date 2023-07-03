using System;
using System.Collections.Generic;
using System.Text;

namespace mcordovaTarea5
{
    internal class PlanAlimenticio
    {
        public  int id_palim { set; get; }
        public  string nombre_palim { set; get;}
        public string descripcion_palim { set; get; }
        public int duracion_palim { set ; get; }
        public int pesoactual_palim { set ; get; }
        public DateTime fecha_palim { set ; get; }
        public string estado_palim { set ; get; }

    }
}
