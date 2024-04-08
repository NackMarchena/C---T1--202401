using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea.entities
{
    class Producto
    {
        public Producto() { }
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public double Precio { get; set; }
        public String Categoria { get; set; } //E:Electronica, C:Consumibles, R:Ropa
        public String Descuento { get; set; }
        public String CondicionPrecio { get; set; }
        public String RUC { get; set; }
    }
}
