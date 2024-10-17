using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0___ConversorTemperaturasGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void boton_Click(object sender, EventArgs e)
        {
            double v1;
            v1 = double.Parse(Grados.Text);

            kelvin(v1);
            farenheit(v1);

        }
        void kelvin(double v1)
        {
            gradosK.Text = v1 + 273 + " °K";
        }

        void farenheit(double v1)
        {
            gradosF.Text = v1 * 18 / 10 + 32 + " °F";
        }

    }
}
