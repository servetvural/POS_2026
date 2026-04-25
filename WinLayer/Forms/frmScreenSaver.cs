using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using WinLayer.Library;
using POSLayer.Library;

namespace WinLayer {
    public partial class frmScreenSaver : Form {

        PosConfig config;

        private List<ScreenSaverImage> nonDrawableList;
        private List<ScreenSaverImage> drawingList;
        private int totalimagecount;
       
        private int singleDisplayCounter;

        private Font singleImageFont;
        private Font singleImageSmallFont;

        private string[] files;
        private int swidth = Screen.PrimaryScreen.WorkingArea.Width;
        private int sheight = Screen.PrimaryScreen.WorkingArea.Height;

        private Brush textColorBrush;

        public frmScreenSaver()
        {
            InitializeComponent();
            config = ServiceHelper.GetService<PosConfig>();
        }

        private void frmScreenSaver_Load(object sender, EventArgs e)
        {
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            if (DTRMSimpleBusiness.Instance == null)
            {
                tmrMain.Enabled = false;
            } 

            if (DTRMSimpleBusiness.Instance != null)
            {
                switch (config.Screen_Saver_Color)
                {
                    case POSLayer.Library.ScreenSaverColourTypes.BlackBackGroundWhiteBrush:
                        pBox.BackColor = Color.Black;
                        textColorBrush = Brushes.White;
                        break;
                    case POSLayer.Library.ScreenSaverColourTypes.WhiteBackGroundBlackBrush:
                        pBox.BackColor = Color.White;
                        textColorBrush = Brushes.Black;
                        break;
                    default:
                        pBox.BackColor = Color.Black;
                        textColorBrush = Brushes.White;
                        break;
                }
                singleImageFont = new Font("Comic Sans MS", (float)config.Screen_Saver_Large_Font_Size, FontStyle.Bold);
                singleImageSmallFont = new Font("Comic Sans MS", (float)config.Screen_Saver_Small_Font_Size, FontStyle.Bold);

                LoadImages();
                drawingList = new List<ScreenSaverImage>();
            }
        }

        private void LoadImages()
        {
            try {
                //Directory of the images
                files = Directory.GetFiles(config.Screen_Saver_Image_Folder);
                //Imagespacer Value (20) default
                int spacer = totalimagecount * config.Screen_Saver_Image_Spacer;
                //speed difference value (10) default
                int speeddifference = config.Screen_Saver_Speed_Difference;
                //timer interval (50) default
                tmrMain.Interval = config.Screen_Saver_Timer_Interval;

                if (!config.Screen_Saver_Show_Pos_Logo)
                    pBox.Image = null;

                nonDrawableList = new List<ScreenSaverImage>();
                Random rnd = new Random();
                totalimagecount = files.Length;


                if (config.Screen_Saver_Type == POSLayer.Library.ScreenSaverTypes.Flow) {

                    int[] regions = new int[] { swidth / 3, (sheight / 3) * 2 };
                    int regioncounter = 0;

                    bool blnTek = false;

                    for (int i = 0; i < totalimagecount; i++) {
                        //Terminate loop if too many images will be load
                        if (nonDrawableList.Count >= config.Screen_Saver_Maximum_Image_Count)
                            break;


                        //Do not load big images in KB
                        FileInfo finfo = new FileInfo(files[i]);
                        if (finfo.Length / 1024 > config.Screen_Saver_Maximum_Image_Size)
                            continue;

                        //Do not load images bigger than the screen size
                        Image img = null;
                        try {
                            img = Image.FromFile(files[i]);
                            if (img.Size.Width > Screen.PrimaryScreen.WorkingArea.Width || img.Size.Height > Screen.PrimaryScreen.WorkingArea.Height)
                                continue;
                        } catch {
                            //This might not be an image file so continue
                            continue;
                        }
                        spacer += rnd.Next(config.Screen_Saver_Image_Spacer);
                        ScreenSaverImage ssi = new ScreenSaverImage(img, swidth, sheight,
                            Screen.PrimaryScreen.WorkingArea.Width, false, -1 * rnd.Next(2, speeddifference),
                            rnd.Next(-1 * config.Screen_Saver_Left_Step, config.Screen_Saver_Right_Step));

                        ssi.Name = Path.GetFileNameWithoutExtension(finfo.Name);

                        switch (regioncounter) {
                            case 0:
                                ssi.location.X = rnd.Next(0, regions[0]);
                                break;
                            case 1:
                                ssi.location.X = rnd.Next(regions[0], regions[1]);
                                break;
                            case 2:
                                ssi.location.X = rnd.Next(regions[1], swidth);
                                break;
                            default:
                                ssi.location.X = rnd.Next(swidth);
                                break;
                        }
                        regioncounter = regioncounter > 2 ? 0 : ++regioncounter;
                        blnTek = blnTek ? false : true;

                        if (blnTek)
                            ssi.Zoom();

                        nonDrawableList.Add(ssi);
                    }
                }
                tmrMain.Enabled = true;
            } catch { }
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            try {
                pBox.Refresh();

            fillthelist:
                if (config.Screen_Saver_Type == ScreenSaverTypes.Flow) {
                    if (drawingList.Count < config.Screen_Saver_Maximum_Drawable_Image_Count) {
                        if (nonDrawableList.Count > 0) {
                            drawingList.Add(nonDrawableList[0]);
                            nonDrawableList.RemoveAt(0);
                            if (drawingList.Count < config.Screen_Saver_Maximum_Drawable_Image_Count)
                                goto fillthelist;
                        }
                    }

                    for (int i = drawingList.Count - 1; i >= 0; i--) {
                        if (drawingList.ElementAt(i).location.Y + drawingList.ElementAt(i).image.Height <= 0) {
                            nonDrawableList.Add(drawingList[i]);
                            drawingList.RemoveAt(i);
                        }
                    }
                }
            } catch { }
        }

