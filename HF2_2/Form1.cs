using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace HF2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Bitmap buffer;
       public Graphics bufferg;


        Thread t;

        public void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            t = new Thread(new ThreadStart(szal));
            t.Start();
        }

        void szal()
        {
            bufferg.Clear(Color.White);

            int h, w;

            lock (buffer)
            {
               h = buffer.Height;
                w = buffer.Width;
            }

            for (int y = 0; y < h; y++)
                for (int x = 0; x < w; x++)
                    if (PS.Prime(y * w + x)==true)
                        lock (buffer)
                            buffer.SetPixel(x, y, Color.Black);

            this.Invoke(new Action(() => { button1.Enabled = true; }));
        }
        

        public void panel2_Paint(object sender, PaintEventArgs e)
        {
             

        }

       public void Form1_Load(object sender, EventArgs e)
        {
            buffer = new Bitmap(panel2.Width, panel2.Height);
            lock (buffer)
                bufferg = Graphics.FromImage(buffer);
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            if (buffer == null)
                return;

            using (Graphics g = panel2.CreateGraphics())
            {
                lock (buffer)
                    g.DrawImage(buffer, 0, 0);
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }


        public void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            //public int szam = e.Y * Buffer.width + e.X;

            Form2 f2 = new Form2 (String.Format("X={0}; Y={1}", e.X, e.Y));
            f2.ShowDialog(this);
        }

        private void panel2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
