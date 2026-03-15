using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

using POSLayer.Models;

using POSWinFormLayer;

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DTRMNS {
    public partial class frmGenericImageEditor : Form {
        private DTRMSimpleBusiness bslayer;
        public GenericImage gim;
        private bool blnLockID;
        private string setID;

        public frmGenericImageEditor(DTRMSimpleBusiness bslayer, GenericImage gim) {
            InitializeComponent();
            this.bslayer = bslayer;
            this.gim = gim;
        }
        public frmGenericImageEditor(DTRMSimpleBusiness bslayer, GenericImage gim,string setID) {
            InitializeComponent();
            this.bslayer = bslayer;
            this.gim = gim;
            this.setID = setID;
            blnLockID = true;
        }
        public frmGenericImageEditor() {
            InitializeComponent();
        }

        private void frmGenericImageEditor_Load(object sender, EventArgs e) {
            LoadImage();
        }

        private void LoadImage() {
            if (gim != null) {
                txtImageID.Text = gim.ReferenceIID;
                txtFileName.Text = gim.ImageFileName;
                txtExtra.Text = gim.ExtraText;
                pbox.Image = UFWin.ByteArrayToImage( gim.DisplayImage);
                txtDimensions.Text = pbox.Image.PhysicalDimension.ToString();

                udWidth.Value = pbox.Image.Width;
                udHeight.Value = pbox.Image.Height;

                lblRatio.Text = UFWin.RatioTimesWidthForHeight(pbox.Image).ToString("n2");

                lblFileSize.Text = gim.ImageSizeinKB.ToString("#,##0") + " KB";
            }
            if (blnLockID) {
                txtImageID.Enabled = txtExtra.Enabled = false;
                txtImageID.Text = setID;
                txtFileName.Text = setID;
                txtExtra.Text = setID;                
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void btnSaveAs_Click(object sender, EventArgs e) {
            if (gim == null)
                return;
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "All Files | *.*|GIF Images |*.gif|JPG  Images|*.jpg|JPEG Images |*.jpeg|PNG Images|*.png";
            dlg.Title = "Save this image as ";
            dlg.FileName = gim.ImageFileName;
            if (dlg.ShowDialog() == DialogResult.OK) {
                try {
                    //await bslayer.SaveGenericImage(gim)
                    File.WriteAllBytes(dlg.FileName, gim.DisplayImage);
                    //gim.DisplayImage.Save(dlg.FileName); //, ImageFormat.Jpeg);
                    gim.ImageFileName = dlg.FileName;
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e) {
            if (gim == null)
                return;

            gim.ReferenceIID = txtImageID.Text;
            gim.ImageFileName = txtFileName.Text;
            gim.ExtraText = txtExtra.Text;
            gim.DisplayImage = pbox.Image.ToByteArray();

            if (await bslayer.SaveGenericImage(gim)) {
                this.DialogResult = DialogResult.OK;
                Close();
            }

        }

        private void btnLoadImage_Click(object sender, EventArgs e) {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Files | *.*|GIF Images |*.gif|JPG  Images|*.jpg|JPEG Images |*.jpeg|PNG Images|*.png";
            dlg.Multiselect = false;
            dlg.Title = "Generic Image";

            if (dlg.ShowDialog() == DialogResult.OK) {
                FileInfo finfo = new FileInfo(dlg.FileName);
                gim = LoadGenericImage(finfo);
                LoadImage();
            }
        }

        public GenericImage LoadGenericImage(FileInfo finfo)
        {
            // this.ReferenceIID = ReferenceIID;
            GenericImage gim = null;
            gim.DisplayImage = UF.LoadBitmapNolock(finfo.FullName).ToByteArray();
            gim.ImageFileName = finfo.Name;
            return gim;
        }

        private void ViewMode_CheckedChanged(object sender, EventArgs e) {
            if (rbZoom.Checked)
                pbox.SizeMode = PictureBoxSizeMode.Zoom;
            else if (rbCenter.Checked)
                pbox.SizeMode = PictureBoxSizeMode.CenterImage;
            else if (rbStrech.Checked)
                pbox.SizeMode = PictureBoxSizeMode.StretchImage;
            else if (rbNormal.Checked)
                pbox.SizeMode = PictureBoxSizeMode.Normal;
            else if (rbAutoSize.Checked)
                pbox.SizeMode = PictureBoxSizeMode.AutoSize;
        }



        private void chkRatio_CheckedChanged(object sender, EventArgs e) {
            if (chkRatio.Checked)
                chkRatio.BackgroundImage = Properties.Resources.LockClosedRed32;
            else
                chkRatio.BackgroundImage = Properties.Resources.LockOpenGreen32;
        }



        private void pbox_MouseDown(object sender, MouseEventArgs e) {
            if (pbox.Image != null) {
                switch (e.Button) {
                    case MouseButtons.Left:
                        Cursor.Current = Cursors.Cross;
                        nudX.Value = e.X;
                        nudY.Value = e.Y;
                        nudW.Value = 0;
                        nudH.Value = 0;
                        break;
                    case MouseButtons.Right:
                        pbox.Refresh();
                        Cursor.Current = Cursors.Default;
                        cropRectangle = null;
                        break;
                }
            }
        }
        private void pbox_MouseMove(object sender, MouseEventArgs e) {
            if (pbox.Image != null) {
                if (e.Button == MouseButtons.Left) {
                    nudW.Value = e.X - nudX.Value;
                    nudH.Value = e.Y - nudY.Value;
                    if (IsValidCropping())
                        DrawCrop();
                }
            }
        }
        private void pbox_MouseUp(object sender, MouseEventArgs e) {
            if (pbox.Image != null) {
                Cursor.Current = Cursors.Default;
            }
        }
        private void btnCropShow_Click(object sender, EventArgs e) {
            if (pbox.Image == null)
                return;
            if (!rbNormal.Checked) {
                MessageBox.Show("Cropping only allowed in normal view mode");
                return;
            }
            DrawCrop();
        }
        int x, y, w, h;
        Rectangle? cropRectangle = null;

        private void btnCrop_Click(object sender, EventArgs e) {
            if (gim == null)
                return;
            if (!rbNormal.Checked) {
                MessageBox.Show("Cropping only allowed in normal view mode");
                return;
            }
            if (cropRectangle != null) {
                gim.DisplayImage =UF.CropImage(pbox.Image, (Rectangle)cropRectangle).ToByteArray();
                LoadImage();
            }
        }

        private void btnSetWidth_Click(object sender, EventArgs e) {
            if (pbox.Image == null)
                return;
            if (chkRatio.Checked)
            {                     
                udHeight.Value = (decimal)UFWin.RatioTimesWidthForHeight(pbox.Image) * udWidth.Value;
            }

            gim.DisplayImage =UF.ReSizeImageTo(pbox.Image , (int)udWidth.Value, (int)udHeight.Value, chkRatio.Checked).ToByteArray();
            LoadImage();
        }

        private void btnSetHeight_Click(object sender, EventArgs e) {
            if (pbox.Image == null)
                return;
            if (chkRatio.Checked)
            {                       
                udWidth.Value = (decimal)UFWin.RatioTimesHeightForWidth(pbox.Image) * udHeight.Value;
            }
            gim.DisplayImage =UF.ReSizeImageTo(pbox.Image, (int)udWidth.Value, (int)udHeight.Value, chkRatio.Checked).ToByteArray();
            LoadImage();
        }

        private void udWidth_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                btnSetWidth_Click(null, null);
            }
        }
        private void udHeight_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                btnSetHeight_Click(null, null);
            }
        }
        private void btnReload_Click(object sender, EventArgs e) {
            if (gim == null)
                return;
            LoadImage();
        }

        private void btnApplyResize_Click(object sender, EventArgs e) {
            if (gim == null)
                return;
            gim.DisplayImage =UF.ReSizeImageTo(pbox.Image , (int)udWidth.Value, (int)udHeight.Value, chkRatio.Checked).ToByteArray();
            LoadImage();
        }


        private void DrawCrop() {
            if (gim == null)
                return;
            if (!rbNormal.Checked) {
                MessageBox.Show("Cropping only allowed in normal view mode");
                return;
            }
            pbox.Refresh();

            x = (int)nudX.Value;
            y = (int)nudY.Value;
            w = (int)nudW.Value;
            h = (int)nudH.Value;

            //Up the way action so adjust
            if (h < 0) {
                h = Math.Abs(h);
                y = y - h;
            }
            //backward action so adjust
            if (w < 0) {
                w = Math.Abs(w);
                x = x - w;
            }

            if (!IsValidCropping()) {
                //MessageBox.Show("Invalid Cropping");
                return;
            }

            cropRectangle = new Rectangle(x, y, w, h);
            pbox.CreateGraphics().DrawRectangle(Pens.Black, (Rectangle)cropRectangle);
        }

        private void nud_ValueChanged(object sender, EventArgs e) {
            if (pbox.Image != null) {
                DrawCrop();
            }
        }

        private bool IsValidCropping() {
            return !(x > pbox.Image.Width || y > pbox.Image.Height ||
                x + w > pbox.Image.Width || y + h > pbox.Image.Height);
        }

    }
}