        private void pBox_Paint(object sender, PaintEventArgs e)
        {
            try {

                switch (config.Screen_Saver_Type) {
                    case POSLayer.Library.ScreenSaverTypes.None:

                        break;
                    case POSLayer.Library.ScreenSaverTypes.SingleDisplay:
                        if (!Directory.Exists(config.Screen_Saver_Image_Folder)) {
                            this.Close();
                            return;
                        }
                           


                        if (files.Length > 0) {
                            if (singleDisplayCounter >= files.Length)
                                singleDisplayCounter = 0;

                            using (Image image = Image.FromFile(files[singleDisplayCounter])) {
                                Image img = image;
                                if (img.Width > swidth / 3 || img.Height > sheight)
                                    img = ScreenSaverImage.Resize(Image.FromFile(files[singleDisplayCounter]),
                                      swidth / 3 - 50, sheight - 100);



                                string[] imagewords = Path.GetFileNameWithoutExtension(files[singleDisplayCounter]).Trim().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                                int linespace = config.Screen_Saver_Text_Line_Space;

                                int countline = 0;
                                Font font = singleImageFont;
                                if (imagewords.Length > 3)
                                    font = singleImageSmallFont;

                                int y_text = (sheight - ((imagewords.Length * font.Height) + (linespace * (imagewords.Length - 1)))) / 2;
                                y_text = config.Screen_Saver_Text_Top_Indent >= 0 ? config.Screen_Saver_Text_Top_Indent : y_text;

                                int x_text = (Screen.PrimaryScreen.WorkingArea.Width / 3) + 50;
                                x_text = config.Screen_Saver_Text_Left_Indent >= 0 ? config.Screen_Saver_Text_Left_Indent : x_text;

                                int x_image = 0;
                                switch (config.Screen_Saver_Image_Alignment) {
                                    case POSLayer.Library.AlignmentTypes.Center:
                                        x_image = ((x_text - img.Width) / 2) + config.Screen_Saver_Image_Indent;
                                        break;
                                    case POSLayer.Library.AlignmentTypes.Left:
                                        x_image = config.Screen_Saver_Image_Indent;
                                        break;
                                    case POSLayer.Library.AlignmentTypes.Right:
                                        x_image = (x_text - img.Width) - config.Screen_Saver_Image_Indent;
                                        break;
                                }


                                //int x_image =  ? config.Screen_Saver_Image_Left_Indent :  (true? (x_text - img.Width);
                                int y_image = config.Screen_Saver_Image_Top_Indent >= 0 ? config.Screen_Saver_Image_Top_Indent : ((sheight) - img.Height) / 2;

                                if (config.Screen_Saver_Debug)
                                    e.Graphics.DrawRectangle(Pens.Red, new Rectangle(x_image - 1, y_image - 1, img.Width + 3, img.Height + 3));

                                ////////////////////////////
                                e.Graphics.DrawImage(img, new Rectangle(x_image, y_image, img.Width, img.Height));
                                ////////////////////////////
                                //if (config.Screen_Saver_Debug)
                                //    e.Graphics.DrawString(img.Width.ToString() + ", " + img.Height.ToString() + ", " +
                                //        x_image.ToString() + ", " + y_image.ToString(), singleImageFont, textColorBrush, x_image, y_image - 50);




                                for (int i = 0; i < imagewords.Length; i++) {
                                    if (imagewords[i].Trim().Length == 0)
                                        continue;

                                    e.Graphics.DrawString(imagewords[i].Replace('_', ' '), font, textColorBrush,
                                        x_text, y_text);
                                    countline++;
                                    y_text += font.Height + linespace;
                                }
                            }
                            singleDisplayCounter++;
                        }
                        break;
                    case POSLayer.Library.ScreenSaverTypes.Flow:
                        if (drawingList != null && drawingList.Count > 0) {
                            int x = 0;
                            int y = 0;
                            int zoomf = 0;
                            int maxzoom = 0;
                            int originalwidth = 0;
                            int originalheight = 0;
                            Font font = new Font("Arial", 10);

                            for (int i = 0; i < drawingList.Count; i++) {
                                if (drawingList[i].location.Y <= pBox.Height) {
                                    e.Graphics.DrawImage(drawingList[i].image, drawingList.ElementAt(i).location);
                                    if (config.Screen_Saver_Debug) {
                                        x = drawingList[i].location.X;
                                        y = drawingList[i].location.Y - 10;
                                        zoomf = drawingList[i].ZoomFactor;
                                        maxzoom = drawingList[i].MaxZoomFactor;
                                        originalwidth = drawingList[i].originalImageSize.Width;
                                        originalheight = drawingList[i].originalImageSize.Height;
                                        e.Graphics.DrawString("(" + originalwidth.ToString() + ", " + originalheight.ToString() + ", =>" + zoomf.ToString() +
                                            ", " + maxzoom.ToString() + ")", font, textColorBrush, x, y);
                                    }
                                }
                                drawingList.ElementAt(i).Step();
                            }
                        }
                        break;
                }
            } catch { }


        }

        private void pBox_MouseDown(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void pBox_MouseMove(object sender, MouseEventArgs e)
        {
            // Close();
        }
    }
}
