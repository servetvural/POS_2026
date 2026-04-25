using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using PosLibrary;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;
using POSLayer.Models;
using WinLayer;
using POSLayer.Library;
using POSLayer.Repository.IRepository;
using Microsoft.Extensions.DependencyInjection;

namespace BSLayer {
    public partial class frmImageList : Form {

        IRepository<GenericImage> repoImage;

        private frmSimpleProgress frmProg;


        public Image SelectedImage;
        public string SelectedImageReferenceIID;
        private bool blnSelectEnabled;
        public frmImageList() {
            InitializeComponent();
        }
        public frmImageList(IRepository<GenericImage> _repoImage,  bool blnSelectEnabled) {
            InitializeComponent();
            repoImage = _repoImage;
            this.blnSelectEnabled = blnSelectEnabled;
            btnSelect.Visible = blnSelectEnabled;
        }

        private void frmImageList_Load(object sender, EventArgs e) {
            LoadImages();
        }

        private async void LoadImages() {
            lvwImages.Items.Clear();
           
            imgList.Images.Clear();
            List<GenericImage> allImages = await repoImage.GetAllAsync();

            foreach (var gim in allImages)
            {
                lvwImages.Items.Add(CreateListViewItem(gim));
            }
            //for (int i = 0; i < dt.Rows.Count; i++) {
            //    GenericImage gim = new GenericImage(dt.Rows[i],imgList.ImageSize.Width, imgList.ImageSize.Height,true);
                
            //    lvwImages.Items.Add(CreateListViewItem(gim));
            //}
        }

        private ListViewItem CreateListViewItem(GenericImage gim) {
            imgList.Images.RemoveByKey(gim.ReferenceIID);
            Image img = UFWin.ByteArrayToImage(gim.DisplayImage);
            imgList.Images.Add(gim.ReferenceIID,img);
            ListViewItem lvi = new ListViewItem(gim.ImageFileName);
            lvi.ImageKey = gim.ReferenceIID;
            lvi.SubItems.Add(gim.ImageFileName);
            lvi.SubItems.Add(gim.ExtraText);
            lvi.SubItems.Add(img.PhysicalDimension.ToString());
            lvi.SubItems.Add(img.PhysicalDimension.Width.ToString());
            lvi.SubItems.Add(img.PhysicalDimension.Height.ToString());
            lvi.SubItems.Add(gim.ImageSizeinKB.ToString());
            return lvi;
        }


