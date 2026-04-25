using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yılanoyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Panel body_part;
        Panel nuts = new Panel();
        List<Panel> yilan = new List<Panel>();

        string yon = "sag";
        
        private void start_Click(object sender, EventArgs e)
        {
            skor.Text ="0";
            panelSil();
            body_part = new Panel();
            body_part.Location = new Point(200, 200);
            body_part.Size = new Size(20, 20);
            body_part.BackColor = Color.Gray;
            yilan.Add(body_part);
            panel1.Controls.Add(yilan[0]);

            timer1.Start();
            nutsOlustur();

            
        }

        void carptımı()
        {
            for(int i = 2; i < yilan.Count; i++)
            {
                if (yilan[0].Location == yilan[i].Location)
                {
                    tebriks.Visible = true;
                    tebriks.Text = "KAYBETTİN :(";
                    timer1.Stop();

                }
            }
        }

        void panelSil()
        {
            panel1.Controls.Clear();
            yilan.Clear();
            tebriks.Visible= false;
        }

        void puanKontrol()
        {
            int puan = int.Parse (skor.Text);
            if(puan > 500)
            {
                tebriks.Text = "TEBRİKLER :)";
                tebriks.Visible = true;
                timer1.Stop();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void skor_Click(object sender, EventArgs e)
        {

        }

        void nutsOlustur()
        {
            Random rnd = new Random();
            int nutsx, nutsy;
            nutsx = rnd.Next(580);
            nutsy = rnd.Next(580);

            nutsx -= nutsx % 20;
            nutsy -= nutsy % 20;

            nuts.Size = new Size(20, 20);
            nuts.BackColor = Color.Red;
            nuts.Location = new Point(nutsx, nutsy);
            panel1.Controls.Add(nuts);

        }

        void isnutseat()
        {
            int puan = int.Parse(skor.Text);
            if (yilan[0].Location == nuts.Location)
            {
                panel1.Controls.Remove(nuts);

                puan += 5;
                skor.Text = puan.ToString();
                nutsOlustur();
                addbody();
            }
           
        }

        void addbody()
        {
            Panel ekbody = new Panel();
            ekbody.Size = new Size(20, 20);
            ekbody.BackColor = Color.Yellow;
            yilan.Add(ekbody);
            panel1.Controls.Add(ekbody);
        }

        void hareket()
        {
            for (int i = yilan.Count - 1; i > 0; i--)
            {
                yilan[i].Location = yilan[i - 1].Location;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                yon = "sag"; 
            if (e.KeyCode == Keys.Left)
                yon = "sol";
            if (e.KeyCode == Keys.Up)
                yon = "yukari";
            if (e.KeyCode == Keys.Down)
                yon = "asagi";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int locx = yilan[0].Location.X;
            int locy = yilan[0].Location.Y;

            isnutseat();
            hareket();
            carptımı();
            puanKontrol();

            if(yon == "sag")
            {
                if(locx < 580)
                {
                    locx += 20;
                }
                else
                {
                    locx = 0;
                }
            }

            if (yon == "sol")
            {
                if (locx > 0 )
                {
                    locx -= 20;
                }
                else
                {
                    locx = 580;
                }
            }

            if (yon == "asagi")
            {
                if (locy < 580)
                {
                    locy += 20;
                }
                else
                {
                    locy = 0;
                }
            }

            if (yon == "yukari")
            {
                if (locy > 0 )
                {
                    locy -= 20;
                }
                else
                {
                    locy = 580;
                }
            }
            yilan[0].Location = new Point(locx, locy);
        }

        private void tebriks_Click(object sender, EventArgs e)
        {

        }
    }
}
