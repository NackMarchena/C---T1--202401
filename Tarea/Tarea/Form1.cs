using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea.controllers;
using Tarea.entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Tarea
{
    public partial class Inventario : Form
    {
        private ProductoController productoController = new ProductoController();
        public Inventario()
        {
            InitializeComponent();
        }

        private void MostrarEnDataGrid(Producto[] productos)
        {
            dgProductos.DataSource = null;
            dgProductos.DataSource = productos; 
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            string var = ""; string var1 = "";
            if (tbCodigo.Text == "" || tbNombre.Text == "" || tbPrecio.Text == "" || tbDescripcion.Text == "" || textBox1.Text== "" )
            {
                MessageBox.Show("Debe ingresar todos los campos necesarios");
                return;
            }
            if (checkBox1.Checked)
            {
                var = "si";
            }else
                var = "no";
            if (tbPrecio.Text == "12" || tbPrecio.Text == "24" || tbPrecio.Text == "36" || tbPrecio.Text == "72" )
            {
                var1 = "aplica descuento";
            }
            else
                var1 = "no aplica el descuento";
            
            Producto producto = new Producto()
            {
                Nombre = tbNombre.Text,
                Codigo = tbCodigo.Text,
                Descripcion = tbDescripcion.Text,
                Categoria = cbCategoria.Text,
                Precio = double.Parse(tbPrecio.Text),
                Descuento = var,
                CondicionPrecio= var1,
                RUC= textBox1.Text ,
            };
            productoController.Registrar(producto);

            MostrarEnDataGrid(productoController.ListarTodo());
        }

        private void btEliminar1_Click(object sender, EventArgs e)
        {
            if(dgProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione producto a eliminar");
                return;
            }

            String codigo = dgProductos.SelectedRows[0].Cells[0].Value.ToString();

            productoController.Eliminar(codigo);
            MostrarEnDataGrid(productoController.ListarTodo());
        }

        private void btEliminarT_Click(object sender, EventArgs e)
        {
            productoController.EliminarTodo();
            MostrarEnDataGrid(productoController.ListarTodo());
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            MostrarEnDataGrid(productoController.ListarTodo());
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
