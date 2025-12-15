namespace NetCoreFundamentos
{
    partial class Form03DiaNacimiento
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
            lblDia = new Label();
            lblMes = new Label();
            lblAnho = new Label();
            lblResultado = new Label();
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtAnho = new TextBox();
            btnMostrar = new Button();
            SuspendLayout();
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(22, 35);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(24, 15);
            lblDia.TabIndex = 0;
            lblDia.Text = "Dia";
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Location = new Point(22, 80);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(29, 15);
            lblMes.TabIndex = 1;
            lblMes.Text = "Mes";
            // 
            // lblAnho
            // 
            lblAnho.AutoSize = true;
            lblAnho.Location = new Point(22, 138);
            lblAnho.Name = "lblAnho";
            lblAnho.Size = new Size(29, 15);
            lblAnho.TabIndex = 2;
            lblAnho.Text = "Año";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(70, 276);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 3;
            // 
            // txtDia
            // 
            txtDia.Location = new Point(81, 32);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 23);
            txtDia.TabIndex = 4;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(81, 80);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(100, 23);
            txtMes.TabIndex = 5;
            // 
            // txtAnho
            // 
            txtAnho.Location = new Point(81, 135);
            txtAnho.Name = "txtAnho";
            txtAnho.Size = new Size(100, 23);
            txtAnho.TabIndex = 6;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(54, 204);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 7;
            btnMostrar.Text = "Mostrar dia";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // Form03DiaNacimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMostrar);
            Controls.Add(txtAnho);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Controls.Add(lblResultado);
            Controls.Add(lblAnho);
            Controls.Add(lblMes);
            Controls.Add(lblDia);
            Name = "Form03DiaNacimiento";
            Text = "Form03DiaNacimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDia;
        private Label lblMes;
        private Label lblAnho;
        private Label lblResultado;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtAnho;
        private Button btnMostrar;
    }
}