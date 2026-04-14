namespace Inventario.UI
{
    partial class FormInventario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lvProductos = new ListView();
            textBox1 = new TextBox();
            lbBuscarPorNombreOCategoria = new Label();
            cbCategoria = new ComboBox();
            lbCategoria = new Label();
            btnEliminarSeleccionado = new Button();
            groupBox1 = new GroupBox();
            btnGuardarProducto = new Button();
            txtStock = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtPrecio = new TextBox();
            cbNuevaCategoria = new ComboBox();
            label1 = new Label();
            txtNombre = new TextBox();
            lbNombre = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lvProductos
            // 
            lvProductos.Location = new Point(46, 157);
            lvProductos.Margin = new Padding(4, 5, 4, 5);
            lvProductos.Name = "lvProductos";
            lvProductos.Size = new Size(533, 159);
            lvProductos.TabIndex = 0;
            lvProductos.UseCompatibleStateImageBehavior = false;
            lvProductos.SelectedIndexChanged += lvProductos_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(46, 108);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 31);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lbBuscarPorNombreOCategoria
            // 
            lbBuscarPorNombreOCategoria.AutoSize = true;
            lbBuscarPorNombreOCategoria.Location = new Point(46, 78);
            lbBuscarPorNombreOCategoria.Margin = new Padding(4, 0, 4, 0);
            lbBuscarPorNombreOCategoria.Name = "lbBuscarPorNombreOCategoria";
            lbBuscarPorNombreOCategoria.Size = new Size(264, 25);
            lbBuscarPorNombreOCategoria.TabIndex = 2;
            lbBuscarPorNombreOCategoria.Text = "Buscar por Nombre o Categoria";
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Items.AddRange(new object[] { "Todos", "Papelería", "Tecnología", "Mobiliario", "Otro" });
            cbCategoria.Location = new Point(407, 108);
            cbCategoria.Margin = new Padding(4, 5, 4, 5);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(171, 33);
            cbCategoria.TabIndex = 3;
            cbCategoria.SelectedIndexChanged += cbCategoria_SelectedIndexChanged;
            // 
            // lbCategoria
            // 
            lbCategoria.AutoSize = true;
            lbCategoria.Location = new Point(407, 78);
            lbCategoria.Margin = new Padding(4, 0, 4, 0);
            lbCategoria.Name = "lbCategoria";
            lbCategoria.Size = new Size(167, 25);
            lbCategoria.TabIndex = 4;
            lbCategoria.Text = "Filtrar por categoría";
            // 
            // btnEliminarSeleccionado
            // 
            btnEliminarSeleccionado.Location = new Point(46, 328);
            btnEliminarSeleccionado.Margin = new Padding(4, 5, 4, 5);
            btnEliminarSeleccionado.Name = "btnEliminarSeleccionado";
            btnEliminarSeleccionado.Size = new Size(107, 38);
            btnEliminarSeleccionado.TabIndex = 5;
            btnEliminarSeleccionado.Text = "Eliminar Seleccionado";
            btnEliminarSeleccionado.UseVisualStyleBackColor = true;
            btnEliminarSeleccionado.Click += btnEliminarSeleccionado_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGuardarProducto);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(cbNuevaCategoria);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(lbNombre);
            groupBox1.Location = new Point(690, 108);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(414, 502);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nuevo Producto";
            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.Location = new Point(17, 453);
            btnGuardarProducto.Margin = new Padding(4, 5, 4, 5);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(107, 38);
            btnGuardarProducto.TabIndex = 11;
            btnGuardarProducto.Text = "Guardar";
            btnGuardarProducto.UseVisualStyleBackColor = true;
            btnGuardarProducto.Click += btnGuardarProducto_Click;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(17, 380);
            txtStock.Margin = new Padding(4, 5, 4, 5);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(243, 31);
            txtStock.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 350);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 25);
            label3.TabIndex = 9;
            label3.Text = "Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 158);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 8;
            label2.Text = "Categoría";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(17, 283);
            txtPrecio.Margin = new Padding(4, 5, 4, 5);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(243, 31);
            txtPrecio.TabIndex = 3;
            // 
            // cbNuevaCategoria
            // 
            cbNuevaCategoria.FormattingEnabled = true;
            cbNuevaCategoria.Items.AddRange(new object[] { "Papelería", "Tecnología", "Mobiliario", "Otro" });
            cbNuevaCategoria.Location = new Point(17, 188);
            cbNuevaCategoria.Margin = new Padding(4, 5, 4, 5);
            cbNuevaCategoria.Name = "cbNuevaCategoria";
            cbNuevaCategoria.Size = new Size(243, 33);
            cbNuevaCategoria.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 253);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 2;
            label1.Text = "Precio";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(17, 98);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(243, 31);
            txtNombre.TabIndex = 1;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(17, 53);
            lbNombre.Margin = new Padding(4, 0, 4, 0);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(78, 25);
            lbNombre.TabIndex = 0;
            lbNombre.Text = "Nombre";
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(groupBox1);
            Controls.Add(btnEliminarSeleccionado);
            Controls.Add(lbCategoria);
            Controls.Add(cbCategoria);
            Controls.Add(lbBuscarPorNombreOCategoria);
            Controls.Add(textBox1);
            Controls.Add(lvProductos);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormInventario";
            Text = "Form1";
            Load += FormInventario_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvProductos;
        private TextBox textBox1;
        private Label lbBuscarPorNombreOCategoria;
        private ComboBox cbCategoria;
        private Label lbCategoria;
        private Button btnEliminarSeleccionado;
        private GroupBox groupBox1;
        private TextBox txtStock;
        private Label label3;
        private Label label2;
        private TextBox txtPrecio;
        private ComboBox cbNuevaCategoria;
        private Label label1;
        private TextBox txtNombre;
        private Label lbNombre;
        private Button btnGuardarProducto;
    }
}
