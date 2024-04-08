using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea.entities;

namespace Tarea.controllers
{
    class ProductoController
    {
        private Producto[] productos = new Producto[110];
        private int cont = 0;

        public Producto[] ListarTodo()
        {
            return productos;
        }
        public void Registrar(Producto producto)
        {
            productos[cont] = producto;
            cont++;
        }
        public void Eliminar(String codigo)
        {
            int pos = Array.FindIndex(productos, producto => producto.Codigo.Equals(codigo));

            for(int i = 0; i < cont; i++)
            {
                if(i >= pos )
                {
                    productos[i] = productos[i + 1];
                }
            }
            cont--;
        }
        public void EliminarTodo()
        {
            for (int i = 0; i < cont; i++)
            {
                productos[i] = null;
            }
            cont = 0;
        }
    }
}
