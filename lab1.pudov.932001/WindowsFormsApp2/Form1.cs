using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            MaximizeBox = false;
            InitializeComponent();
        }

        double t, x, y, v0, cosa, sina, S, m, k, vx, vy, dt, a, ymax=0;

        int i =-1;

        const double g = 9.81;
        const double C = 0.15;
        const double ro = 1.29;

        private void Timer1_Tick(object sender, EventArgs e)
        {
            t = t + dt;
            double v = Math.Sqrt((vx * vx + vy * vy));
            vx = vx - k * vx * v * dt;
            vy = vy - (g + k * vy * v) * dt;
            x = x + vx * dt;
            y = y + vy * dt;
            if (ymax < y) ymax = y;
            chart1.Series[i].Points.AddXY(x, y);
            if (y < 0)
            {
                LabelResX.Text = x.ToString();
                LabelResY.Text = ymax.ToString();
                LabelResStep.Text = dt.ToString();
                LabelSpeed.Text = v.ToString();

                Timer1.Stop();
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            y = (double)Visota.Value;
            m = (double)Massa.Value;
            v0 = (double)Skorost.Value;
            a = (double)Ygol.Value;
            S = (double)Ploshad.Value;
            dt = (double)Shag.Value/100;
            cosa = Math.Cos(a * Math.PI / 180);
            sina = Math.Sin(a * Math.PI / 180);
            k = 0.5 * C * ro * S / m;
            vx = v0 * cosa;
            vy = v0 * sina;
            t = 0; x = 0;

       
            if (NeskLiniy.Checked == false || i>3)
            {    
                i = 0;
                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }
            }
            else
            {
                i++;
            }

            chart1.Series[i].Points.AddXY(x, y);
            Timer1.Start();
        }
    }
}
