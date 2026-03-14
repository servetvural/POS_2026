using System.Drawing;
using System.Data;
using System.IO;
using PosLibrary;

namespace DTRMNS {
    public class GenericImage {
        public string ReferenceIID { get; set; }

        private Image _DisplayImage;

        [System.Xml.Serialization.XmlIgnore]
        public Image DisplayImage {
            get {
                if (_DisplayImage == null && ImageAsByte != null) {
                    _DisplayImage = DRUF.byteArrayToImage(ImageAsByte);
                }
                   
                return _DisplayImage;
            }
            set { _DisplayImage = value; }
        }

        public string ExtraText { get; set; }

        public byte[] ImageAsByte { get; set; }

        public string ImageFileName { get; set; }

        public long ImageSizeinKB { get; set; }

        /// <summary>
        /// Multiply the width of the image with this ratio to get the height of the image
        /// </summary>
        public float RatioTimesWidthForHeight {
            get {
                return (float)((float)DisplayImage.Height / (float)DisplayImage.Width);
            }
        }

        public float RatioTimesHeightForWidth {
            get {
                return (float)((float)DisplayImage.Width / (float)DisplayImage.Height);
            }
        }

        public GenericImage() {

        }

        public GenericImage(string ReferenceID, FileInfo finfo) {
            this.ReferenceIID = ReferenceIID;
            this.DisplayImage = UF.LoadBitmapNolock(finfo.FullName);
            this.ExtraText = ExtraText;
            this.ImageFileName = finfo.Name;
        }

        public GenericImage(string ReferenceIID, Image DisplayImage, string ExtraText, string ImageFileName) {
            this.ReferenceIID = ReferenceIID;
            this.DisplayImage = DisplayImage;
            this.ExtraText = ExtraText;
            this.ImageFileName = ImageFileName;
        }
        public GenericImage(DataTable dt) {
            if (dt.Rows.Count > 0) {
                ReferenceIID = dt.Rows[0]["ReferenceIID"].ToString();
                if (dt.Rows[0]["DisplayImage"] != null)
                    ImageSizeinKB = ((byte[])dt.Rows[0]["DisplayImage"]).Length / 1024;
                DisplayImage = DRUF.byteArrayToImage((byte[])dt.Rows[0]["DisplayImage"]);
                ExtraText = dt.Rows[0]["ExtraText"].ToString();
                ImageFileName = dt.Rows[0]["ImageFileName"].ToString();
            }
        }

        public GenericImage(DataRow dr) {
            if (dr != null) {
                ReferenceIID = dr["ReferenceIID"].ToString();
                if ((byte[])dr["DisplayImage"] != null)
                    ImageSizeinKB = ((byte[])dr["DisplayImage"]).Length / 1024;

                DisplayImage = DRUF.byteArrayToImage((byte[])dr["DisplayImage"]);
                
                ExtraText = dr["ExtraText"].ToString();
                ImageFileName = dr["ImageFileName"].ToString();
            }
        }
        public GenericImage(DataRow dr, int width, int height, bool keepRatio = true) {
            if (dr != null) {
                ReferenceIID = dr["ReferenceIID"].ToString();
                if ((byte[])dr["DisplayImage"] != null)
                    ImageSizeinKB = ((byte[])dr["DisplayImage"]).Length / 1024;

                DisplayImage = UF.ReSizeImageTo(UF.ByteArrayToImage((byte[])dr["DisplayImage"]),width,height, keepRatio);

                ExtraText = dr["ExtraText"].ToString();
                ImageFileName = dr["ImageFileName"].ToString();
            }
        }
        public GenericImage(DataRow dr, bool blnImageAsByte)
        {
            if (dr != null)
            {
                ReferenceIID = dr["ReferenceIID"].ToString();
                if ((byte[])dr["DisplayImage"] != null)
                    ImageSizeinKB = ((byte[])dr["DisplayImage"]).Length / 1024;
                DisplayImage = DRUF.byteArrayToImage((byte[])dr["DisplayImage"]);
                ExtraText = dr["ExtraText"].ToString();
                ImageFileName = dr["ImageFileName"].ToString();
                if (blnImageAsByte)
                    ImageAsByte = (byte[])dr["DisplayImage"];
            }
        }
        public void SetImage(string FileName) {
            try {
                DisplayImage = Image.FromFile(FileName);
                
                FileInfo finfo = new FileInfo(FileName);
                ImageFileName = finfo.Name;
                ImageSizeinKB = finfo.Length / 1024;
            } catch {

            }
        }
        public void SetImage(byte[] imageFile) {
            try {
                DisplayImage = DRUF.byteArrayToImage(imageFile);
            } catch { }
        }
    }
}
