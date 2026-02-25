using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using DTRMNS;

namespace DTRMSimpleBackOffice {
    public partial class frmScreenSaver : Form {

        private List<ScreenSaverImage> imgList;
        private int totalimagecount;

        public frmScreenSaver()
        {
            InitializeComponent();
            btnLoad_Click(null, null);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles("F:\\img");            

            imgList = new List<ScreenSaverImage>();
            Random rnd = new Random();
            totalimagecount = files.Length;
            int spacer = totalimagecount * 20;

            int sswidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ssheight = Screen.PrimaryScreen.WorkingArea.Height;

            for (int i=0; i < totalimagecount; i++)
            {
                spacer += rnd.Next(100);
                imgList.Add(new ScreenSaverImage(Image.FromFile(files[i]), sswidth, ssheight, spacer , false,-1 * rnd.Next(20), 0));
            }
        }

        private void track_ValueChanged(object sender, EventArgs e)
        {
            tmrMain.Interval = track.Value;
        }


        private void tmrMain_Tick(object sender, EventArgs e)
        {
            Random random = new Random(100);
            pBox.Refresh();
        }

        private void pBox_Paint(object sender, PaintEventArgs e)
        {
            if (imgList != null)
            {
                for (int i = 0; i < totalimagecount; i++)
                {
                    imgList[i].Step();
                    e.Graphics.DrawImage(imgList[i].image, imgList[i].location);
                }
            }            
        }

        private void frmScreenSaver_Load(object sender, EventArgs e)
        {
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
        }

        private void pBox_MouseMove(object sender, MouseEventArgs e)
        {
            //Close();
        }

        private void pBox_MouseDown(object sender, MouseEventArgs e)
        {
            Close();
        }
    }
}
