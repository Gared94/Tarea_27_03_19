using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmPrincipal : Form
    {


        public FrmPrincipal()
        {
            InitializeComponent();

            textBox.Text = "0";
            textBox2.Text = "0";
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            suma s = new suma();
            int a, b, r;
            a = int.Parse(textBox.Text);
            b = int.Parse(textBox2.Text);

            label3.Text = s.sumas(a, b).ToString();

        }

        public void button2_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            textBox2.Text = "";
            label3.Text = "Resultado";
        }

        public void button5_Click(object sender, EventArgs e)
        {
            multiplicacion s = new multiplicacion();
            int a, b, r;
            a = int.Parse(textBox.Text);
            b = int.Parse(textBox2.Text);

            label3.Text = s.multiplicaciones(a, b).ToString();
        }

        public void button3_Click(object sender, EventArgs e)
        {

            resta s = new resta();
            int a, b, r;
            a = int.Parse(textBox.Text);
            b = int.Parse(textBox2.Text);

            label3.Text = s.restas(a, b).ToString();
        }

        public void button4_Click(object sender, EventArgs e)
        {
            division s = new division();
            int a, b, r;
            a = int.Parse(textBox.Text);
            b = int.Parse(textBox2.Text);

            label3.Text = s.divisiones(a, b).ToString();
        }

        public void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        
    }

}
