using System;
using System.Data;
using PosLibrary.DBSpace;
using System.Drawing;
using PosLibrary;

namespace DTRMNS {

    public class EntityView
    {
        public string IID { get; set; }
        public string EntityName { get; set; }
        public int DisplayOrder { get; set; }
        public int PanelColor { get; set; }
        public int ButtonHeight { get; set; }
        public int ButtonWidth { get; set; }
        public string SizeBarIID { get; set; }
        public string DivisionBarIID { get; set; }
        public string ParentMenuIID { get; set; }
        public EntityTypes EntityType { get; set; }
        public float TaxPercent { get; set; }
        public string DistributionIID { get; set; }
        public string DistributionName { get; set; }
        public string FFamily { get; set; }
        public float FSize { get; set; }
        public string FStyle { get; set; }

        public EntityView()
        {
           IID = ShortGuid.NewGuid().ToString();
           EntityName = "Not Known";
           PanelColor = Color.Black.ToArgb();
           ButtonHeight = 64;
           ButtonWidth = 64;
           SizeBarIID = "";
           DivisionBarIID = "";
            ParentMenuIID = "";
           EntityType = (int)EntityTypes.NormalEntity;
           DistributionIID = "";
           DistributionName = "";
           FFamily = "Arial";
           FSize = 10f;
           FStyle = "Bold";
        }
        public EntityView(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
               IID = dt.Rows[0]["IID"].ToString();
               EntityName = dt.Rows[0]["EntityName"].ToString();
               DisplayOrder = int.Parse(dt.Rows[0]["DisplayOrder"].ToString());
               PanelColor = int.Parse(dt.Rows[0]["PanelColor"].ToString());
               ButtonHeight = int.Parse(dt.Rows[0]["ButtonHeight"].ToString());
               ButtonWidth = int.Parse(dt.Rows[0]["ButtonWidth"].ToString());
               SizeBarIID = dt.Rows[0]["SizeBarIID"].ToString();
               DivisionBarIID = dt.Rows[0]["DivisionBarIID"].ToString();
                ParentMenuIID = dt.Rows[0]["ParentMenuIID"].ToString();
               EntityType = (EntityTypes)int.Parse(dt.Rows[0]["EntityType"].ToString());
               TaxPercent = float.Parse(dt.Rows[0]["TaxPercent"].ToString());
                DistributionIID = dt.Rows[0]["DistributionIID"].ToString();
                DistributionName = dt.Rows[0]["DistributionName"].ToString();
                FFamily = DB.GetCellValue(dt.Rows[0], "FFamily", "Arial");
                try
                {
                    FSize = float.Parse(dt.Rows[0]["FSize"].ToString(), System.Globalization.NumberStyles.Any);
                }
                catch
                {
                    FSize = 10.0f;
                }
                FStyle = DB.GetCellValue(dt.Rows[0], "FStyle", "Bold");
            }
        }
        
    }
}
