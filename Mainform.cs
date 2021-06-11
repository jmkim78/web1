using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FDS10Client_Setup
{
    public partial class Mainform : Form
    {
        public static string step = "1";
        public Mainform()
        {
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.TopLevel = false;
            f1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Controls.Add(f1);
            f1.Show();

            label2.Text = step;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = step;
        }

        private void label2_TextChanged(object sender, EventArgs e)
        {
            if (step == "1")
            {
                panel1.Controls.Clear();
                Form1 f1 = new Form1();
                f1.TopLevel = false;
                f1.Dock = DockStyle.Fill;
                panel1.Controls.Add(f1);
                f1.Show();
            }
            if (step == "2")
            {
                panel1.Controls.Clear();
                Form2 f2 = new Form2();
                f2.TopLevel = false;
                f2.Dock = DockStyle.Fill;
                panel1.Controls.Add(f2);
                f2.Show();
            }
            if (step == "3")
            {
                panel1.Controls.Clear();
                Form3 f3 = new Form3();
                f3.TopLevel = false;
                f3.Dock = DockStyle.Fill;
                panel1.Controls.Add(f3);
                f3.Show();
            }
            if (step == "4")
            {
                panel1.Controls.Clear();
                Form4 f4 = new Form4();
                f4.TopLevel = false;
                f4.Dock = DockStyle.Fill;
                panel1.Controls.Add(f4);
                f4.Show();
            }
        }
    }
}
