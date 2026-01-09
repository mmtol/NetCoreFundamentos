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
            txtNombre = new TextBox();
            label2 = new Label();
            txtEdad = new TextBox();
            label1 = new Label();
            btnExaminar = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(28, 114);
            txtRaza.Multiline = true;
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(117, 23);
            txtRaza.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 96);
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
            // txtNombre
            // 
            txtNombre.Location = new Point(28, 60);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(117, 23);
            txtNombre.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 42);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 20;
            label2.Text = "Nombre";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(28, 171);
            txtEdad.Multiline = true;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(117, 23);
            txtEdad.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 153);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 29;
            label1.Text = "Edad";
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(285, 207);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(75, 23);
            btnExaminar.TabIndex = 47;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(195, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(197, 221);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 45;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(197, 185);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 44;
            button2.Text = "Leer Mascotas";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form23ObjetoMascota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 259);
            Controls.Add(btnExaminar);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(txtEdad);
            Controls.Add(label1);
            Controls.Add(txtRaza);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Name = "Form23ObjetoMascota";
            Text = "Form23ObjetoMascota";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRaza;
        private Label label4;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtEdad;
        private Label label1;
        private Button btnExaminar;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private OpenFileDialog openFileDialog1;
    }
}