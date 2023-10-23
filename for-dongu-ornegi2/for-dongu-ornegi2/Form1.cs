using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_dongu_ornegi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int topla, sayi1, sayi2;
            topla = 0;
            sayi1 =Convert.ToInt32(textBox1.Text);
            sayi2 =Convert.ToInt32(textBox2.Text);
            for(int i=sayi1; i <= sayi2; ++i)
            {
                topla += i;
            }
            label3.Text=topla.ToString();
        }
    }
}
