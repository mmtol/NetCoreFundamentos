using System.Collections;

namespace NetCoreFundamentos
{
    public partial class Form15ArrayList : Form
    {
        public Form15ArrayList()
        {
            InitializeComponent();

            ArrayList coleccion = new ArrayList();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);

            //prueba 1
            ((Button)coleccion[0]).BackColor = Color.Aqua;

            //prueba 2
            foreach (Button btn in coleccion)
            {
                btn.BackColor = Color.LightSeaGreen;
            }

            //prueba 3
            coleccion.Add(this.textBox1);
            foreach (Control btn in coleccion)
            {
                btn.BackColor = Color.LightSalmon;

                //prueba 4
                if (btn is TextBox)
                {
                    ((TextBox)btn).Paste();
                }
            }

            //prueba 5
            List<Button> botones = new List<Button>();
            botones.Add(this.button1);
            botones.Add(this.button2);
            botones.Add(this.button3);

            List<Control> botones2 = new List<Control>();
            botones2.Add(this.button1);
            botones2.Add(this.button2);
            botones2.Add(this.button3);
            botones2.Add(this.textBox1);

            List<Object> botones3 = new List<Object>();
            botones3.Add(this.button1);
            botones3.Add(this.button2);
            botones3.Add(this.button3);
            botones3.Add("Hola");

            //prueba 6
            botones[0].BackColor = Color.LightGreen;

            ////////////////////////////////////////////////////////////////

            this.button1.Click += MetodoDelegado;
        }

        private void MetodoDelegado(object sender, EventArgs e)
        {

        }
    }
}
