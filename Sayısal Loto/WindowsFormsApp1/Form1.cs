using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int a = random.Next(1,50);
            label1.Text = a.ToString();
            besit:
            int b = random.Next(1,50);

            if (a == b)
            {
                goto besit;
            }
            label2.Text = b.ToString();
            cesit:
            int c = random.Next(1, 50);
            if(b == c || c == a)
            {
                goto cesit;
            }
            label3.Text= c.ToString();
            evesit:
            int ev = random.Next(1, 50);
            if(c == ev || c == b || c == a)
            {
                goto evesit;
            }
            label4.Text = ev.ToString();
            fesit:
            int f = random.Next(1, 50);
            if(f == a|| f == b || f == c || f == ev)
            {
                goto fesit;
            }
            label5.Text = f.ToString();

            xesit:
            int x = random.Next(1, 50);
            if(x == a || x == b || x == c || x == ev || x == f)
            {
                goto xesit;
            }
            label6.Text = x.ToString();

        }

    }

}
