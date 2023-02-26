using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{
    public class Productos
    {
        public int id_Inventario { get; set; }
        public string nombreCorto { get; set;}
        public string descripcion { get; set;}
        public string serie { get; set;}
        public string color { get; set;}
        public string fechaAdquision { get; set; }
        public string nombre { get; set; }
        public string tipoAdquision { get; set; }
        public string observaciones { get; set; }

        public int modificarId { get; set;}
    }
}
