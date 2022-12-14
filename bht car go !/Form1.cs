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
        // değişkenler tanımlandı
        int seritsayisi = 1;
        int yol = 0;
        int hız = 70;
        //rastgele gelecek olan arabalar için R tanımlandı
        Random R = new Random();
        class random_car
        {
            public bool fakehavecar = false;
            public PictureBox fakecar;
            public bool vakit = false;
        }
        random_car[] rndcar = new random_car[2];
        // oyunumuzda trafikteki arabaların rastgele gelmesini sağlayacak random komutunu kullandık
        void bringrandomcar(PictureBox pb)
        {
            int rnd = R.Next(0, 4);
            switch (rnd)
            {
                case 0:
                    pb.Image = Properties.Resources.car0;
                    break;
                case 1:
                    pb.Image = Properties.Resources.car1;
                    break;
                case 2:
                    pb.Image = Properties.Resources.car2;
                    break;
                case 3:
                    pb.Image = Properties.Resources.car3;
                    break;

            }
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
        }


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
        //if else location komutlarıyla araba sağ sol yaptıgında bulunması gereken yerler belirlendi
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
        //// arabaya e.keykode ile yön tuşları atandı
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right || e.KeyCode ==Keys.D)
            {
                if (seritsayisi < 2)
                    seritsayisi++;
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode ==Keys.A)
            {
                if (seritsayisi > 0)
                    seritsayisi--;
            }
            aracyerine();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (var i = 0; i < rndcar.Length; i++)
            {
                rndcar[i] = new random_car();

            }
            rndcar[0].vakit = true;
            aracyerine();
        }
        // grafiğimizdeki şeritleri for döngüsüyle sonsuz döngüye sokarak hep haraket etmesini sağladık.
        bool seritharaket = false;
        private void timerserit_Tick(object sender, EventArgs e)
        {
            if (seritharaket == false)
            {
                for (int i =1;i<7;i++ )
                {
                    this.Controls.Find("labelsolserit" + i.ToString(), true)[0].Top -= 25;
                    this.Controls.Find("labelsagserit" + i.ToString(), true)[0].Top -= 25;
                    seritharaket = true;

                }
            }
            else
            {
                for (int i = 1; i < 7; i++)
                {
                    this.Controls.Find("labelsolserit" + i.ToString(), true)[0].Top += 25;
                    this.Controls.Find("labelsagserit" + i.ToString(), true)[0].Top += 25;
                    seritharaket = false;

                }
            }

        

    
            

        }

        private void timerrandomcar_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < rndcar.Length; i++)
            {
                if (!rndcar[i].fakehavecar && rndcar[i].vakit)
                {
                    rndcar[i].fakecar = new PictureBox();
                    bringrandomcar(rndcar[i].fakecar);
                    rndcar[i].fakecar.Size = new Size(90, 150);
                    rndcar[i].fakecar.Top = -rndcar[i].fakecar.Height;

                    int seriteyerlestir = R.Next(0, 3);

                    if (seriteyerlestir == 0)
                    {
                        rndcar[i].fakecar.Left = 55;
                    }
                    else if (seriteyerlestir == 1)
                    {
                        rndcar[i].fakecar.Left = 210;
                    }
                    else if (seriteyerlestir == 2)
                    {
                        rndcar[i].fakecar.Left = 390;
                    }

                    this.Controls.Add(rndcar[i].fakecar);
                    rndcar[i].fakehavecar = true;
                }
                 else
                {
                    if (rndcar[i].vakit)
                    {
                        rndcar[i].fakecar.Top += 20;
                        if (rndcar[i].fakecar.Top >=154)
                        {
                            for (int j=0;j < rndcar.Length; j++)
                            {
                                if (!rndcar[j].vakit)
                                {
                                    rndcar[j].vakit = true;
                                    break;
                                }
                            }
                        }
                    }
                    if (rndcar[i].fakecar.Top >= this.Height -= 20)
                    {

                        rndcar[i].fakecar.Dispose();
                        rndcar[i].fakehavecar = false;
                        rndcar[i].vakit = false;
                    }
                }
            }
        }
    }
}
