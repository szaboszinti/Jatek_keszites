using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jatek
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        Stopwatch stopper = new Stopwatch();
        int varakozas;
        public Form1()
        {
            InitializeComponent();

            panel1.BackColor = System.Drawing.Color.Red;

            timer1.Interval = 100;
            timer1.Tick += timer1_Tick;

            panel1.Click += panel1_Click;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            panel1.BackColor = System.Drawing.Color.Red;
            lblIdo.Text = "Várj a zöld színre!";

            varakozas = rnd.Next(2000, 6000);
            timer1.Interval = varakozas;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            panel1.BackColor = System.Drawing.Color.Green;
            stopper.Restart();
        }


        private void panel1_Click(object sender, EventArgs e)
        {
            if (panel1.BackColor == System.Drawing.Color.Green)
            {
                stopper.Stop();

                lblIdo.Text = $"Reakcióidőd: {stopper.ElapsedMilliseconds} ms";
                panel1.BackColor = System.Drawing.Color.Red;
            }
        }
    }
}
