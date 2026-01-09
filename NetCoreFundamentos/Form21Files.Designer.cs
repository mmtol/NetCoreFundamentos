namespace NetCoreFundamentos
{
    partial class Form21Files
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
            label1 = new Label();
            txtContenidoFile = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            btnNuevoNombre = new Button();
            btnLeer = new Button();
            btnWrite = new Button();
            lstNombres = new ListBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 27);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Contenido File";
            // 
            // txtContenidoFile
            // 
            txtContenidoFile.Location = new Point(30, 61);
            txtContenidoFile.Multiline = true;
            txtContenidoFile.Name = "txtContenidoFile";
            txtContenidoFile.Size = new Size(161, 248);
            txtContenidoFile.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(230, 61);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 27);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // btnNuevoNombre
            // 
            btnNuevoNombre.Location = new Point(230, 134);
            btnNuevoNombre.Name = "btnNuevoNombre";
            btnNuevoNombre.Size = new Size(100, 23);
            btnNuevoNombre.TabIndex = 4;
            btnNuevoNombre.Text = "Nuevo Nombre";
            btnNuevoNombre.UseVisualStyleBackColor = true;
            btnNuevoNombre.Click += btnNuevoNombre_Click;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(230, 177);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(100, 23);
            btnLeer.TabIndex = 5;
            btnLeer.Text = "Leer File";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(230, 218);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(100, 23);
            btnWrite.TabIndex = 6;
            btnWrite.Text = "Write File";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // lstNombres
            // 
            lstNombres.FormattingEnabled = true;
            lstNombres.Location = new Point(383, 61);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(120, 244);
            lstNombres.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(383, 27);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 8;
            label3.Text = "Nombres";
            // 
            // Form21Files
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 330);
            Controls.Add(label3);
            Controls.Add(lstNombres);
            Controls.Add(btnWrite);
            Controls.Add(btnLeer);
            Controls.Add(btnNuevoNombre);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtContenidoFile);
            Controls.Add(label1);
            Name = "Form21Files";
            Text = "Form21Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtContenidoFile;
        private TextBox txtNombre;
        private Label label2;
        private Button btnNuevoNombre;
        private Button btnLeer;
        private Button btnWrite;
        private ListBox lstNombres;
        private Label label3;
    }
}