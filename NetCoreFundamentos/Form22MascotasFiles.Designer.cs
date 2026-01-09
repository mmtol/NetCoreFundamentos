namespace NetCoreFundamentos
{
    partial class Form22MascotasFiles
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
            label3 = new Label();
            lstMascotas = new ListBox();
            btnWrite = new Button();
            btnLeer = new Button();
            btnNuevoNombre = new Button();
            txtNombre = new TextBox();
            label2 = new Label();
            txtRaza = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(162, 10);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 17;
            label3.Text = "Mascotas";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(162, 44);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(168, 244);
            lstMascotas.TabIndex = 16;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(12, 265);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(117, 23);
            btnWrite.TabIndex = 15;
            btnWrite.Text = "Write File";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(12, 224);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(117, 23);
            btnLeer.TabIndex = 14;
            btnLeer.Text = "Leer File";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // btnNuevoNombre
            // 
            btnNuevoNombre.Location = new Point(12, 181);
            btnNuevoNombre.Name = "btnNuevoNombre";
            btnNuevoNombre.Size = new Size(117, 23);
            btnNuevoNombre.TabIndex = 13;
            btnNuevoNombre.Text = "Nueva Mascota";
            btnNuevoNombre.UseVisualStyleBackColor = true;
            btnNuevoNombre.Click += btnNuevoNombre_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(9, 44);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(117, 23);
            txtNombre.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 10);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 11;
            label2.Text = "Nombre";
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(9, 115);
            txtRaza.Multiline = true;
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(117, 23);
            txtRaza.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 81);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 18;
            label4.Text = "Raza";
            // 
            // Form22MascotasFiles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 309);
            Controls.Add(txtRaza);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lstMascotas);
            Controls.Add(btnWrite);
            Controls.Add(btnLeer);
            Controls.Add(btnNuevoNombre);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Name = "Form22MascotasFiles";
            Text = "Form22MascotasFiles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private ListBox lstMascotas;
        private Button btnWrite;
        private Button btnLeer;
        private Button btnNuevoNombre;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtRaza;
        private Label label4;
    }
}