using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Microsoft.Extensions.DependencyInjection;

using POSLayer.Library;
using POSLayer.Models;

namespace WinLayer {
    /// <summary>
    /// Summary description for UPEntity.
    /// </summary>
    public partial class UPCategory : TableLayoutPanel {
        private PosConfig config;

        public string IID;
        public Category category;
        public UPCategoryItem SelectedButton;
        public int ButtonHeight;
        public int ButtonWidth;        
        public List<UPCategoryItem> UIEButtons;
        public string OrderGroupIID = "";
            
        public FlowLayoutPanel UIEButtonsPanel;
        public GenericFunctionCallReturnBool DoneEventHandler;

        #region "CONSTRUCTORS"
        public UPCategory() {

        }
       
        public UPCategory(Category category) {
            InitializeComponent();
            config = ServiceHelper.GetService<PosConfig>();
            this.category = category;
            IID = category.IID;
            UIEButtonsPanel = new FlowLayoutPanel();

            //Add Main Buttons Panel
            UIEButtonsPanel.AutoScroll = config.Entity_Buttons_Scrollable;
            Controls.Add(UIEButtonsPanel, 0, 1);

            UIEButtons = new List<UPCategoryItem>();
            
            ButtonHeight = category.Height;
            ButtonWidth = category.Width;
            this.BackColor = UF.ThemeBackColour; 
            
            LoadUIA();
        }

        public void SetAsSpecialEntity() {
            Visible = false;
            RowStyles[0].Height = 0;
        }

        private void LoadUIA() {  
           

            if (category.Items.Count > 0) {
                //for (int i = 1; i <= category.Items.Count; i++) {
                foreach (var item in category.Items) {
                    UPCategoryItem eb = ActivatorUtilities.CreateInstance< UPCategoryItem>(ServiceHelper.Services, this, item);
                    if (eb.categoryItem.Compulsary || eb.categoryItem.PadFlag == PadFlags.PadOnly)
                        eb.Visible = false;
                    if (DRNumeric.IsBitSet(eb.categoryItem.AvailableFor, (int)AvailabilityTypes.NoSale))
                        eb.Visible = false;
                    UIEButtonsPanel.Controls.Add(eb);
                    UIEButtons.Add(eb);
                }
            }
            if (UIEButtonsPanel.Dock != DockStyle.Fill)
                UIEButtonsPanel.Dock = DockStyle.Fill;
            UIEButtonsPanel.BringToFront();

                ShowPanels();

            this.Dock = DockStyle.Fill;
        }
        #endregion

        public void EventProcessor() {
            Reset();
        }
        public void Reset() {
            this.OrderGroupIID = "";
        }      
        public void ShowPanels() {            
            this.UIEButtonsPanel.Visible = true;
        }      

        private void InitializeComponent() {
            this.SuspendLayout();
            // 
            // UPEntity
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ColumnCount = 1;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.RowCount = 1;
            this.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ResumeLayout(false);

        }

    }
}
