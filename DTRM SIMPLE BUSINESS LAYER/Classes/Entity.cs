using System.Collections.Generic;
using System.Data;
using System.Drawing;
using PosLibrary.DBSpace;
using PosLibrary;

namespace DTRMNS {
    [System.Serializable]
    public class Entity {
        private string _IID = ShortGuid.NewGuid().ToString();
        public string IID { get { return _IID; } set { _IID = value; } }
        public string EntityName { get; set; }
        public int DisplayOrder { get; set; }
        public int BackColour { get; set; }
        public int ForeColour { get; set; }
        public int ButtonHeight { get; set; }
        public int ButtonWidth { get; set; }

        public string ParentMenuIID;
        public List<EntityButton> Buttons;

        public EntityTypes entityType { get; set; }
        public string DistributionIID { get; set; }
        public string DistributionName { get; set; }
        public string FFamily { get; set; }
        public float FSize { get; set; }
        public string FStyle { get; set; }

        public string Font { get { return FFamily + " " + FSize + " " + FStyle; } }

        public Entity() {
            EntityName = "";
            DisplayOrder = 0;
            BackColour = SystemColors.Control.ToArgb();
            ForeColour = SystemColors.ControlText.ToArgb();
            ButtonHeight = 64;
            ButtonWidth = 64;
            ParentMenuIID = "";
            Buttons = new List<EntityButton>();

            entityType = EntityTypes.NormalEntity;
            DistributionIID = "";
            DistributionName = "";
            FFamily = "Arial";
            FSize = 10f;
            FStyle = "Bold";
        }
        public Entity(string ParentMenuIID) {
            EntityName = "";
            DisplayOrder = 0;
            BackColour = SystemColors.Control.ToArgb();
            ForeColour = SystemColors.ControlText.ToArgb();
            ButtonHeight = 50;
            ButtonWidth = 90;
            this.ParentMenuIID = ParentMenuIID;
            Buttons = new List<EntityButton>();

            entityType = EntityTypes.NormalEntity;
            DistributionIID = "";
            DistributionName = "";
            FFamily = "Arial";
            FSize = 10f;
            FStyle = "Bold";
        }
        public Entity(DataTable dt) {
            if (dt.Rows.Count > 0) {
                IID = dt.Rows[0]["IID"].ToString();
                EntityName = dt.Rows[0]["EntityName"].ToString();
                DisplayOrder = int.Parse(dt.Rows[0]["DisplayOrder"].ToString());
                BackColour = int.Parse(dt.Rows[0]["BackColour"].ToString());
                ForeColour = int.Parse(dt.Rows[0]["ForeColour"].ToString());
                ButtonHeight = int.Parse(dt.Rows[0]["ButtonHeight"].ToString());
                ButtonWidth = int.Parse(dt.Rows[0]["ButtonWidth"].ToString());
                ParentMenuIID = dt.Rows[0]["ParentMenuIID"].ToString();
                entityType = (EntityTypes)int.Parse(dt.Rows[0]["EntityType"].ToString());
                Buttons = new List<EntityButton>();

                DistributionIID = dt.Rows[0]["DistributionIID"].ToString();
                DistributionName = dt.Rows[0]["DistributionName"].ToString();
                FFamily = DB.GetCellValue(dt.Rows[0], "FFamily", "Arial");
                try {
                    FSize = float.Parse(dt.Rows[0]["FSize"].ToString(), System.Globalization.NumberStyles.Any);
                }
                catch {
                    FSize = 10.0f;
                }
                FStyle = DB.GetCellValue(dt.Rows[0], "FStyle", "Bold");
            }
        }
        public Entity(DataRow dr) {
            if (dr != null) {
                IID = dr["IID"].ToString();
                EntityName = dr["EntityName"].ToString();
                DisplayOrder = int.Parse(dr["DisplayOrder"].ToString());
                BackColour = int.Parse(dr["BackColour"].ToString());
                ForeColour = int.Parse(dr["ForeColour"].ToString());
                ButtonHeight = int.Parse(dr["ButtonHeight"].ToString());
                ButtonWidth = int.Parse(dr["ButtonWidth"].ToString());
                ParentMenuIID = dr["ParentMenuIID"].ToString();
                entityType = (EntityTypes)int.Parse(dr["EntityType"].ToString());
                Buttons = new List<EntityButton>();

                DistributionIID = dr["DistributionIID"].ToString();
                DistributionName = dr["DistributionName"].ToString();
                FFamily = DB.GetCellValue(dr, "FFamily", "Arial");
                try {
                    FSize = float.Parse(dr["FSize"].ToString(), System.Globalization.NumberStyles.Any);
                }
                catch {
                    FSize = 10.0f;
                }
                FStyle = DB.GetCellValue(dr, "FStyle", "Bold");
            }
        }
        public Entity Clone() {
            Entity en = new Entity();
            en.IID = IID;
            en.EntityName = EntityName;
            en.DisplayOrder = DisplayOrder;
            en.BackColour = BackColour;
            en.ForeColour = ForeColour;
            en.ButtonHeight = ButtonHeight;
            en.ButtonWidth = ButtonWidth;
            en.ParentMenuIID = ParentMenuIID;
            en.entityType = entityType;
            en.DistributionIID = DistributionIID;
            en.DistributionName = DistributionName;
            en.FFamily = FFamily;
            en.FSize = FSize;
            en.FStyle = FStyle;

            //Clone Buttons
            for (int i = 0; i < Buttons.Count; i++)
                en.Buttons.Add(((EntityButton)Buttons[i]).Clone());

            return en;
        }
        public Entity Duplicate() {
            Entity en = new Entity();
            en.EntityName = EntityName;
            en.DisplayOrder = DisplayOrder;
            en.BackColour = BackColour;
            en.ForeColour = ForeColour;
            en.ButtonHeight = ButtonHeight;
            en.ButtonWidth = ButtonWidth;
            en.ParentMenuIID = ParentMenuIID;
            en.entityType = entityType;
            en.DistributionIID = DistributionIID;
            en.DistributionName = DistributionName;
            en.FFamily = FFamily;
            en.FSize = FSize;
            en.FStyle = FStyle;
            //Clone Buttons
            for (int i = 0; i < Buttons.Count; i++)
                en.Buttons.Add(((EntityButton)Buttons[i]).Duplicate());

            return en;
        }
        public void Update(Entity en) {
            EntityName = en.EntityName;
            DisplayOrder = en.DisplayOrder;
            BackColour = en.BackColour;
            ForeColour = en.ForeColour;
            ButtonHeight = en.ButtonHeight;
            ButtonWidth = en.ButtonWidth;
            Buttons = en.Buttons;
            ParentMenuIID = en.ParentMenuIID;
            entityType = en.entityType;

            DistributionIID = en.DistributionIID;
            DistributionName = en.DistributionName;
            FFamily = en.FFamily;
            FSize = en.FSize;
            FStyle = en.FStyle;
        }



