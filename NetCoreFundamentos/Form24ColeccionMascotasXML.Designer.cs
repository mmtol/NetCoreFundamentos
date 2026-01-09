namespace NetCoreFundamentos
{
    partial class Form24ColeccionMascotasXML
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
            txtEdad = new TextBox();
            label1 = new Label();
            txtRaza = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lstMascotas = new ListBox();
            btnLeer = new Button();
            btnGuardar = new Button();
            btnNueva = new Button();
            SuspendLayout();
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(12, 139);
            txtEdad.Multiline = true;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(117, 23);
            txtEdad.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 121);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 35;
            label1.Text = "Edad";
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(12, 82);
            txtRaza.Multiline = true;
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(117, 23);
            txtRaza.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 64);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 33;
            label4.Text = "Raza";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 28);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(117, 23);
            txtNombre.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 10);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 31;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 9);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 37;
            label3.Text = "Mascotas";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(180, 28);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(175, 184);
            lstMascotas.TabIndex = 38;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(373, 81);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(75, 23);
            btnLeer.TabIndex = 39;
            btnLeer.Text = "Leer Mascotas";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(373, 117);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 40;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNueva
            // 
            btnNueva.Location = new Point(28, 188);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(75, 23);
            btnNueva.TabIndex = 41;
            btnNueva.Text = "Nueva";
            btnNueva.UseVisualStyleBackColor = true;
            btnNueva.Click += btnNueva_Click;
            // 
            // Form24ColeccionMascotasXML
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 225);
            Controls.Add(btnNueva);
            Controls.Add(btnGuardar);
            Controls.Add(btnLeer);
            Controls.Add(lstMascotas);
            Controls.Add(label3);
            Controls.Add(txtEdad);
            Controls.Add(label1);
            Controls.Add(txtRaza);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Name = "Form24ColeccionMascotasXML";
            Text = "Form24ColeccionMascotasXML";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEdad;
        private Label label1;
        private TextBox txtRaza;
        private Label label4;
        private TextBox txtNombre;
        private Label label2;
        private Label label3;
        private ListBox lstMascotas;
        private Button btnLeer;
        private Button btnGuardar;
        private Button btnNueva;
    }
}