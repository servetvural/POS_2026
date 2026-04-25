using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using BSLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;
using WinLayer;

namespace WinOffice {
    public partial class frmCategoryUpsert : Form
    {
        PosConfig config;
        IRepository<Category> repoCategory;
        IRepository<Distribution> repoDistribution;
        IRepository<GenericImage> repoImage;

        public Category category;
        private GenericImage gim;
        bool blnEdit;
        private BindingSource _distributionSource = new BindingSource();

        public frmCategoryUpsert(PosConfig configAsService, IRepository<Category> _repoCategory,
            IRepository<GenericImage> _repoImage, IRepository<Distribution> _repoDistribution, Category _category)
        {
            InitializeComponent();
            config = configAsService;
            repoCategory = _repoCategory;
            repoDistribution = _repoDistribution;
            repoImage = _repoImage;

            category = _category;
            blnEdit = category.IID != null;
        }
        private async void frmCategoryEditor_Load(object sender, EventArgs e)
        {
            cmbButtonDisplayStyle.DataSource = Enum.GetValues(typeof(ButtonDisplayStyles));
            cmbImageAlign.DataSource = Enum.GetValues(typeof(ContentAlignmentX));
            cmbTextAlign.DataSource = Enum.GetValues(typeof(ContentAlignmentX));
            cmbTextImageRelation.DataSource = Enum.GetValues(typeof(TextImageRelationX));

            await LoadDistributions();
            await LoadCategory();
        }

        private async Task LoadDistributions()
        {

            if (category.MenuIID.IsNullOrEmpty())
                return;
            _distributionSource.DataSource = (await repoDistribution.GetListByField("MenuIID", category.MenuIID)).ToBindingList();
            cmbDistribution.DataSource = _distributionSource;  // (await repoDistribution.GetListByField("MenuIID",category.MenuIID)).ToBindingList<Distribution>();
        }

        private async Task LoadCategory()
        {
            if (category != null)
            {
                txtCategoryName.Text = category.CategoryName;
                btnEntityPanelBackColor.BackColor = Color.FromArgb(category.BgColour);
                try
                {
                    btnEntityForeColour.BackColor = Color.FromArgb(category.FgColour);
                } catch { }
                incWidth.Value = category.Width;
                incHeight.Value = category.Height;


                cmbEntityType.SelectedIndex = (int)category.CategoryType;
                if (category.DistributionIID != null)
                {
                    try
                    {
                        cmbDistribution.SelectedValue = category.DistributionIID;
                    } catch (Exception ex)
                    {
                        string str = ex.Message;
                    }
                }

                btnFont.Text = category.FFamily + "," + category.FSize.ToString() + "," + category.FStyle;
                incDisplayOrder.Text = category.DOrder.ToString();

                cmbButtonDisplayStyle.SelectedItem = category.ButtonDisplayStyle;
                cmbImageAlign.SelectedItem = category.ImageAlign;
                cmbTextAlign.SelectedItem = category.TextAlign;
                cmbTextImageRelation.SelectedItem = category.TextImageRelation;
            }
            await LoadGenericImage();
            DisplaySample();
        }

        private void btnEntityPanelColor_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            ColorDialog cdlg = new ColorDialog();
            cdlg.Color = btn.BackColor;
            cdlg.ShowDialog();
            category.BgColour = cdlg.Color.ToArgb();

            btn.BackColor = Color.FromArgb(category.BgColour);
            DisplaySample();
        }
        private void btnEntityForeColour_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            ColorDialog cdlg = new ColorDialog();
            cdlg.Color = btn.BackColor;
            cdlg.ShowDialog();
            category.FgColour = cdlg.Color.ToArgb();

