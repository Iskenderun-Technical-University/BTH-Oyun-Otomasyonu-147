using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bht_car_go__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int seritsayisi = 1;


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

       

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void labelsolserit5_Click(object sender, EventArgs e)
        {

        }

        private void labelsolserit4_Click(object sender, EventArgs e)
        {

        }

        private void labelsolserit3_Click(object sender, EventArgs e)
        {

        }

        private void labelsolserit2_Click(object sender, EventArgs e)
        {

        }

        private void labelsolserit6_Click(object sender, EventArgs e)
        {

        }

        private void kırmızıaraba_Click(object sender, EventArgs e)
        {

        }
        private void aracyerine()
        {
            if(seritsayisi==1)
            {
                kırmızıaraba.Location = new Point(235 , 360);
            }
            else if  (seritsayisi == 0)
            {
                kırmızıaraba.Location = new Point(70, 360);
            }
            else if (seritsayisi == 2)
            {
                kırmızıaraba.Location = new Point(385, 360);
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                if (seritsayisi < 2)
                    seritsayisi++;
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (seritsayisi > 0)
                    seritsayisi--;
            }
            aracyerine();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            aracyerine();
        }
    }
}
