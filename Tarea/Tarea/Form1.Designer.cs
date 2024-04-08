
namespace Tarea
{
    partial class Inventario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lblprecio = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.btEliminar1 = new System.Windows.Forms.Button();
            this.btEliminarT = new System.Windows.Forms.Button();
            this.btListar = new System.Windows.Forms.Button();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(22, 18);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(358, 18);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(40, 13);
            this.lblcodigo.TabIndex = 1;
            this.lblcodigo.Text = "Codigo";
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(22, 46);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbldescripcion.TabIndex = 2;
            this.lbldescripcion.Text = "Descripcion";
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Location = new System.Drawing.Point(358, 46);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(52, 13);
            this.lblcategoria.TabIndex = 3;
            this.lblcategoria.Text = "Categoria";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "E",
            "C",
            "R"});
            this.cbCategoria.Location = new System.Drawing.Point(416, 43);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbCategoria.TabIndex = 4;
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(22, 77);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(37, 13);
            this.lblprecio.TabIndex = 5;
            this.lblprecio.Text = "Precio";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(89, 15);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 6;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(416, 18);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(121, 20);
            this.tbCodigo.TabIndex = 7;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(89, 46);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(100, 20);
            this.tbDescripcion.TabIndex = 8;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(89, 77);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(100, 20);
            this.tbPrecio.TabIndex = 9;
            // 
            // btRegistrar
            // 
            this.btRegistrar.Location = new System.Drawing.Point(25, 168);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(106, 23);
            this.btRegistrar.TabIndex = 10;
            this.btRegistrar.Text = "Registrar Producto";
            this.btRegistrar.UseVisualStyleBackColor = true;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // btEliminar1
            // 
            this.btEliminar1.Location = new System.Drawing.Point(156, 168);
            this.btEliminar1.Name = "btEliminar1";
            this.btEliminar1.Size = new System.Drawing.Size(100, 23);
            this.btEliminar1.TabIndex = 11;
            this.btEliminar1.Text = "Eliminar Producto";
            this.btEliminar1.UseVisualStyleBackColor = true;
            this.btEliminar1.Click += new System.EventHandler(this.btEliminar1_Click);
            // 
            // btEliminarT
            // 
            this.btEliminarT.Location = new System.Drawing.Point(296, 168);
            this.btEliminarT.Name = "btEliminarT";
            this.btEliminarT.Size = new System.Drawing.Size(146, 23);
            this.btEliminarT.TabIndex = 12;
            this.btEliminarT.Text = "Eliminar todos los productos";
            this.btEliminarT.UseVisualStyleBackColor = true;
            this.btEliminarT.Click += new System.EventHandler(this.btEliminarT_Click);
            // 
            // btListar
            // 
            this.btListar.Location = new System.Drawing.Point(475, 168);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(138, 23);
            this.btListar.TabIndex = 13;
            this.btListar.Text = "Listar todos los productos";
            this.btListar.UseVisualStyleBackColor = true;
            this.btListar.Click += new System.EventHandler(this.btListar_Click);
            // 
            // dgProductos
            // 
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Location = new System.Drawing.Point(25, 218);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.Size = new System.Drawing.Size(652, 177);
            this.dgProductos.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Traslado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(416, 80);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(35, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "sí";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(457, 80);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(38, 17);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "no";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "RUC";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(257, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 19;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.btListar);
            this.Controls.Add(this.btEliminarT);
            this.Controls.Add(this.btEliminar1);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.lblcategoria);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.lblnombre);
            this.Name = "Inventario";
            this.Text = "Tarea academica sem-2";
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.Button btEliminar1;
        private System.Windows.Forms.Button btEliminarT;
        private System.Windows.Forms.Button btListar;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

