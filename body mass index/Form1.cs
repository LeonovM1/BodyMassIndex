using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Индекс_Массы_тела_шарп
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        double weight;
        double height;
        private void button1_Click(object sender, EventArgs e)
        {
            height = Convert.ToDouble(textBox1.Text) / 100;
            weight = Convert.ToDouble(textBox2.Text);
            label3.Text = Convert.ToString(weight / (height * height));
            if(label3.Text.Length >5)
            {
                label3.Text = label3.Text.Substring(0, 5);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
