using System;
using System.Windows.Forms;

using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace DTRMNS {
    public partial class TrmDrawerCount : Form {
        private DTRMSimpleBusiness bslayer;

        private SessionData session;
        private bool OpenAsTool;

        public TrmDrawerCount(DTRMSimpleBusiness bslayer) {
            InitializeComponent();
            this.bslayer = bslayer;
            this.session = bslayer.GetSessionDataDynamic(bslayer.shop.CurrentSessionIID).Result; 
        }
        public TrmDrawerCount(DTRMSimpleBusiness bslayer, bool OpenAsTool) {
            InitializeComponent();
            this.OpenAsTool = OpenAsTool;
            btnSave.Visible = false;
        }
        private void FrmDrawerCount_Load(object sender, EventArgs e) {
            if (!OpenAsTool)
                LoadSessionData();
        }
        private void LoadSessionData() {
            ctl001.Value = session.peny1;
            ctl002.Value = session.peny2;
            ctl005.Value = session.peny5;
            ctl010.Value = session.peny10;
            ctl020.Value = session.peny20;
            ctl050.Value = session.peny50;
            ctl1.Value = session.pound1;
            ctl2.Value = session.pound2;
            ctl5.Value = session.pound5;
            ctl10.Value = session.pound10;
            ctl20.Value = session.pound20;
            ctl50.Value = session.pound50;
            ctl100.Value = session.pound100;
            ctl200.Value = session.pound200;
            ctl500.Value = session.pound500;
            ctl1000.Value = session.pound1000;            
           
        }

        private void BtnBozuk_Click(object sender, EventArgs e) {
            TrmGetValue frm = new TrmGetValue(NumberModes.FloatMode);
            if (frm.ShowDialog() == DialogResult.OK) {
                Button btn = (Button)sender;
                btn.Tag = frm.ReturnValue;
                btn.Text = frm.ReturnValue.ToString("f");
                CalculateTotals();
            }
        }

        private void CalculateTotals() {
            //calculate cash totals
            double total = 0f;
            foreach (object obj in this.Controls) {
                if (obj.GetType() == typeof(ctlBozukPara)) {
                    ctlBozukPara ctl = (ctlBozukPara)obj;
                    total += ctl.Value;
                }
            }
            btnCashTotal.Tag = total;
            btnCashTotal.Text = total.ToString("f");
       

            total += double.Parse(btnDebitCardTotal.Tag.ToString());
            total += double.Parse(btnCreditCardTotal.Tag.ToString());
            total += double.Parse(btnChequeTotal.Tag.ToString());
            total += double.Parse(btnOthersTotal.Tag.ToString());

            btnTotal.Tag = total;
            btnTotal.Text = total.ToString("f");

            total += double.Parse(btnDebitCardTotal.Tag.ToString());
        }

        private void BtnClose_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        

        private void CtlBozukPara_ValueChanged(object sender, EventArgs e) {
            CalculateTotals();
        }

        private void BtnSave_Click(object sender, EventArgs e) {
            if (!OpenAsTool) {
                session.peny1 = ctl001.Value;
                session.peny2 = ctl002.Value;
                session.peny5 = ctl005.Value;
                session.peny10 = ctl010.Value;
                session.peny20 = ctl020.Value;
                session.peny50 = ctl050.Value;
                session.pound1 = ctl1.Value;
                session.pound2 = ctl2.Value;
                session.pound5 = ctl5.Value;
                session.pound10 = ctl10.Value;
                session.pound20 = ctl20.Value;
                session.pound50 = ctl50.Value;
                session.pound100 = ctl100.Value;
                session.pound200 = ctl200.Value;
                session.pound500 = ctl500.Value;
                session.pound1000 = ctl1000.Value;

                session.CashTotal = float.Parse(btnCashTotal.Tag.ToString());
                session.CardTotal = float.Parse(btnDebitCardTotal.Tag.ToString());
                session.OnlineTotal = float.Parse(btnOthersTotal.Tag.ToString());

                bslayer.SaveDrawerSessionData(session);
            }
            this.DialogResult = DialogResult.OK;
            Close();

        }



       

       
    }
}