            btn.BackColor = Color.FromArgb(category.FgColour);
            DisplaySample();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (category != null)
            {
                category.Width = incWidth.Value;
                category.Height = incHeight.Value;
                category.CategoryName = txtCategoryName.Text;
                category.BgColour = btnEntityPanelBackColor.BackColor.ToArgb();
                category.FgColour = btnEntityForeColour.BackColor.ToArgb();

                category.CategoryType = (CategoryTypes)cmbEntityType.SelectedIndex;

                if (cmbDistribution.SelectedIndex < 0)
                {
                    MessageBox.Show("Printable Category must be supplied!");
                    return;
                }
                category.DOrder = (int)incDisplayOrder.Value;

                category.DistributionIID = cmbDistribution.SelectedValue.ToString();

                category.ButtonDisplayStyle = (ButtonDisplayStyles)cmbButtonDisplayStyle.SelectedItem;
                category.ImageAlign = (ContentAlignmentX)cmbImageAlign.SelectedItem;
                category.TextAlign = (ContentAlignmentX)cmbTextAlign.SelectedItem;
                category.TextImageRelation = (TextImageRelationX)cmbTextImageRelation.SelectedItem;


                await repoCategory.Save(category);



                if ((category.ButtonDisplayStyle == ButtonDisplayStyles.Image || category.ButtonDisplayStyle == ButtonDisplayStyles.ImageAndText) && pBox.BackgroundImage != null)
                {
                    byte[] imgBytes = UFWin.ReSizeImageTo(pBox.BackgroundImage, config.CategoryItem_Image_Width, config.CategoryItem_Image_Height, true).ToByteArray();

                    GenericImage gim = new GenericImage()
                    {
                        ReferenceIID = category.IID,
                        DisplayImage = imgBytes,
                        ImageFileName = txtImageFile.Text,
                        ImageSizeinKB = imgBytes?.Length / 1024 ?? 0,
                    };
                    if (category.IID == null)
                        await repoImage.Save(gim);
                    else
                        await repoImage.SaveByField("ReferenceIID", category.IID, gim);
                }


                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = new Font(category.FFamily, (float)category.FSize, (FontStyle)Enum.Parse(typeof(FontStyle), category.FStyle));
            if (fd.ShowDialog() == DialogResult.OK)
            {
                category.FFamily = fd.Font.FontFamily.Name;
                category.FSize = fd.Font.Size;
                category.FStyle = fd.Font.Style.ToString();
                btnFont.Text = category.FFamily + "," + category.FSize.ToString() + "," + category.FStyle;
            }
            DisplaySample();
        }

        private void txtEntityName_Click(object sender, EventArgs e)
        {
            txtCategoryName.SelectAll();
        }



        private async void btnForceDistributionToAllButtons_Click(object sender, EventArgs e)
        {
            if (blnEdit)
            {
                try
                {
                    string distributionIID = cmbDistribution.SelectedValue.ToString();
                    foreach (var item in category.Items)
                    {
                        item.DistributionIID = distributionIID;
                    }
                } catch
                {
                    MessageBox.Show("Failed to Modify Category Items");
                }
            } else
            {
                MessageBox.Show("Category must be saved first.");
            }
        }

        private async void btnNewDistribution_Click(object sender, EventArgs e)
        {
            frmDistribution frm = ActivatorUtilities.CreateInstance<frmDistribution>(ServiceHelper.Services, new Distribution());
            if (frm.ShowDialog() == DialogResult.OK)
            {
                await LoadDistributions();
            }
        }
        private async void DisplaySample()
        {
            btnSample.Width = category.Width;
            btnSample.Height = category.Height;
            btnSample.Text = category.CategoryName;
            btnSample.Font = new Font(category.FFamily, (float)category.FSize, (FontStyle)Enum.Parse(typeof(FontStyle), category.FStyle));

            btnSample.BackColor = Color.FromArgb(category.BgColour);
            btnSample.ForeColor = Color.FromArgb(category.FgColour);

            btnSample.DisplayStyle = (ToolStripItemDisplayStyle)category.ButtonDisplayStyle;
            btnSample.TextAlign = (ContentAlignment)category.TextAlign;
            btnSample.ImageAlign = (ContentAlignment)category.ImageAlign;
            btnSample.TextImageRelation = (TextImageRelation)category.TextImageRelation;

            if (category.ButtonDisplayStyle == ButtonDisplayStyles.Image || category.ButtonDisplayStyle == ButtonDisplayStyles.ImageAndText)
            {
                if (gim != null && gim.DisplayImage != null)
                {
                    Image btnImage = UFWin.ByteArrayToImage(gim.DisplayImage);
                    btnSample.Image = UFWin.ReSizeImageTo(btnImage, btnSample.Height - 5, btnSample.Height - 5);
                    btnSample.ImageScaling = ToolStripItemImageScaling.None;
                    btnSample.Invalidate();
                }
            }
        }
        private void btnSample_Paint(object sender, PaintEventArgs e)
        {
            ToolStripButton btn = (ToolStripButton)sender;
            // Draw a solid red border around the button's content area
            ControlPaint.DrawBorder(e.Graphics, btn.ContentRectangle,
                Color.Black, ButtonBorderStyle.Solid);

        }

