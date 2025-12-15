namespace NetCoreFundamentos
{
    partial class Form01SumarNumeros
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
            lblNum1 = new Label();
            lblNum2 = new Label();
            lblResultado = new Label();
            btnSumar = new Button();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            SuspendLayout();
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(31, 35);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(43, 15);
            lblNum1.TabIndex = 0;
            lblNum1.Text = "Num 1";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(31, 129);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(43, 15);
            lblNum2.TabIndex = 1;
            lblNum2.Text = "Num 2";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = SystemColors.ActiveCaption;
            lblResultado.ForeColor = SystemColors.ControlText;
            lblResultado.Location = new Point(31, 284);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 2;
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(218, 129);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(75, 23);
            btnSumar.TabIndex = 3;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(31, 70);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 4;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(31, 172);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 5;
            // 
            // Form01SumarNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(btnSumar);
            Controls.Add(lblResultado);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Name = "Form01SumarNumeros";
            Text = "Form01SumarNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum1;
        private Label lblNum2;
        private Label lblResultado;
        private Button btnSumar;
        private TextBox txtNum1;
        private TextBox txtNum2;
    }
}