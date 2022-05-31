using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Termometro
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
            //Declarar plumas de dibujo
            Pen plumaRoja = new Pen(Color.Red, 3f);
            this.Refresh();
            //Declara la superficie de trabajo
            Graphics superfice = CreateGraphics();

            //Declarar los puntos o coordenadas
            float x, y;

            //PointF punto1 = new PointF(243,205);
            //PointF punto2 = new PointF(243,60);
            double angulo;
            int magnitud = 180;
            float cent = (int)numericUpDown1.Value * 3;
            int X, Y;

            //Dibuja la línea
            /*
            x = (float)numericUpDown1.Value+x;
            y = (float)Math.Sin((float)x * (Math.PI / 180)) * 10;
            punto2.X = x;
            punto2.Y = y + 60;
            */
            angulo = cent;
            angulo = (angulo - 90);
            angulo = (angulo * Math.PI) / 180;

            x = magnitud * (float)Math.Cos(angulo);
            y = magnitud * (float)Math.Sin(angulo);

            X = Convert.ToInt32(x);
            Y = Convert.ToInt32(y);

            
            superfice.DrawLine(plumaRoja, 245, 205, (X + 243), (Y + 200));

            //Libera el espacio
            superfice.Dispose();
            label1.Text = (numericUpDown1.Value + 20).ToString();
        
         
          }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
   
        }

    }
}