        private void incWidth_ValueChanged(object sender, EventArgs e)
        {
            category.Width = incWidth.Value;
            DisplaySample();
        }

        private void incHeight_ValueChanged(object sender, EventArgs e)
        {
            category.Height = incHeight.Value;
            DisplaySample();
        }

        private void cmbButtonDisplayStyle_SelectionChangeCommitted(object sender, EventArgs e)
        {
            category.ButtonDisplayStyle = (ButtonDisplayStyles)cmbButtonDisplayStyle.SelectedItem;
            DisplaySample();
        }

        private void cmbImageAlign_SelectionChangeCommitted(object sender, EventArgs e)
        {
            category.ImageAlign = (ContentAlignmentX)cmbImageAlign.SelectedItem;
            DisplaySample();
        }

        private void cmbTextAlign_SelectionChangeCommitted(object sender, EventArgs e)
        {
            category.TextAlign = (ContentAlignmentX)cmbTextAlign.SelectedItem;
            DisplaySample();
        }

        private void cmbTextImageRelation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            category.TextImageRelation = (TextImageRelationX)cmbTextImageRelation.SelectedItem;
            DisplaySample();
        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {
            category.CategoryName = txtCategoryName.Text;
        }


        private async Task LoadGenericImage()
        {
            try
            {
                gim = await repoImage.GetByField("ReferenceIID", category.IID);
                if (gim != null)
                {
                    if (gim.DisplayImage != null)
                        pBox.BackgroundImage = UFWin.ByteArrayToImage(gim.DisplayImage);
                    txtImageFile.Text = gim.ImageFileName;
                    lblImageSize.Text = gim.ImageSizeinKB + " KB";
                }
            } catch
            {
            }
        }

        private async void pBox_DoubleClick(object sender, EventArgs e)
        {
            frmGenericImageEditor frm = ActivatorUtilities.CreateInstance<frmGenericImageEditor>(ServiceHelper.Services, await repoImage.Get(category.IID));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                await LoadGenericImage();
            }
        }

        private void btnLoadPrepImageFromDirectory_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Files | *.*|GIF Images |*.gif|JPG  Images|*.jpg|JPEG Images |*.jpeg|PNG Images|*.png";
            dlg.Multiselect = false;
            dlg.Title = "Button Image / Prep Image";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FileInfo finfo = new FileInfo(dlg.FileName);
                txtImageFile.Text = finfo.Name;

                Image img = Image.FromFile(dlg.FileName);
                pBox.BackgroundImage = UFWin.ReSizeImageTo(img, 200, 200, true);

                byte[] imgArray = pBox.BackgroundImage.ToByteArray();
                gim = new GenericImage()
                {
                    ReferenceIID = category.IID,
                    DisplayImage = imgArray,
                    ImageFileName = finfo.Name,
                    ImageSizeinKB = imgArray?.Length / 1024 ?? 0,
                };

                DisplaySample();
            }
        }

        private async void btnDeletePrepImage_Click(object sender, EventArgs e)
        {
            await repoImage.Delete(category.IID);
            pBox.BackgroundImage = null;
        }
    }
}