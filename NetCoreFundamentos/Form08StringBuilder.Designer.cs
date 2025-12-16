namespace NetCoreFundamentos
{
    partial class Form08StringBuilder
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
            lblTexto = new Label();
            txtTexto = new RichTextBox();
            lblTiempo = new Label();
            btnString = new Button();
            btnBuilder = new Button();
            SuspendLayout();
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(22, 27);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(68, 15);
            lblTexto.TabIndex = 0;
            lblTexto.Text = "Copie texto";
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(22, 54);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(287, 218);
            txtTexto.TabIndex = 1;
            txtTexto.Text = "";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(22, 290);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(0, 15);
            lblTiempo.TabIndex = 2;
            // 
            // btnString
            // 
            btnString.Location = new Point(155, 290);
            btnString.Name = "btnString";
            btnString.Size = new Size(75, 23);
            btnString.TabIndex = 3;
            btnString.Text = "String";
            btnString.UseVisualStyleBackColor = true;
            btnString.Click += btnString_Click;
            // 
            // btnBuilder
            // 
            btnBuilder.Location = new Point(236, 290);
            btnBuilder.Name = "btnBuilder";
            btnBuilder.Size = new Size(75, 23);
            btnBuilder.TabIndex = 4;
            btnBuilder.Text = "Builder";
            btnBuilder.UseVisualStyleBackColor = true;
            btnBuilder.Click += btnBuilder_Click;
            // 
            // Form08StringBuilder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 323);
            Controls.Add(btnBuilder);
            Controls.Add(btnString);
            Controls.Add(lblTiempo);
            Controls.Add(txtTexto);
            Controls.Add(lblTexto);
            Name = "Form08StringBuilder";
            Text = "Form08StringBuilder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTexto;
        private RichTextBox txtTexto;
        private Label lblTiempo;
        private Button btnString;
        private Button btnBuilder;
    }
}