        public EntityButton GetEntityButton(string EntityButtonId) {
            int i = GetButtonIndex(EntityButtonId);
            if (i >= 0)
                return (EntityButton)Buttons[i];
            else
                return null;
        }

        public void AddButton(EntityButton button) {
            Buttons.Add(button);
        }

        public void DeleteButton(string ButtonId) {
            int i = GetButtonIndex(ButtonId);
            if (i >= 0)
                Buttons.RemoveAt(i);
        }
        public int GetButtonIndex(string ButtonId) {
            EntityButton button;
            for (int i = 0; i < Buttons.Count; i++) {
                button = (EntityButton)Buttons[i];
                if (button.IID == ButtonId)
                    return i;
            }
            return -1;
        }
        public void MoveButtonUp(string ButtonIID) {
            int CurrentIndex = this.GetButtonIndex(ButtonIID);
            int UpIndex = CurrentIndex - 1;
            EntityButton eb;
            if (CurrentIndex > 0) {
                eb = (EntityButton)this.Buttons[CurrentIndex];   //Get Copy of active button
                Buttons[CurrentIndex] = (EntityButton)Buttons[UpIndex];  //move button from above to 1 down
                Buttons[UpIndex] = eb; //put copy of the active button to upper location
            }
        }
        public void MoveButtonDown(string ButtonIID) {
            int CurrentIndex = this.GetButtonIndex(ButtonIID);
            int DownIndex = CurrentIndex + 1;
            EntityButton eb;
            if (DownIndex <= Buttons.Count) {
                eb = (EntityButton)this.Buttons[CurrentIndex];   //Get Copy of active button
                Buttons[CurrentIndex] = (EntityButton)Buttons[DownIndex];  //move button from below to 1 up
                Buttons[DownIndex] = eb; //put copy of the active button to lower location
            }
        }
        public void DuplicateButton(string ButtonIID) {
            int SourceButtonIndex = this.GetButtonIndex(ButtonIID);
            EntityButton eb = this.GetEntityButton(ButtonIID);
            EntityButton db = eb.Duplicate();
            this.Buttons.Insert(SourceButtonIndex + 1, db);
        }

        public float GetItemPrice(string ItemIID, OrderTypes orderType) {
            EntityButton eb;

            for (int i = 0; i < Buttons.Count; i++) {
                eb = (EntityButton)Buttons[i];
                if (eb.IID == ItemIID)
                    return eb.GetPrice(orderType);
            }

            //now check size bar 
            return 0f;
        }

        public float GetItemTaxRate(string ItemIID, OrderTypes orderType) {
            //if SizeIID != 0 then this item created by one of the SizeBarButton's otherwise by one of the entity buttons
            //Either SizeIID (SizeBarButton IID) or ItemIID (EntityButtonIID) should be checked

            EntityButton eb = Buttons.Find(delegate(EntityButton btn) { return btn.IID == ItemIID; });
            if (eb != null)
                return eb.GetTaxRate(orderType);

            //now check size bar 
            return 0f;

        }
    }

}
