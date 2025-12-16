namespace NetCoreFundamentos
{
    partial class Form12ColeccionNumeros
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
            btnMostrar = new Button();
            btnGenerar = new Button();
            lstNumeros = new ListBox();
            lblNumeros = new Label();
            lblSuma = new Label();
            lblPares = new Label();
            lblImpares = new Label();
            txtSuma = new TextBox();
            txtPares = new TextBox();
            txtImpares = new TextBox();
            SuspendLayout();
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(203, 58);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 41);
            btnMostrar.TabIndex = 28;
            btnMostrar.Text = "Mostrar datos";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(203, 18);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(75, 23);
            btnGenerar.TabIndex = 23;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.Location = new Point(12, 36);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(130, 214);
            lstNumeros.TabIndex = 20;
            // 
            // lblNumeros
            // 
            lblNumeros.AutoSize = true;
            lblNumeros.Location = new Point(12, 18);
            lblNumeros.Name = "lblNumeros";
            lblNumeros.Size = new Size(56, 15);
            lblNumeros.TabIndex = 19;
            lblNumeros.Text = "Numeros";
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.Location = new Point(153, 125);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(37, 15);
            lblSuma.TabIndex = 29;
            lblSuma.Text = "Suma";
            // 
            // lblPares
            // 
            lblPares.AutoSize = true;
            lblPares.Location = new Point(153, 170);
            lblPares.Name = "lblPares";
            lblPares.Size = new Size(35, 15);
            lblPares.TabIndex = 30;
            lblPares.Text = "Pares";
            // 
            // lblImpares
            // 
            lblImpares.AutoSize = true;
            lblImpares.Location = new Point(153, 225);
            lblImpares.Name = "lblImpares";
            lblImpares.Size = new Size(49, 15);
            lblImpares.TabIndex = 31;
            lblImpares.Text = "Impares";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(203, 122);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(100, 23);
            txtSuma.TabIndex = 32;
            // 
            // txtPares
            // 
            txtPares.Location = new Point(203, 167);
            txtPares.Name = "txtPares";
            txtPares.Size = new Size(100, 23);
            txtPares.TabIndex = 33;
            // 
            // txtImpares
            // 
            txtImpares.Location = new Point(203, 222);
            txtImpares.Name = "txtImpares";
            txtImpares.Size = new Size(100, 23);
            txtImpares.TabIndex = 34;
            // 
            // Form12ColeccionNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 269);
            Controls.Add(txtImpares);
            Controls.Add(txtPares);
            Controls.Add(txtSuma);
            Controls.Add(lblImpares);
            Controls.Add(lblPares);
            Controls.Add(lblSuma);
            Controls.Add(btnMostrar);
            Controls.Add(btnGenerar);
            Controls.Add(lstNumeros);
            Controls.Add(lblNumeros);
            Name = "Form12ColeccionNumeros";
            Text = "Form12ColeccionNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostrar;
        private Button btnGenerar;
        private ListBox lstNumeros;
        private Label lblNumeros;
        private Label lblSuma;
        private Label lblPares;
        private Label lblImpares;
        private TextBox txtSuma;
        private TextBox txtPares;
        private TextBox txtImpares;
    }
}