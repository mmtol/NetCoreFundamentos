namespace NetCoreFundamentos
{
    partial class Form14Metodos
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
            lblNumero = new Label();
            txtNumero = new TextBox();
            lblResultado = new Label();
            btnValor = new Button();
            btnRef = new Button();
            btnObj = new Button();
            btnReturn = new Button();
            lblRaton = new Label();
            txtLetras = new TextBox();
            txtNums = new TextBox();
            lblLetras = new Label();
            lblNums = new Label();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(12, 22);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Numero";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(12, 40);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(12, 110);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 2;
            // 
            // btnValor
            // 
            btnValor.Location = new Point(153, 18);
            btnValor.Name = "btnValor";
            btnValor.Size = new Size(75, 23);
            btnValor.TabIndex = 3;
            btnValor.Text = "Doble valor";
            btnValor.UseVisualStyleBackColor = true;
            btnValor.Click += btnValor_Click;
            // 
            // btnRef
            // 
            btnRef.Location = new Point(153, 61);
            btnRef.Name = "btnRef";
            btnRef.Size = new Size(75, 23);
            btnRef.TabIndex = 4;
            btnRef.Text = "Doble ref";
            btnRef.UseVisualStyleBackColor = true;
            btnRef.Click += btnRef_Click;
            // 
            // btnObj
            // 
            btnObj.Location = new Point(153, 102);
            btnObj.Name = "btnObj";
            btnObj.Size = new Size(75, 23);
            btnObj.TabIndex = 5;
            btnObj.Text = "Obj ref";
            btnObj.UseVisualStyleBackColor = true;
            btnObj.Click += btnObj_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(153, 141);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(75, 23);
            btnReturn.TabIndex = 6;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // lblRaton
            // 
            lblRaton.BackColor = SystemColors.MenuHighlight;
            lblRaton.Location = new Point(17, 193);
            lblRaton.Name = "lblRaton";
            lblRaton.Size = new Size(211, 134);
            lblRaton.TabIndex = 7;
            lblRaton.TextAlign = ContentAlignment.MiddleCenter;
            lblRaton.MouseMove += lblRaton_MouseMove;
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(102, 347);
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(100, 23);
            txtLetras.TabIndex = 8;
            txtLetras.KeyPress += txtLetras_KeyPress;
            // 
            // txtNums
            // 
            txtNums.Location = new Point(102, 400);
            txtNums.Name = "txtNums";
            txtNums.Size = new Size(100, 23);
            txtNums.TabIndex = 9;
            txtNums.KeyPress += txtNums_KeyPress;
            // 
            // lblLetras
            // 
            lblLetras.AutoSize = true;
            lblLetras.Location = new Point(30, 355);
            lblLetras.Name = "lblLetras";
            lblLetras.Size = new Size(61, 15);
            lblLetras.TabIndex = 10;
            lblLetras.Text = "Solo letras";
            // 
            // lblNums
            // 
            lblNums.AutoSize = true;
            lblNums.Location = new Point(30, 403);
            lblNums.Name = "lblNums";
            lblNums.Size = new Size(63, 15);
            lblNums.TabIndex = 11;
            lblNums.Text = "Solo nums";
            // 
            // Form14Metodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 439);
            Controls.Add(lblNums);
            Controls.Add(lblLetras);
            Controls.Add(txtNums);
            Controls.Add(txtLetras);
            Controls.Add(lblRaton);
            Controls.Add(btnReturn);
            Controls.Add(btnObj);
            Controls.Add(btnRef);
            Controls.Add(btnValor);
            Controls.Add(lblResultado);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Name = "Form14Metodos";
            Text = "Form14Metodos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private TextBox txtNumero;
        private Label lblResultado;
        private Button btnValor;
        private Button btnRef;
        private Button btnObj;
        private Button btnReturn;
        private Label lblRaton;
        private TextBox txtLetras;
        private TextBox txtNums;
        private Label lblLetras;
        private Label lblNums;
    }
}