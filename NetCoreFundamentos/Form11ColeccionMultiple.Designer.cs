namespace NetCoreFundamentos
{
    partial class Form11ColeccionMultiple
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
            lblIndex = new Label();
            lblItem = new Label();
            btnResetear = new Button();
            btnEliminar = new Button();
            btnInsertar = new Button();
            txtNuevo = new TextBox();
            lblNuevo = new Label();
            lstElementos = new ListBox();
            lblElementos = new Label();
            btnSelecc = new Button();
            SuspendLayout();
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Location = new Point(15, 234);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(0, 15);
            lblIndex.TabIndex = 17;
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(12, 208);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(0, 15);
            lblItem.TabIndex = 16;
            // 
            // btnResetear
            // 
            btnResetear.Location = new Point(178, 179);
            btnResetear.Name = "btnResetear";
            btnResetear.Size = new Size(75, 23);
            btnResetear.TabIndex = 15;
            btnResetear.Text = "Resetear";
            btnResetear.UseVisualStyleBackColor = true;
            btnResetear.Click += btnResetear_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(178, 135);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(178, 90);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 13;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtNuevo
            // 
            txtNuevo.Location = new Point(178, 47);
            txtNuevo.Name = "txtNuevo";
            txtNuevo.Size = new Size(100, 23);
            txtNuevo.TabIndex = 12;
            // 
            // lblNuevo
            // 
            lblNuevo.AutoSize = true;
            lblNuevo.Location = new Point(178, 18);
            lblNuevo.Name = "lblNuevo";
            lblNuevo.Size = new Size(95, 15);
            lblNuevo.TabIndex = 11;
            lblNuevo.Text = "Nuevo elemento";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(12, 36);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(130, 154);
            lstElementos.TabIndex = 10;
            // 
            // lblElementos
            // 
            lblElementos.AutoSize = true;
            lblElementos.Location = new Point(12, 18);
            lblElementos.Name = "lblElementos";
            lblElementos.Size = new Size(62, 15);
            lblElementos.TabIndex = 9;
            lblElementos.Text = "Elementos";
            // 
            // btnSelecc
            // 
            btnSelecc.Location = new Point(178, 226);
            btnSelecc.Name = "btnSelecc";
            btnSelecc.Size = new Size(95, 23);
            btnSelecc.TabIndex = 18;
            btnSelecc.Text = "Seleccionados";
            btnSelecc.UseVisualStyleBackColor = true;
            btnSelecc.Click += btnSelecc_Click;
            // 
            // Form11ColeccionMultiple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 274);
            Controls.Add(btnSelecc);
            Controls.Add(lblIndex);
            Controls.Add(lblItem);
            Controls.Add(btnResetear);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(txtNuevo);
            Controls.Add(lblNuevo);
            Controls.Add(lstElementos);
            Controls.Add(lblElementos);
            Name = "Form11ColeccionMultiple";
            Text = "Form11ColeccionMultiple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIndex;
        private Label lblItem;
        private Button btnResetear;
        private Button btnEliminar;
        private Button btnInsertar;
        private TextBox txtNuevo;
        private Label lblNuevo;
        private ListBox lstElementos;
        private Label lblElementos;
        private Button btnSelecc;
    }
}