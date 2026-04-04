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
using System.Globalization;
using POSWinFormLayer.Library;

namespace DTRMSimpleBackOffice {
    public partial class frmImageEditor : Form {

        public frmImageEditor()
        {
            InitializeComponent();
            lblProcess.Text = "";    
        }

        private void btnLargeIcon_Click(object sender, EventArgs e)
        {
            lvwImages.View = View.LargeIcon;              
        }

        private void btnSmallIcon_Click(object sender, EventArgs e)
        {
            lvwImages.View = View.SmallIcon;
        }

        private void btnListView_Click(object sender, EventArgs e)
        {
            lvwImages.View = View.List;
           
        }

        private void btnTileView_Click(object sender, EventArgs e)
        {
            lvwImages.View = View.Tile;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadCombinedDirectory(dlg.SelectedPath);
            }
        }

        public void LoadCombinedDirectory(string path)
        {
            try
            {
                LoadDirectory(path);
                wbLocal.Navigate(path);
                lblDirectory.Text = path;
            } catch { }
        }

        public void LoadDirectory(string path)
        {
            //Take a note of the path to load
            lvwImages.Tag = path;
            //Clear list view items if any
            lvwImages.Items.Clear();

            //lvwImages.Columns.Add("Item Column", -2, HorizontalAlignment.Left);
            //lvwImages.Columns.Add("Column 2", -2, HorizontalAlignment.Left);
            //lvwImages.Columns.Add("Column 3", -2, HorizontalAlignment.Left);
            //lvwImages.Columns.Add("Column 4", -2, HorizontalAlignment.Center);

            

            System.IO.DirectoryInfo dinfo = new System.IO.DirectoryInfo(path);

            ListViewItem item;
            lvwImages.BeginUpdate();

            //Add Directories
            //foreach (DirectoryInfo d in dinfo.GetDirectories())
            //    lvwImages.Items.Add(new ListViewItem(d.Name, "directory"));

            // For each file in the path, create a ListViewItem and set the icon to the icon extracted from the file.
            foreach (System.IO.FileInfo file in dinfo.GetFiles())
            {
                // Set a default icon for the file.
                Icon iconForFile = SystemIcons.WinLogo;

                item = new ListViewItem(file.Name, 1);
               // item.SubItems.AddRange(new string[] { file.Name, file.CreationTime.ToLongDateString(), file.GetType().Name, file.Length.ToString() });

                // Check to see if the image collection contains an image for this extension, using the extension as a key.
                if (!ilLocal.Images.ContainsKey(file.Extension))
                {
                    // If not, add the image to the image list.
                    iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(file.FullName);
                    
                    ilLocal.Images.Add(file.Extension, iconForFile);
                }
                item.ImageKey = file.Extension;
                lvwImages.Items.Add(item);
            }
            lvwImages.EndUpdate();

           // btnUp.Enabled = (dinfo.Parent != null);
           // txtLocalPath.Text = path;
        }

        private void frmImageEditor_Load(object sender, EventArgs e)
        {

        }

        private void btnRemoveWords_Click(object sender, EventArgs e)
        {
            frmStringInput frm = new frmStringInput("");
            if (frm.ShowDialog() == DialogResult.OK)
            {
                int duplicates = 0;
                foreach (ListViewItem lvi in lvwImages.SelectedItems)
                {
                    duplicates += RemoveStringFromFileName(lblDirectory.Text + "\\" + lvi.Text,frm.text);
                }
                LoadCombinedDirectory(lblDirectory.Text);
                if (duplicates > 0)
                {
                    MessageBox.Show(duplicates + " duplicate files");
                }
            }
        }

        private int RemoveStringFromFileName(string filename, string str)
        {
            FileInfo finfo = new FileInfo(filename);
            DirectoryInfo dinfo = finfo.Directory;
            string name = Path.GetFileNameWithoutExtension(filename);
            string extension = Path.GetExtension(filename);
            string newfilename = dinfo.FullName + "\\" + name.Replace(str, "") + extension;
            int duplicates = 0;
            if (!File.Exists(newfilename))
            {
                File.Move(filename, dinfo.FullName + "\\" + name.Replace(str, "") + extension);
            } else
            {
                duplicates++;
            }
            return duplicates;
            

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadCombinedDirectory(lblDirectory.Text);
        }

        private void btnFitinDimensions_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvwImages.SelectedItems)
            {
                //string name = Path.GetFileNameWithoutExtension(lblDirectory.Text + "\\" + lvi.Text);
                //string extension = Path.GetExtension(lblDirectory.Text + "\\" + lvi.Text);

                FileInfo finfo = new FileInfo(lblDirectory.Text + "\\" + lvi.Text);
                lblProcess.Text = finfo.Name;
                Image image = null;
                Image newImage = null;
                using (image = Image.FromFile(finfo.FullName))
                {
                    newImage = ScreenSaverImage.Resize(image, Screen.PrimaryScreen.WorkingArea.Width / 3 - 50,
                    Screen.PrimaryScreen.WorkingArea.Height - 100);
                }
                //image = null;
                newImage.Save(finfo.FullName);

            }
            lblProcess.Text = "";
            LoadCombinedDirectory(lblDirectory.Text);

            
        }

        private void btnSentenceCase_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvwImages.SelectedItems)
            {
                FileInfo finfo = new FileInfo(lblDirectory.Text + "\\" + lvi.Text);
                DirectoryInfo dinfo = finfo.Directory;
                string name = Path.GetFileNameWithoutExtension(finfo.FullName);
                string extension = Path.GetExtension(finfo.FullName);

                string newfullfilename = dinfo.FullName + "\\" +
                    CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower()) + extension;

                File.Move(finfo.FullName, newfullfilename);
            }
            LoadCombinedDirectory(lblDirectory.Text);
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            frmReplace frm = new frmReplace("");
            if (frm.ShowDialog() == DialogResult.OK)
            {
                string textFind = frm.textFind;
                string textReplace = frm.textReplace;

                foreach (ListViewItem lvi in lvwImages.SelectedItems)
                {
                    FileInfo finfo = new FileInfo(lblDirectory.Text + "\\" + lvi.Text);
                    DirectoryInfo dinfo = finfo.Directory;
                    string name = Path.GetFileNameWithoutExtension(finfo.FullName);
                    string extension = Path.GetExtension(finfo.FullName);

                    string newfullfilename = dinfo.FullName + "\\" + name.Replace(textFind,textReplace) + extension;

                    File.Move(finfo.FullName, newfullfilename);
                }
                LoadCombinedDirectory(lblDirectory.Text);
            }
        }
    }
}
