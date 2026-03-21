using System.Collections.Generic;
using System.Windows.Forms;

using POSLayer.Library;
using POSLayer.Models;

namespace DTRMNS {
    /// <summary>
    /// Summary description for UPEntity.
    /// </summary>
    public partial class UPEntity : TableLayoutPanel {
        public string IID;
        public Entity entity;
        public UPEntityButton SelectedButton;
        public int ButtonHeight;
        public int ButtonWidth;        
        public List<UPEntityButton> UIEButtons;
        public string OrderGroupIID = "";
        private DTRMSimpleBusiness bslayer;
        public UPEntityButton SubUIButton;        
        public FlowLayoutPanel UIEButtonsPanel;
        public GenericFunctionCallReturnBool DoneEventHandler;

        #region "CONSTRUCTORS"
        public UPEntity() {

        }

        /// <summary>
        /// Serialized Constructor
        /// </summary>
        /// <param name="bs"></param>
        /// <param name="entity"></param>
        /// <param name="OrderToAttach"></param>
        public UPEntity(DTRMSimpleBusiness bs, Entity entity, UPEntityButton SubUIButton) {
            InitializeComponent();
            bslayer = bs;
            this.entity = entity;
            IID = entity.IID;
            UIEButtonsPanel = new FlowLayoutPanel();

            //Add Main Buttons Panel
            UIEButtonsPanel.AutoScroll = bs.config.Entity_Buttons_Scrollable;
            Controls.Add(UIEButtonsPanel, 0, 1);

            UIEButtons = new List<UPEntityButton>();
            
            ButtonHeight = entity.ButtonHeight;
            ButtonWidth = entity.ButtonWidth;
            this.BackColor = UF.ThemeBackColour; 
            
            LoadUIA();
        }

        public void SetAsSpecialEntity() {
            Visible = false;
            RowStyles[0].Height = 0;
        }

        private void LoadUIA() {            
            if (entity.Buttons.Count > 0) {
                for (int i = 1; i <= entity.Buttons.Count; i++) {
                    UPEntityButton eb = new UPEntityButton(bslayer, this, (EntityButton)entity.Buttons[i - 1]);
                    if (eb.entitybutton.Compulsary == 1 || eb.entitybutton.PadFlag == PadFlags.PadOnly)
                        eb.Visible = false;
                    if (PosLibrary.DRNumeric.IsBitSet(eb.entitybutton.AvailableFor, (int)AvailabilityTypes.NoSale))
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
