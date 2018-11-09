using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace simulador_de_negocios.Models
{
    public class Mano_Obra_Operativa
    {
        [Key]
        public int manoobraoperativaID { get; set; }


        public String concepto { get; set; }
        public String unidadmedia { get; set; }

        public int preciounitario { get; set; }

        public int cantidad { get; set; }
        public int estimacionmensual { get; set; }
        public int estimacionanual { get; set; }
        public int servicioproducto { get; set; }


        public int datosempresas { get; set; }

    }
}
