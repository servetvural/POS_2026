using POSLayer.Library;

namespace WinLayer
{
    /// <summary>
    /// Summary description for frmPaymentMethods.
    /// </summary>
    public class ctlPayment : UserControl
    {
        PosConfig config;

        private Button btnClose;
        private Button btnCash;
        private Button btnOnline;
        private Button btnCard;

        private GenericFunctionCallAsync CloseFunction;
        private RemoteCompleteAttachedOrderAsync CompleteAttachedOrder;

        private int NumberOfCopy;
        private bool blnArchive;
        private bool blnPrintLocal;
        private bool blnEnforceDeliveryArchive;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public ctlPayment( )
        {
            InitializeComponent();
            config = ServiceHelper.GetService<PosConfig>();
        }
        public ctlPayment(GenericFunctionCallAsync CloseFunction, RemoteCompleteAttachedOrderAsync CompleteAttachedOrder,
           int NumberOfCopy, bool blnArchive, bool blnPrintLocal, bool blnEnforceDeliveryArchive)
        {
            InitializeComponent();
            this.CloseFunction = CloseFunction;
            this.CompleteAttachedOrder = CompleteAttachedOrder;
            this.NumberOfCopy = NumberOfCopy;
            this.blnArchive = blnArchive;
            this.blnPrintLocal = blnPrintLocal;
            this.blnEnforceDeliveryArchive = blnEnforceDeliveryArchive;
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlPayment));
            this.btnCard = new System.Windows.Forms.Button();
            this.btnOnline = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCard
            // 
            this.btnCard.AutoEllipsis = true;
            this.btnCard.BackColor = System.Drawing.Color.White;
            this.btnCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCard.BackgroundImage")));
            this.btnCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCard.FlatAppearance.BorderSize = 0;
            this.btnCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCard.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCard.Image = global::WinLayer.Properties.Resources.card64;
            this.btnCard.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCard.Location = new System.Drawing.Point(229, 153);
            this.btnCard.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(130, 85);
            this.btnCard.TabIndex = 121;
            this.btnCard.Text = "ANY CARD";
            this.btnCard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCard.UseVisualStyleBackColor = false;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // btnOnline
            // 
            this.btnOnline.AutoEllipsis = true;
            this.btnOnline.BackColor = System.Drawing.Color.White;
            this.btnOnline.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOnline.BackgroundImage")));
            this.btnOnline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOnline.FlatAppearance.BorderSize = 0;
            this.btnOnline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnline.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnOnline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOnline.Image = global::WinLayer.Properties.Resources.web;
            this.btnOnline.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOnline.Location = new System.Drawing.Point(421, 153);
            this.btnOnline.Name = "btnOnline";
            this.btnOnline.Size = new System.Drawing.Size(130, 85);
            this.btnOnline.TabIndex = 119;
            this.btnOnline.Text = "ONLINE";
            this.btnOnline.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOnline.UseVisualStyleBackColor = false;
            this.btnOnline.Click += new System.EventHandler(this.btnOnline_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoEllipsis = true;
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.BackgroundImage = global::WinLayer.Properties.Resources.CLOSEBig;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(534, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 80);
            this.btnClose.TabIndex = 116;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCash
            // 
            this.btnCash.AutoEllipsis = true;
            this.btnCash.BackColor = System.Drawing.Color.White;
            this.btnCash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCash.BackgroundImage")));
            this.btnCash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCash.FlatAppearance.BorderSize = 0;
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCash.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCash.Image = global::WinLayer.Properties.Resources.cash;
            this.btnCash.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCash.Location = new System.Drawing.Point(32, 153);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(130, 85);
            this.btnCash.TabIndex = 111;
            this.btnCash.Text = "CASH";
            this.btnCash.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // ctlPayment
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnCard);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.btnOnline);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.Name = "ctlPayment";
            this.Size = new System.Drawing.Size(638, 306);
            this.Load += new System.EventHandler(this.frmPaymentMethods_Load);
            this.ResumeLayout(false);

        }
        #endregion

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            CloseFunction();
        }

        private void btnOnline_Click(object sender, System.EventArgs e)
        {
            BSLayer.Instance.AttachedOrder.Payment = POSLayer.Library.PaymentMethods.Online;
            CompleteAttachedOrder(NumberOfCopy, blnArchive, blnPrintLocal, blnEnforceDeliveryArchive);
            CloseFunction();
        }

        private void btnCard_Click(object sender, System.EventArgs e)
        {
            frmConfirmCardPayment frm = new frmConfirmCardPayment();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //PrintFinalPayment(PaymentMethods.Card, true);
                 BSLayer.Instance.AttachedOrder.Payment = POSLayer.Library.PaymentMethods.Card;
                CompleteAttachedOrder(1, true, true, true);
                CloseFunction();
            }
        }

        private void btnCash_Click(object sender, System.EventArgs e)
        {
            BSLayer.Instance.AttachedOrder.Payment = POSLayer.Library.PaymentMethods.Cash;
            CompleteAttachedOrder(1, blnArchive, true, blnEnforceDeliveryArchive);
            CloseFunction();
        }

        private void frmPaymentMethods_Load(object sender, EventArgs e)
        {
            btnCash.Visible = (config.Payments_Can_Be_Made_By_Cash || config.Payments_Can_Be_Made_By_Cash_And_Print);
            btnCard.Visible = (config.Payments_Can_Be_Made_By_Card || config.Payments_Can_Be_Made_By_Card_And_Print);
            btnOnline.Visible = (config.Payments_Can_Be_Made_Online || config.Payments_Can_Be_Made_Online_And_Print);
        }


    }
}
