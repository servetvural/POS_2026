using System;
using System.Drawing;
using System.Windows.Forms;

namespace DTRMNS {
    public partial class frmImageDialog : Form {
        private Image img;
        public frmImageDialog(Image img) {
            InitializeComponent();
            this.img = img;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void frmImageDialog_Load(object sender, EventArgs e) {
            pBox.Image = img;
        }

        private void tsCenter_Click(object sender, EventArgs e) {
            pBox.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void tsNormal_Click(object sender, EventArgs e) {
            pBox.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void tsStrech_Click(object sender, EventArgs e) {
            pBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void tsAutoSize_Click(object sender, EventArgs e) {
            pBox.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void tsZoom_Click(object sender, EventArgs e) {
            pBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void DrawBorders() {
            GraphicsUnit units = GraphicsUnit.Point;

            RectangleF imgRectangleF = pBox.Image.GetBounds(ref units);
            Rectangle imgRectangle = Rectangle.Round(imgRectangleF);
            if (pBox.SizeMode == PictureBoxSizeMode.CenterImage) {
                if (imgRectangle.Width < pBox.Width)
                    imgRectangle.X = (pBox.Width - imgRectangle.Width) / 2;
                if (imgRectangle.Height < pBox.Height)
                    imgRectangle.Y = (pBox.Height - imgRectangle.Height) / 2;
            }

            Graphics g = pBox.CreateGraphics();
            g.DrawRectangle(Pens.Black, imgRectangle);
        }

        private void tsDrawBorders_Click(object sender, EventArgs e) {
            if (pBox.SizeMode == PictureBoxSizeMode.Normal || pBox.SizeMode == PictureBoxSizeMode.AutoSize
                || pBox.SizeMode == PictureBoxSizeMode.CenterImage)
                DrawBorders();
        }
    }
}
