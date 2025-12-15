namespace NetCoreFundamentos
{
    partial class Form02ColoresPosicion
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
            lblPosX = new Label();
            lblPosY = new Label();
            lblRojo = new Label();
            lblVerde = new Label();
            lblAzul = new Label();
            txtPosX = new TextBox();
            txtPosY = new TextBox();
            txtAzul = new TextBox();
            txtRojo = new TextBox();
            txtVerde = new TextBox();
            btnCambiarPos = new Button();
            btnCambiarFondo = new Button();
            SuspendLayout();
            // 
            // lblPosX
            // 
            lblPosX.AutoSize = true;
            lblPosX.Location = new Point(23, 26);
            lblPosX.Name = "lblPosX";
            lblPosX.Size = new Size(36, 15);
            lblPosX.TabIndex = 0;
            lblPosX.Text = "Pos X";
            // 
            // lblPosY
            // 
            lblPosY.AutoSize = true;
            lblPosY.Location = new Point(23, 133);
            lblPosY.Name = "lblPosY";
            lblPosY.Size = new Size(36, 15);
            lblPosY.TabIndex = 1;
            lblPosY.Text = "Pos Y";
            // 
            // lblRojo
            // 
            lblRojo.AutoSize = true;
            lblRojo.Location = new Point(291, 26);
            lblRojo.Name = "lblRojo";
            lblRojo.Size = new Size(31, 15);
            lblRojo.TabIndex = 2;
            lblRojo.Text = "Rojo";
            // 
            // lblVerde
            // 
            lblVerde.AutoSize = true;
            lblVerde.Location = new Point(291, 133);
            lblVerde.Name = "lblVerde";
            lblVerde.Size = new Size(36, 15);
            lblVerde.TabIndex = 3;
            lblVerde.Text = "Verde";
            // 
            // lblAzul
            // 
            lblAzul.AutoSize = true;
            lblAzul.Location = new Point(291, 237);
            lblAzul.Name = "lblAzul";
            lblAzul.Size = new Size(30, 15);
            lblAzul.TabIndex = 4;
            lblAzul.Text = "Azul";
            // 
            // txtPosX
            // 
            txtPosX.Location = new Point(23, 59);
            txtPosX.Name = "txtPosX";
            txtPosX.Size = new Size(100, 23);
            txtPosX.TabIndex = 5;
            // 
            // txtPosY
            // 
            txtPosY.Location = new Point(23, 173);
            txtPosY.Name = "txtPosY";
            txtPosY.Size = new Size(100, 23);
            txtPosY.TabIndex = 6;
            // 
            // txtAzul
            // 
            txtAzul.Location = new Point(291, 281);
            txtAzul.Name = "txtAzul";
            txtAzul.Size = new Size(100, 23);
            txtAzul.TabIndex = 7;
            // 
            // txtRojo
            // 
            txtRojo.Location = new Point(291, 59);
            txtRojo.Name = "txtRojo";
            txtRojo.Size = new Size(100, 23);
            txtRojo.TabIndex = 8;
            // 
            // txtVerde
            // 
            txtVerde.Location = new Point(291, 173);
            txtVerde.Name = "txtVerde";
            txtVerde.Size = new Size(100, 23);
            txtVerde.TabIndex = 9;
            // 
            // btnCambiarPos
            // 
            btnCambiarPos.Location = new Point(23, 233);
            btnCambiarPos.Name = "btnCambiarPos";
            btnCambiarPos.Size = new Size(109, 36);
            btnCambiarPos.TabIndex = 10;
            btnCambiarPos.Text = "Cambiar pos";
            btnCambiarPos.UseVisualStyleBackColor = true;
            btnCambiarPos.Click += btnCambiarPos_Click;
            // 
            // btnCambiarFondo
            // 
            btnCambiarFondo.Location = new Point(291, 346);
            btnCambiarFondo.Name = "btnCambiarFondo";
            btnCambiarFondo.Size = new Size(100, 40);
            btnCambiarFondo.TabIndex = 11;
            btnCambiarFondo.Text = "Cambiar fondo";
            btnCambiarFondo.UseVisualStyleBackColor = true;
            btnCambiarFondo.Click += btnCambiarFondo_Click;
            // 
            // Form02ColoresPosicion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCambiarFondo);
            Controls.Add(btnCambiarPos);
            Controls.Add(txtVerde);
            Controls.Add(txtRojo);
            Controls.Add(txtAzul);
            Controls.Add(txtPosY);
            Controls.Add(txtPosX);
            Controls.Add(lblAzul);
            Controls.Add(lblVerde);
            Controls.Add(lblRojo);
            Controls.Add(lblPosY);
            Controls.Add(lblPosX);
            Name = "Form02ColoresPosicion";
            Text = "Form02ColoresPosicion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPosX;
        private Label lblPosY;
        private Label lblRojo;
        private Label lblVerde;
        private Label lblAzul;
        private TextBox txtPosX;
        private TextBox txtPosY;
        private TextBox txtAzul;
        private TextBox txtRojo;
        private TextBox txtVerde;
        private Button btnCambiarPos;
        private Button btnCambiarFondo;
    }
}