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



        public Form1()
        {
            InitializeComponent();

            
            
            BitmapRegion.CreateControlRegion(pictureBox1, galati);
            BitmapRegion.CreateControlRegion(pictureBox2, vaslui);
            BitmapRegion.CreateControlRegion(pictureBox3, iasi);

            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;

            


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
