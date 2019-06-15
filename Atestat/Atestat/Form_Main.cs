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

    public partial class Form_Main : Form
    {

        //All the bitmaps
        #region 
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
        private Bitmap satu_mare = new Bitmap(Properties.Resources.satu);
        private Bitmap salaj = new Bitmap(Properties.Resources.salaj);
        private Bitmap cluj = new Bitmap(Properties.Resources.cluj);
        private Bitmap alba = new Bitmap(Properties.Resources.alba);
        private Bitmap bihor = new Bitmap(Properties.Resources.bihor);
        private Bitmap arad = new Bitmap(Properties.Resources.arad);
        private Bitmap hunedoara = new Bitmap(Properties.Resources.hunedoara);
        private Bitmap timis = new Bitmap(Properties.Resources.timis);
        private Bitmap caras = new Bitmap(Properties.Resources.caras);
        #endregion
        //pawn icon
        Bitmap pawn = new Bitmap(Properties.Resources.pawn);
        Bitmap pawnRed = new Bitmap(Properties.Resources.pawn_red);
        Bitmap pawnGreen = new Bitmap(Properties.Resources.pawn_green);        


        //Definirea regiunii si stergerea imaginii de fundal
        public Form_Main()
        {
            InitializeComponent();

            
            
            BitmapRegion.CreateControlRegion(pictureBox1, galati,"galati");
            BitmapRegion.CreateControlRegion(pictureBox2, vaslui, "vaslui");
            BitmapRegion.CreateControlRegion(pictureBox3, iasi, "iasi");
            BitmapRegion.CreateControlRegion(pictureBox4, tulcea, "tulcea");
            BitmapRegion.CreateControlRegion(pictureBox5, braila, "braila");
            BitmapRegion.CreateControlRegion(pictureBox6, constanta, "constanta");
            BitmapRegion.CreateControlRegion(pictureBox7, calarasi, "calarasi");
            BitmapRegion.CreateControlRegion(pictureBox8, ialomita, "ialomita");
            BitmapRegion.CreateControlRegion(pictureBox9, botosani, "botosani");
            BitmapRegion.CreateControlRegion(pictureBox10, suceava, "suceava");
            BitmapRegion.CreateControlRegion(pictureBox11, neamt, "neamt");
            BitmapRegion.CreateControlRegion(pictureBox12, bacau, "bacau");
            BitmapRegion.CreateControlRegion(pictureBox13, vrancea, "vrancea");
            BitmapRegion.CreateControlRegion(pictureBox14, buzau, "buzau");
            BitmapRegion.CreateControlRegion(pictureBox15, harghita, "harghita");
            BitmapRegion.CreateControlRegion(pictureBox16, covasna, "covasna");
            BitmapRegion.CreateControlRegion(pictureBox17, prahova, "prahova");
            BitmapRegion.CreateControlRegion(pictureBox18, ilfov, "ilfov");
            BitmapRegion.CreateControlRegion(pictureBox19, giurgiu, "giurgiu");
            BitmapRegion.CreateControlRegion(pictureBox20, maramures, "maramures");
            BitmapRegion.CreateControlRegion(pictureBox21, bistrita, "bistrita");
            BitmapRegion.CreateControlRegion(pictureBox22, mures, "Mureș_County");
            BitmapRegion.CreateControlRegion(pictureBox23, brasov, "brasov");
            BitmapRegion.CreateControlRegion(pictureBox24, dambovita, "dambovita");
            BitmapRegion.CreateControlRegion(pictureBox25, teleorman, "teleorman");
            BitmapRegion.CreateControlRegion(pictureBox26, arges, "arges");
            BitmapRegion.CreateControlRegion(pictureBox27, sibiu, "sibiu");
            BitmapRegion.CreateControlRegion(pictureBox28, valcea, "valcea");
            BitmapRegion.CreateControlRegion(pictureBox29, olt, "olt");
            BitmapRegion.CreateControlRegion(pictureBox30, dolj, "dolj");
            BitmapRegion.CreateControlRegion(pictureBox31, mehedinti, "mehedinti");
            BitmapRegion.CreateControlRegion(pictureBox32, gorj, "gorj");
            BitmapRegion.CreateControlRegion(pictureBox33, satu_mare, "Satu_Mare");
            BitmapRegion.CreateControlRegion(pictureBox34, salaj, "Sălaj_County");
            BitmapRegion.CreateControlRegion(pictureBox35, cluj, "cluj");
            BitmapRegion.CreateControlRegion(pictureBox36, alba, "Alba_County");
            BitmapRegion.CreateControlRegion(pictureBox37, bihor, "Bihor_County");
            BitmapRegion.CreateControlRegion(pictureBox38, arad, "arad");
            BitmapRegion.CreateControlRegion(pictureBox39, hunedoara, "hunedoara");
            BitmapRegion.CreateControlRegion(pictureBox40, timis, "timis");
            BitmapRegion.CreateControlRegion(pictureBox41, caras, "caras-severin");

            //resize pawn icon
            pawn = ResizeBitmap(pawn, 32, 32);
            pawnRed = ResizeBitmap(pawnRed, 32, 32);
            pawnGreen = ResizeBitmap(pawnGreen, 32, 32);


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
        
        
        

        
        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
            {
                pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                if (pictureBox.Image == null)
                    pictureBox.Image = pawnGreen;
                else
                    pictureBox.Image = null;
            }
            else
                if(click.Button==MouseButtons.Right)
            {
                pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                if (pictureBox.Image == null)
                    pictureBox.Image = pawnRed;
                else
                    pictureBox.Image = null;
            }
            if (click.Button == MouseButtons.Middle)
            {
                if (pictureBox.Image != null)
                {
                    Bitmap newSize = (Bitmap)pictureBox.Image;
                    newSize = ResizeBitmap(pawn, (int)Math.Round(newSize.Width * 1.25), (int)Math.Round(newSize.Height * 1.25));
                    pictureBox.Image = newSize;
                }
            }
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
            Form_Main form= (Form_Main)sender;
            if (e.Button == MouseButtons.Left)
            {
                form.Capture = false;
                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =Message.Create(this.Handle, WM_NCLBUTTONDOWN,new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }
    }

}
