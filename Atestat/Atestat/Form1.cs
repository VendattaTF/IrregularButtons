using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Atestat
{
    
    public partial class Form1 : Form
    {


        private Bitmap romania = new Bitmap(Properties.Resources.romania);
        private Bitmap galati = new Bitmap(Properties.Resources.galati);
        private Bitmap vaslui = new Bitmap(Properties.Resources.Vaslui);
        private Bitmap iasi = new Bitmap(Properties.Resources.iasi);
        private Bitmap tulcea = new Bitmap(Properties.Resources.tulcea);
        private Bitmap braila = new Bitmap(Properties.Resources.braila);
        private Bitmap constanta = new Bitmap(Properties.Resources.constanta);
        private Bitmap calarasi = new Bitmap(Properties.Resources.calarasi);
        private Bitmap ialomita = new Bitmap(Properties.Resources.ialomita);
        private Bitmap botosani = new Bitmap(Properties.Resources.botosani);
        private Bitmap suceava = new Bitmap(Properties.Resources.suceava);
        private Bitmap neamt = new Bitmap(Properties.Resources.neamt);
        private Bitmap bacau = new Bitmap(Properties.Resources.bacau);
        private Bitmap vrancea = new Bitmap(Properties.Resources.vrancea);
        private Bitmap buzau = new Bitmap(Properties.Resources.buzau);
        private Bitmap harghita = new Bitmap(Properties.Resources.harghita);
        private Bitmap covasna = new Bitmap(Properties.Resources.covasna);
        private Bitmap prahova = new Bitmap(Properties.Resources.prahova);
        private Bitmap ilfov = new Bitmap(Properties.Resources.ilfov);
        private Bitmap giurgiu = new Bitmap(Properties.Resources.giurgiu);
        private Bitmap maramures = new Bitmap(Properties.Resources.maramures);
        private Bitmap bistrita = new Bitmap(Properties.Resources.bistrita);
        private Bitmap mures = new Bitmap(Properties.Resources.mures);
        private Bitmap brasov = new Bitmap(Properties.Resources.brasov);
        private Bitmap dambovita = new Bitmap(Properties.Resources.dambovita);
        private Bitmap teleorman = new Bitmap(Properties.Resources.teleorman);
        private Bitmap arges = new Bitmap(Properties.Resources.arges);
        private Bitmap sibiu = new Bitmap(Properties.Resources.sibiu);
        private Bitmap valcea = new Bitmap(Properties.Resources.valcea);
        private Bitmap olt = new Bitmap(Properties.Resources.olt);
        private Bitmap dolj = new Bitmap(Properties.Resources.dolj);
        private Bitmap mehedinti = new Bitmap(Properties.Resources.mehedinti);
        private Bitmap gorj = new Bitmap(Properties.Resources.gorj);
        private Bitmap satu = new Bitmap(Properties.Resources.satu);
        private Bitmap salaj = new Bitmap(Properties.Resources.salaj);
        private Bitmap cluj = new Bitmap(Properties.Resources.cluj);
        private Bitmap alba = new Bitmap(Properties.Resources.alba);
        private Bitmap bihor = new Bitmap(Properties.Resources.bihor);
        private Bitmap arad = new Bitmap(Properties.Resources.arad);
        private Bitmap hunedoara = new Bitmap(Properties.Resources.hunedoara);
        private Bitmap timis = new Bitmap(Properties.Resources.timis);
        private Bitmap caras = new Bitmap(Properties.Resources.caras);
        




        public Form1()
        {
            InitializeComponent();

            
            
            BitmapRegion.CreateControlRegion(pictureBox1, galati);
            BitmapRegion.CreateControlRegion(pictureBox2, vaslui);
            BitmapRegion.CreateControlRegion(pictureBox3, iasi);
            BitmapRegion.CreateControlRegion(pictureBox4, tulcea);
            BitmapRegion.CreateControlRegion(pictureBox5, braila);
            BitmapRegion.CreateControlRegion(pictureBox6, constanta);
            BitmapRegion.CreateControlRegion(pictureBox7, calarasi);
            BitmapRegion.CreateControlRegion(pictureBox8, ialomita);
            BitmapRegion.CreateControlRegion(pictureBox9, botosani);
            BitmapRegion.CreateControlRegion(pictureBox10, suceava);
            BitmapRegion.CreateControlRegion(pictureBox11, neamt);
            BitmapRegion.CreateControlRegion(pictureBox12, bacau);
            BitmapRegion.CreateControlRegion(pictureBox13, vrancea);
            BitmapRegion.CreateControlRegion(pictureBox14, buzau);
            BitmapRegion.CreateControlRegion(pictureBox15, harghita);
            BitmapRegion.CreateControlRegion(pictureBox16, covasna);
            BitmapRegion.CreateControlRegion(pictureBox17, prahova);
            BitmapRegion.CreateControlRegion(pictureBox18, ilfov);
            BitmapRegion.CreateControlRegion(pictureBox19, giurgiu);
            BitmapRegion.CreateControlRegion(pictureBox20, maramures);
            BitmapRegion.CreateControlRegion(pictureBox21, bistrita);
            BitmapRegion.CreateControlRegion(pictureBox22, mures);
            BitmapRegion.CreateControlRegion(pictureBox23, brasov);
            BitmapRegion.CreateControlRegion(pictureBox24, dambovita);
            BitmapRegion.CreateControlRegion(pictureBox25, teleorman);
            BitmapRegion.CreateControlRegion(pictureBox26, arges);
            BitmapRegion.CreateControlRegion(pictureBox27, sibiu);
            BitmapRegion.CreateControlRegion(pictureBox28, valcea);
            BitmapRegion.CreateControlRegion(pictureBox29, olt);
            BitmapRegion.CreateControlRegion(pictureBox30, dolj);
            BitmapRegion.CreateControlRegion(pictureBox31, mehedinti);
            BitmapRegion.CreateControlRegion(pictureBox32, gorj);
            BitmapRegion.CreateControlRegion(pictureBox33, satu);
            BitmapRegion.CreateControlRegion(pictureBox34, salaj);
            BitmapRegion.CreateControlRegion(pictureBox35, cluj);
            BitmapRegion.CreateControlRegion(pictureBox36, alba);
            BitmapRegion.CreateControlRegion(pictureBox37, bihor);
            BitmapRegion.CreateControlRegion(pictureBox38, arad);
            BitmapRegion.CreateControlRegion(pictureBox39, hunedoara);
            BitmapRegion.CreateControlRegion(pictureBox40, timis);
            BitmapRegion.CreateControlRegion(pictureBox41, caras);

            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
            pictureBox10.Image = null;
            pictureBox11.Image = null;
            pictureBox12.Image = null;
            pictureBox13.Image = null;
            pictureBox14.Image = null;
            pictureBox15.Image = null;
            pictureBox16.Image = null;          
            pictureBox17.Image = null;          
            pictureBox18.Image = null;          
            pictureBox19.Image = null;          
            pictureBox20.Image = null;          
            pictureBox21.Image = null;          
            pictureBox22.Image = null;          
            pictureBox23.Image = null;          
            pictureBox24.Image = null;          
            pictureBox25.Image = null;          
            pictureBox26.Image = null;          
            pictureBox27.Image = null;          
            pictureBox28.Image = null;          
            pictureBox29.Image = null;          
            pictureBox30.Image = null;          
            pictureBox31.Image = null;          
            pictureBox32.Image = null;          
            pictureBox33.Image = null;          
            pictureBox34.Image = null;          
            pictureBox35.Image = null;          
            pictureBox36.Image = null;          
            pictureBox37.Image = null;          
            pictureBox38.Image = null;          
            pictureBox39.Image = null;          
            pictureBox40.Image = null;          
            pictureBox41.Image = null;          



        }


        

        
        public Bitmap ResizeBitmap(Bitmap bmp, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }

            return result;
        }

        

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("12");
        }

        
        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BackColor = Color.FromArgb(50, Color.Blue);
        }
        
        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Form1 panel = (Form1)sender;
            if (e.Button == MouseButtons.Left)
            {

                panel.Capture = false;


                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }

        
    }

}
