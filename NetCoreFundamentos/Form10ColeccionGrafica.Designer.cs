namespace NetCoreFundamentos
{
    partial class Form10ColeccionGrafica
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
            lblElementos = new Label();
            lstElementos = new ListBox();
            lblNuevo = new Label();
            txtNuevo = new TextBox();
            btnInsertar = new Button();
            btnEliminar = new Button();
            btnResetear = new Button();
            lblItem = new Label();
            lblIndex = new Label();
            SuspendLayout();
            // 
            // lblElementos
            // 
            lblElementos.AutoSize = true;
            lblElementos.Location = new Point(12, 22);
            lblElementos.Name = "lblElementos";
            lblElementos.Size = new Size(62, 15);
            lblElementos.TabIndex = 0;
            lblElementos.Text = "Elementos";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(12, 40);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(130, 154);
            lstElementos.TabIndex = 1;
            lstElementos.SelectedIndexChanged += lstElementos_SelectedIndexChanged;
            // 
            // lblNuevo
            // 
            lblNuevo.AutoSize = true;
            lblNuevo.Location = new Point(178, 22);
            lblNuevo.Name = "lblNuevo";
            lblNuevo.Size = new Size(95, 15);
            lblNuevo.TabIndex = 2;
            lblNuevo.Text = "Nuevo elemento";
            // 
            // txtNuevo
            // 
            txtNuevo.Location = new Point(178, 51);
            txtNuevo.Name = "txtNuevo";
            txtNuevo.Size = new Size(100, 23);
            txtNuevo.TabIndex = 3;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(178, 94);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 4;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(178, 139);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnResetear
            // 
            btnResetear.Location = new Point(178, 183);
            btnResetear.Name = "btnResetear";
            btnResetear.Size = new Size(75, 23);
            btnResetear.TabIndex = 6;
            btnResetear.Text = "Resetear";
            btnResetear.UseVisualStyleBackColor = true;
            btnResetear.Click += btnResetear_Click;
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(12, 212);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(0, 15);
            lblItem.TabIndex = 7;
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Location = new Point(15, 238);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(0, 15);
            lblIndex.TabIndex = 8;
            // 
            // Form10ColeccionGrafica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 271);
            Controls.Add(lblIndex);
            Controls.Add(lblItem);
            Controls.Add(btnResetear);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(txtNuevo);
            Controls.Add(lblNuevo);
            Controls.Add(lstElementos);
            Controls.Add(lblElementos);
            Name = "Form10ColeccionGrafica";
            Text = "Form10ColeccionGrafica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblElementos;
        private ListBox lstElementos;
        private Label lblNuevo;
        private TextBox txtNuevo;
        private Button btnInsertar;
        private Button btnEliminar;
        private Button btnResetear;
        private Label lblItem;
        private Label lblIndex;
    }
}