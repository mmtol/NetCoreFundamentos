namespace NetCoreFundamentos
{
    partial class Form13TiendaProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblProducto = new Label();
            lblTienda = new Label();
            lblAlmacen = new Label();
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnResetear = new Button();
            btnSeleccion = new Button();
            btnTodos = new Button();
            btnSubir = new Button();
            btnBajar = new Button();
            txtProducto = new TextBox();
            lstTienda = new ListBox();
            lstAlmacen = new ListBox();
            SuspendLayout();
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(32, 34);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(56, 15);
            lblProducto.TabIndex = 0;
            lblProducto.Text = "Producto";
            // 
            // lblTienda
            // 
            lblTienda.AutoSize = true;
            lblTienda.Location = new Point(195, 34);
            lblTienda.Name = "lblTienda";
            lblTienda.Size = new Size(42, 15);
            lblTienda.TabIndex = 1;
            lblTienda.Text = "Tienda";
            // 
            // lblAlmacen
            // 
            lblAlmacen.AutoSize = true;
            lblAlmacen.Location = new Point(420, 34);
            lblAlmacen.Name = "lblAlmacen";
            lblAlmacen.Size = new Size(54, 15);
            lblAlmacen.TabIndex = 2;
            lblAlmacen.Text = "Almacen";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(32, 110);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(32, 158);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnResetear
            // 
            btnResetear.Location = new Point(32, 202);
            btnResetear.Name = "btnResetear";
            btnResetear.Size = new Size(75, 23);
            btnResetear.TabIndex = 5;
            btnResetear.Text = "Resetear";
            btnResetear.UseVisualStyleBackColor = true;
            btnResetear.Click += btnResetear_Click;
            // 
            // btnSeleccion
            // 
            btnSeleccion.Location = new Point(329, 95);
            btnSeleccion.Name = "btnSeleccion";
            btnSeleccion.Size = new Size(75, 23);
            btnSeleccion.TabIndex = 6;
            btnSeleccion.Text = "Seleccion";
            btnSeleccion.UseVisualStyleBackColor = true;
            btnSeleccion.Click += btnSeleccion_Click;
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(329, 136);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(75, 23);
            btnTodos.TabIndex = 7;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // btnSubir
            // 
            btnSubir.Location = new Point(562, 95);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(75, 23);
            btnSubir.TabIndex = 8;
            btnSubir.Text = "Subir";
            btnSubir.UseVisualStyleBackColor = true;
            btnSubir.Click += btnSubir_Click;
            // 
            // btnBajar
            // 
            btnBajar.Location = new Point(562, 136);
            btnBajar.Name = "btnBajar";
            btnBajar.Size = new Size(75, 23);
            btnBajar.TabIndex = 9;
            btnBajar.Text = "Bajar";
            btnBajar.UseVisualStyleBackColor = true;
            btnBajar.Click += btnBajar_Click;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(32, 65);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(100, 23);
            txtProducto.TabIndex = 10;
            // 
            // lstTienda
            // 
            lstTienda.FormattingEnabled = true;
            lstTienda.Location = new Point(195, 65);
            lstTienda.Name = "lstTienda";
            lstTienda.Size = new Size(120, 184);
            lstTienda.TabIndex = 11;
            // 
            // lstAlmacen
            // 
            lstAlmacen.FormattingEnabled = true;
            lstAlmacen.Location = new Point(420, 65);
            lstAlmacen.Name = "lstAlmacen";
            lstAlmacen.Size = new Size(120, 184);
            lstAlmacen.TabIndex = 12;
            // 
            // Form13TiendaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 274);
            Controls.Add(lstAlmacen);
            Controls.Add(lstTienda);
            Controls.Add(txtProducto);
            Controls.Add(btnBajar);
            Controls.Add(btnSubir);
            Controls.Add(btnTodos);
            Controls.Add(btnSeleccion);
            Controls.Add(btnResetear);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(lblAlmacen);
            Controls.Add(lblTienda);
            Controls.Add(lblProducto);
            Name = "Form13TiendaProductos";
            Text = "Form13TiendaProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProducto;
        private Label lblTienda;
        private Label lblAlmacen;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnResetear;
        private Button btnSeleccion;
        private Button btnTodos;
        private Button btnSubir;
        private Button btnBajar;
        private TextBox txtProducto;
        private ListBox lstTienda;
        private ListBox lstAlmacen;
    }
}