namespace NetCoreFundamentos
{
    partial class Form23ObjetoMascota
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
            txtRaza = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btnGuardar = new Button();
            btnLeer = new Button();
            txtNombre = new TextBox();
            label2 = new Label();
            txtEdad = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(12, 85);
            txtRaza.Multiline = true;
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(117, 23);
            txtRaza.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 67);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 27;
            label4.Text = "Raza";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(324, -22);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 26;
            label3.Text = "Mascotas";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(168, 103);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(117, 23);
            btnGuardar.TabIndex = 24;
            btnGuardar.Text = "Guardar Clase";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(168, 62);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(117, 23);
            btnLeer.TabIndex = 23;
            btnLeer.Text = "Leer Clase";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 31);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(117, 23);
            txtNombre.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 13);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 20;
            label2.Text = "Nombre";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(12, 142);
            txtEdad.Multiline = true;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(117, 23);
            txtEdad.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 124);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 29;
            label1.Text = "Edad";
            // 
            // Form23ObjetoMascota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 192);
            Controls.Add(txtEdad);
            Controls.Add(label1);
            Controls.Add(txtRaza);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnGuardar);
            Controls.Add(btnLeer);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Name = "Form23ObjetoMascota";
            Text = "Form23ObjetoMascota";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRaza;
        private Label label4;
        private Label label3;
        private Button btnGuardar;
        private Button btnLeer;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtEdad;
        private Label label1;
    }
}