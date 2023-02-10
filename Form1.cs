using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer4._4._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Tiene errores de síntaxis corrígelos");

            string name ="Quentin";

            int x = 3;

            x = x * 17;

            double d = Math.PI / 2;

            MessageBox.Show("name is "+name + "\nx is "+x +"\nd is "+d);
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Tiene errores de síntaxis corrígelos");

            int cont = 0; while (cont < 10) //cont=0 
            {
                cont = cont + 1;   //cont=1
            }
            for (int i = 0; i < 5; i++) //i=1
            {
                cont = cont - 1;        //1-1=0
            }
            MessageBox.Show("La respuesta es: " +cont);  //cont 5
        }
    }
}
