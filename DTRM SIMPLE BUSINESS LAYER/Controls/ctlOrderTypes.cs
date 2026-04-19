using System;
using System.Windows.Forms;

using Microsoft.Extensions.DependencyInjection;

using POSLayer.Library;
using POSWinFormLayer;

namespace DTRMNS {
    /// <summary>
    /// Summary description for frmOrderTypes.
    /// </summary>
    public class frmOrderTypes : UserControl {
        private Button btnInHouse;
        private Button btnTakeAway;
        private Button btnDelivery;
        private Button btnClose;

        private GenericFunctionCallAsync CloseFunction;
        private OrderTypes RequestedType;
        private Button btnDirectSale;


        private GenericFunctionCallAsync CloseOrderItemEntityInteractionEvent;
        private GenericFunctionCallAsync DetachPanelEvent;
        private PassControl AttachPanelEvent;
        private GenericFunctionCallAsync EnsureCompulsoryExtrasEvent;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmOrderTypes() {
            InitializeComponent();
        }
        public frmOrderTypes(GenericFunctionCallAsync CloseOrderItemEntityInteraction,
            GenericFunctionCallAsync DetachPanel, PassControl AttachPanel,
            GenericFunctionCallAsync EnsureCompulsoryExtras, GenericFunctionCallAsync CloseFunction) {
            InitializeComponent();
            CloseOrderItemEntityInteractionEvent = CloseOrderItemEntityInteraction;
            DetachPanelEvent = DetachPanel;
            AttachPanelEvent = AttachPanel;
            EnsureCompulsoryExtrasEvent = EnsureCompulsoryExtras;
            this.CloseFunction = CloseFunction;
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderTypes));
            this.btnDirectSale = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.btnInHouse = new System.Windows.Forms.Button();
            this.btnTakeAway = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDirectSale
            // 
            this.btnDirectSale.AutoEllipsis = true;
            this.btnDirectSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDirectSale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDirectSale.BackgroundImage")));
            this.btnDirectSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDirectSale.FlatAppearance.BorderSize = 0;
            this.btnDirectSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirectSale.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirectSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDirectSale.Location = new System.Drawing.Point(17, 37);
            this.btnDirectSale.Name = "btnDirectSale";
            this.btnDirectSale.Size = new System.Drawing.Size(125, 79);
            this.btnDirectSale.TabIndex = 5;
            this.btnDirectSale.Text = "TAKE AWAY (A)  (No Address)";
            this.btnDirectSale.UseVisualStyleBackColor = false;
            this.btnDirectSale.Click += new System.EventHandler(this.btnDirectSale_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoEllipsis = true;
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.BackgroundImage = global::DTRMNS.Properties.Resources.CLOSEBig;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(612, 36);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 80);
            this.btnClose.TabIndex = 4;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelivery
            // 
            this.btnDelivery.AutoEllipsis = true;
            this.btnDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDelivery.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelivery.BackgroundImage")));
            this.btnDelivery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelivery.FlatAppearance.BorderSize = 0;
            this.btnDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelivery.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelivery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelivery.Location = new System.Drawing.Point(226, 155);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(125, 79);
            this.btnDelivery.TabIndex = 2;
            this.btnDelivery.Text = "DELIVERY";
            this.btnDelivery.UseVisualStyleBackColor = false;
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // btnInHouse
            // 
            this.btnInHouse.AutoEllipsis = true;
            this.btnInHouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnInHouse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInHouse.BackgroundImage")));
            this.btnInHouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInHouse.FlatAppearance.BorderSize = 0;
            this.btnInHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHouse.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInHouse.Location = new System.Drawing.Point(17, 155);
            this.btnInHouse.Name = "btnInHouse";
            this.btnInHouse.Size = new System.Drawing.Size(125, 79);
            this.btnInHouse.TabIndex = 0;
            this.btnInHouse.Text = "IN HOUSE  (TABLES)";
            this.btnInHouse.UseVisualStyleBackColor = false;
            this.btnInHouse.Click += new System.EventHandler(this.btnInHouse_Click);
            // 
            // btnTakeAway
            // 
            this.btnTakeAway.AutoEllipsis = true;
            this.btnTakeAway.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTakeAway.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTakeAway.BackgroundImage")));
            this.btnTakeAway.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTakeAway.FlatAppearance.BorderSize = 0;
            this.btnTakeAway.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeAway.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeAway.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTakeAway.Location = new System.Drawing.Point(226, 37);
            this.btnTakeAway.Name = "btnTakeAway";
            this.btnTakeAway.Size = new System.Drawing.Size(125, 79);
            this.btnTakeAway.TabIndex = 1;
            this.btnTakeAway.Text = "TAKE-AWAY (B)  (With Address)";
            this.btnTakeAway.UseVisualStyleBackColor = false;
            this.btnTakeAway.Click += new System.EventHandler(this.btnTakeAway_Click);
            // 
            // frmOrderTypes
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnDirectSale);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelivery);
            this.Controls.Add(this.btnInHouse);
            this.Controls.Add(this.btnTakeAway);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "frmOrderTypes";
            this.Size = new System.Drawing.Size(717, 536);
            this.ResumeLayout(false);

        }
        #endregion

        private void btnInHouse_Click(object sender, System.EventArgs e) {
            if ( DTRMSimpleBusiness.Instance.AttachedOrder.OrderType != OrderTypes.Sitin) {
                ctlTables ct = ActivatorUtilities.CreateInstance< ctlTables>(ServiceHelper.Services, new GenericFunctionCallAsync(DetachPanelEvent), null, true, new GenericFunctionCallAsync(CloseOrderItemEntityInteractionEvent));
                AttachPanelEvent(ct);
            } else
                CloseFunction();
        }
        private void btnDirectSale_Click(object sender, EventArgs e) {
            //if ( DTRMSimpleBusiness.Instance.AttachedOrder.OrderType != OrderTypes.Sale) {
            //    RequestedType = OrderTypes.Sale;
            //    try {
            //        if ( DTRMSimpleBusiness.Instance.AttachedOrder.TableIID.Length > 0)
            //             DTRMSimpleBusiness.Instance.FreeTheTable( DTRMSimpleBusiness.Instance.AttachedOrder.TableIID);
            //    } catch { }
            //    HandlePriceChange();
            //     DTRMSimpleBusiness.Instance.OnDisplayOrder();
            //} else
            //    CloseFunction();
        }
        private void btnTakeAway_Click(object sender, System.EventArgs e) {
            //if ( DTRMSimpleBusiness.Instance.AttachedOrder.OrderType != OrderTypes.TakeAway) {
            //    RequestedType = OrderTypes.TakeAway;
            //    try {
            //        if ( DTRMSimpleBusiness.Instance.AttachedOrder.TableIID.Length > 0)
            //             DTRMSimpleBusiness.Instance.FreeTheTable( DTRMSimpleBusiness.Instance.AttachedOrder.TableIID);
            //    } catch { }
            //    HandlePriceChange();
            //     DTRMSimpleBusiness.Instance.OnDisplayOrder();
            //} else
            //    CloseFunction();
        }

        private void btnDelivery_Click(object sender, System.EventArgs e) {
            //if ( DTRMSimpleBusiness.Instance.AttachedOrder.OrderType != OrderTypes.Delivery) {
            //    RequestedType = OrderTypes.Delivery;
            //    try {
            //        if ( DTRMSimpleBusiness.Instance.AttachedOrder.TableIID.Length > 0)
            //             DTRMSimpleBusiness.Instance.FreeTheTable( DTRMSimpleBusiness.Instance.AttachedOrder.TableIID);
            //    } catch { }
            //    HandlePriceChange();
            //    EnsureCompulsoryExtrasEvent();
            //     DTRMSimpleBusiness.Instance.OnDisplayOrder();
            //} else
            //    CloseFunction();
        }

        private void btnClose_Click(object sender, System.EventArgs e) {
            CloseFunction();
        }

        private void HandlePriceChange() {
            //Close tabpages to ensure the last open top order item having completed effect
            CloseOrderItemEntityInteractionEvent();
            //Do recalculation
             DTRMSimpleBusiness.Instance.RePriceOrderForOrderType( DTRMSimpleBusiness.Instance.AttachedOrder, this.RequestedType);
             DTRMSimpleBusiness.Instance.ReTaxOrderForOrderType( DTRMSimpleBusiness.Instance.AttachedOrder, this.RequestedType);
             DTRMSimpleBusiness.Instance.AttachedOrder.OrderType = this.RequestedType;
            CloseFunction();
        }



    }
}
