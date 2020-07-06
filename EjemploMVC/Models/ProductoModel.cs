using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploMVC.Models
{
    public class ProductoModel
    {

        public string Nombre_Gym { get; set; }
        public string Pass_Gym { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string HorarioA { get; set; }
        public string HorarioC { get; set; }
        public int Cap_Maxima { get; set; }
        public int Porc_Permitido { get; set; }
    }
}