        private async void btnSelect_Click(object sender, EventArgs e) {
            if (blnSelectEnabled) {
                if (lvwImages.SelectedItems.Count > 0) {
                    SelectedImageReferenceIID = lvwImages.SelectedItems[0].ImageKey;
                    SelectedImage =UFWin.ByteArrayToImage((await repoImage.GetByField("ReferenceIID", SelectedImageReferenceIID)).DisplayImage);
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e) {

        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (blnSelectEnabled)
                btnSelect_Click(null, null);
            else
                btnZoom_Click(null, null);
        }

        private async void btnDelete_Click(object sender, EventArgs e) {
            if (lvwImages.SelectedItems.Count > 0) {
                await repoImage.Delete(lvwImages.SelectedItems[0].ImageKey);
                LoadImages();
            }
        }

        private async void btnExport_Click(object sender, EventArgs e) {
            try {
                if (lvwImages.SelectedItems.Count > 0) {
                    FolderBrowserDialog dlg = new FolderBrowserDialog();
                    dlg.ShowNewFolderButton = true;
                    if (dlg.ShowDialog() == DialogResult.OK) {
                        DirectoryInfo dinfo = new DirectoryInfo(dlg.SelectedPath);
                        for (int i = 0; i < lvwImages.SelectedItems.Count; i++) {
                            GenericImage gim = await repoImage.GetByField("ReferenceIID", lvwImages.SelectedItems[i].ImageKey);


                            string filename = dinfo.FullName + "\\" + gim.ImageFileName;
                            POSLayer.Library.UF.SaveByteArrayToFile(filename, gim.DisplayImage);
                           // gim.DisplayImage.Save(filename);
                        }
                    }
                }
            } catch {
                MessageBox.Show("Failed to save");
            }
        }


        private async void btnZoom_Click(object sender, EventArgs e) {
            if (lvwImages.SelectedItems.Count > 0) {
                SelectedImage =UFWin.ByteArrayToImage((await repoImage.GetByField("ReferenceIID", lvwImages.SelectedItems[0].ImageKey)).DisplayImage);
                frmImageDialog frm = new frmImageDialog(SelectedImage);
                frm.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Files | *.*|GIF Images |*.gif|JPG  Images|*.jpg|JPEG Images |*.jpeg|PNG Images|*.png";
            dlg.Multiselect = false;
            dlg.Title = "Generic Image";

            if (dlg.ShowDialog() == DialogResult.OK) {
                FileInfo finfo = new FileInfo(dlg.FileName);
                string fileshortname = finfo.Name;

                Image img = Image.FromFile(dlg.FileName);
                //pBox.BackgroundImage = img;

                GenericImage gim = new GenericImage()
                {
                    ReferenceIID = "",
                    DisplayImage =img.ToByteArray(),
                    ExtraText = "",
                    ImageFileName = fileshortname
                };

                frmGenericImageEditor frm = ActivatorUtilities.CreateInstance<frmGenericImageEditor>(ServiceHelper.Services, gim);
                if (frm.ShowDialog() == DialogResult.OK) {
                    LoadImages();
                }
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e) {
            if (lvwImages.SelectedItems.Count > 0) {
                ListViewItem lvi = lvwImages.SelectedItems[0];
                
                GenericImage gim = await repoImage.GetByField("ReferenceIID",lvi.ImageKey);

                frmGenericImageEditor frm = ActivatorUtilities.CreateInstance<frmGenericImageEditor>(ServiceHelper.Services, gim);
                if (frm.ShowDialog() == DialogResult.OK) {
                    int index = lvi.Index;
                    lvwImages.Items.RemoveAt(index);
                    lvwImages.Items.Insert(index, CreateListViewItem(gim));
                }
            }
        }




        private void cmbView_SelectionChangeCommitted(object sender, EventArgs e) {
    
        }

        private void lvwImages_MouseDown(object sender, MouseEventArgs e) {
            if (lvwImages.SelectedItems.Count > 0) {
                if (e.Button == MouseButtons.Right)
                    btnZoom_Click(null, null);
            }
        }

        private void lvwImages_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (lvwImages.SelectedItems.Count > 0) {
                btnEdit_Click(null, null);
            }
        }

        private async void btnExportAsXML_Click(object sender, EventArgs e) {

            List<GenericImage> imageList = new();

            try {
                imageList = await repoImage.GetAllAsync();
            } catch {
                MessageBox.Show("There are errors during list creation.");
                return;
            }


            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "DTRM files (*.xml)|";
            sfd.FileName = "DTRMSimple Image Repository";
            if (sfd.ShowDialog() == DialogResult.OK) {
                DirectoryInfo dinfo = null;

                if (sfd.FileName != null && sfd.FileName != "") {
                    FileInfo finfo = new FileInfo(sfd.FileName);
                    dinfo = finfo.Directory;

                    if (DRFile.XmlSerialize(sfd.FileName + ".xml", imageList, typeof(List<GenericImage>), false))
                        MessageBox.Show("Image List Saved");
                    else
                        MessageBox.Show("Image List failed to be saved");
                }
            } else
                MessageBox.Show("Image List Aborted.");
        }

        private string importxmlfilename;
        private void btnImportFromXML_Click(object sender, EventArgs e) {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "XML Files|*.xml";
            dlg.Multiselect = false;
            dlg.Title = "Image Library Import XML";

            if (dlg.ShowDialog() == DialogResult.OK) {
                importxmlfilename = dlg.FileName;
                bgLoader.RunWorkerAsync();
            }
        }


        private void bgLoader_DoWork(object sender, DoWorkEventArgs e) {
            LoadFunction();
        }
        private void bgLoader_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            if (frmProg == null) {
                frmProg = new frmSimpleProgress(ref bgLoader);
                frmProg.Show();

            }

            try {
                if (frmProg != null) {
                    frmProg.ChangeMaximum(e.ProgressPercentage);
                    frmProg.SetValue(e.ProgressPercentage);
                }
            } catch (Exception ex) {
                MessageBox.Show("Error " + ex.Message);
            }
        }
        private void bgLoader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            try {
                frmProg.Close();
                frmProg = null;
                LoadImages();
            } catch (Exception ex) {
                MessageBox.Show("Error " + ex.Message);
            }
        }
        private async Task LoadFunction() {
            int percent = 0;

            try {
                List<GenericImage> imageList = (List<GenericImage>)DRFile.XmlDeSerialize(importxmlfilename, typeof(List<GenericImage>), false);

                if (imageList != null) {
                    foreach (GenericImage gim in imageList) {
                       await repoImage.Save(gim);
                        bgLoader.ReportProgress(percent++);
                    }
                }
                
            } catch {
                MessageBox.Show("Image Library cannot be imported");
                return;
            }

        }

        private void btnReload_Click(object sender, EventArgs e) {
            LoadImages();
        }

        private void btnLargeIcon_Click(object sender, EventArgs e) {
            imgList.ImageSize = new Size(120, 120);
            lvwImages.View = View.LargeIcon;
            LoadImages();
        }

        private void btnSmallIcon_Click(object sender, EventArgs e) {
            imgList.ImageSize = new Size(60, 60);
            lvwImages.View = View.SmallIcon;
            LoadImages();
        }

        private void btnDetails_Click(object sender, EventArgs e) {
            imgList.ImageSize = new Size(50, 50);
            lvwImages.View = View.Details;
            lvwImages.Columns[0].Width = 56;
            LoadImages();
        }

        private void btnList_Click(object sender, EventArgs e) {
            imgList.ImageSize = new Size(60, 60);
            lvwImages.View = View.List;
            LoadImages();
        }

        private void btnTile_Click(object sender, EventArgs e) {
            imgList.ImageSize = new Size(60, 60);
            lvwImages.View = View.Tile;
            LoadImages();
        }

        private void btnXLView_Click(object sender, EventArgs e) {
            imgList.ImageSize = new Size(200, 200);
            lvwImages.View = View.LargeIcon;
            LoadImages();
        }

        private void btnXXLView_Click(object sender, EventArgs e) {
            imgList.ImageSize = new Size(256, 256);
            lvwImages.View = View.LargeIcon;
            LoadImages();
        }

        private async void txtSetWidth_KeyDown(object sender, KeyEventArgs e) {
            for (int i= 0; i < lvwImages.SelectedItems.Count; i++) {
                GenericImage gim = await repoImage.GetByField("ReferenceIID",lvwImages.SelectedItems[i].ImageKey);
                int width = int.Parse(txtSetWidth.Text);
                Image img = UFWin.ByteArrayToImage(gim.DisplayImage);
                double ratio = UFWin.RatioTimesWidthForHeight(img);
                gim.DisplayImage =UFWin.ReSizeImageTo(img, width, (int)(width*ratio), true).ToByteArray();
                await repoImage.Save(gim);
            }
        }

        private async void txtSetHeight_KeyDown(object sender, KeyEventArgs e) {
            for (int i = 0; i < lvwImages.SelectedItems.Count; i++) {
                GenericImage gim = await repoImage.GetByField("ReferenceIID", lvwImages.SelectedItems[i].ImageKey);
                int height = int.Parse(txtSetHeight.Text);
                Image img = UFWin.ByteArrayToImage(gim.DisplayImage);
                double ratio = UFWin.RatioTimesHeightForWidth(img);
                gim.DisplayImage =UFWin.ReSizeImageTo(img, (int)(height * ratio), height, true).ToByteArray();
                await repoImage.Save(gim);
            }
        }

        private async void btnExportAsJson_Click(object sender, EventArgs e)
        {
            List<GenericImage> itemList = await repoImage.GetAllAsync();
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "JSON Files (*.json)|";
                sfd.FileName = "Image List.json";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (sfd.FileName != null && sfd.FileName != "")
                    {

                        var jsonString = JsonConvert.SerializeObject(itemList, Newtonsoft.Json.Formatting.Indented);
                        if (UF.SaveTextFile(sfd.FileName, jsonString))
                            MessageBox.Show("Saved Image List");
                        else
                            MessageBox.Show("Failed to Save Image List");
                    }
                }
            }
        }

        private async void btnImportFromJson_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog sfd = new OpenFileDialog())
            {
                sfd.Filter = "JSON Files (*.json)|";
                // sfd.FileName = "Stock Item List";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (sfd.FileName != null && sfd.FileName != "")
                    {

                        string content = UF.GetTextFile(sfd.FileName);
                        if (!string.IsNullOrEmpty(content))
                        {
                            List<GenericImage> itemList = JsonConvert.DeserializeObject<List<GenericImage>>(content);
                            foreach (GenericImage item in itemList)
                            {
                               await repoImage.Save(item);
                            }
                            MessageBox.Show("Saved Image List");
                            LoadImages();
                        } else
                        {
                            MessageBox.Show("Failed to Get Image List");
                        }

                    }
                }
            }
        }
    }
}
