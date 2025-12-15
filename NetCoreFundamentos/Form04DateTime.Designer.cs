namespace NetCoreFundamentos
{
    partial class Form04DateTime
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
            lblFechaInicial = new Label();
            txtFechaInicial = new TextBox();
            chkFormato = new CheckBox();
            rdbDias = new RadioButton();
            rdbMeses = new RadioButton();
            rdbAnhos = new RadioButton();
            lblIncremento = new Label();
            txtIncremento = new TextBox();
            btnIncrementar = new Button();
            txtFechaFinal = new TextBox();
            lblFechaFinal = new Label();
            SuspendLayout();
            // 
            // lblFechaInicial
            // 
            lblFechaInicial.AutoSize = true;
            lblFechaInicial.Location = new Point(46, 64);
            lblFechaInicial.Name = "lblFechaInicial";
            lblFechaInicial.Size = new Size(73, 15);
            lblFechaInicial.TabIndex = 0;
            lblFechaInicial.Text = "Fecha actual";
            // 
            // txtFechaInicial
            // 
            txtFechaInicial.Location = new Point(21, 96);
            txtFechaInicial.Name = "txtFechaInicial";
            txtFechaInicial.Size = new Size(197, 23);
            txtFechaInicial.TabIndex = 1;
            // 
            // chkFormato
            // 
            chkFormato.AutoSize = true;
            chkFormato.Location = new Point(46, 164);
            chkFormato.Name = "chkFormato";
            chkFormato.Size = new Size(117, 19);
            chkFormato.TabIndex = 2;
            chkFormato.Text = "Cambiar formato";
            chkFormato.UseVisualStyleBackColor = true;
            chkFormato.CheckedChanged += chkFormato_CheckedChanged;
            // 
            // rdbDias
            // 
            rdbDias.AutoSize = true;
            rdbDias.Location = new Point(273, 100);
            rdbDias.Name = "rdbDias";
            rdbDias.Size = new Size(47, 19);
            rdbDias.TabIndex = 3;
            rdbDias.TabStop = true;
            rdbDias.Text = "Dias";
            rdbDias.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            rdbMeses.AutoSize = true;
            rdbMeses.Location = new Point(273, 125);
            rdbMeses.Name = "rdbMeses";
            rdbMeses.Size = new Size(58, 19);
            rdbMeses.TabIndex = 4;
            rdbMeses.TabStop = true;
            rdbMeses.Text = "Meses";
            rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbAnhos
            // 
            rdbAnhos.AutoSize = true;
            rdbAnhos.Location = new Point(273, 150);
            rdbAnhos.Name = "rdbAnhos";
            rdbAnhos.Size = new Size(52, 19);
            rdbAnhos.TabIndex = 5;
            rdbAnhos.TabStop = true;
            rdbAnhos.Text = "Años";
            rdbAnhos.UseVisualStyleBackColor = true;
            // 
            // lblIncremento
            // 
            lblIncremento.AutoSize = true;
            lblIncremento.Location = new Point(252, 26);
            lblIncremento.Name = "lblIncremento";
            lblIncremento.Size = new Size(68, 15);
            lblIncremento.TabIndex = 6;
            lblIncremento.Text = "Incremento";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(252, 58);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(100, 23);
            txtIncremento.TabIndex = 7;
            // 
            // btnIncrementar
            // 
            btnIncrementar.Location = new Point(252, 187);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(100, 37);
            btnIncrementar.TabIndex = 8;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // txtFechaFinal
            // 
            txtFechaFinal.Location = new Point(62, 286);
            txtFechaFinal.Name = "txtFechaFinal";
            txtFechaFinal.Size = new Size(269, 23);
            txtFechaFinal.TabIndex = 10;
            // 
            // lblFechaFinal
            // 
            lblFechaFinal.AutoSize = true;
            lblFechaFinal.Location = new Point(166, 268);
            lblFechaFinal.Name = "lblFechaFinal";
            lblFechaFinal.Size = new Size(64, 15);
            lblFechaFinal.TabIndex = 9;
            lblFechaFinal.Text = "Fecha final";
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 346);
            Controls.Add(txtFechaFinal);
            Controls.Add(lblFechaFinal);
            Controls.Add(btnIncrementar);
            Controls.Add(txtIncremento);
            Controls.Add(lblIncremento);
            Controls.Add(rdbAnhos);
            Controls.Add(rdbMeses);
            Controls.Add(rdbDias);
            Controls.Add(chkFormato);
            Controls.Add(txtFechaInicial);
            Controls.Add(lblFechaInicial);
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFechaInicial;
        private TextBox txtFechaInicial;
        private CheckBox chkFormato;
        private RadioButton rdbDias;
        private RadioButton rdbMeses;
        private RadioButton rdbAnhos;
        private Label lblIncremento;
        private TextBox txtIncremento;
        private Button btnIncrementar;
        private TextBox txtFechaFinal;
        private Label lblFechaFinal;
    }
}