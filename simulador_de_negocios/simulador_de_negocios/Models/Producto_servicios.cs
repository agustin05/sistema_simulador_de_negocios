using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace simulador_de_negocios.Models
{
    public class Producto_servicios
    {
        [Key]
        public int productoID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe tener de 3 a 20 caracteres")]
        public String nombreproducto { get; set; }

        public String unidadproducto { get; set; }

        public int produccionmensual { get; set; }


        public int costounitario { get; set; }


        public int margenutilidad { get; set; }


        public int preciopublico { get; set; }


        public int datosempresa { get; set; }
    }
}
