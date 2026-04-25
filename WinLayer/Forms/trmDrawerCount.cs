using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace WinLayer
{
    public partial class TrmDrawerCount : Form
    {
        IRepository<Shop> repoShop;
        IRepository<Session> repoSession;

        private Session session;
        private bool OpenAsTool;

        public TrmDrawerCount(IRepository<Shop> _repoShop, IRepository<Session> _repoSession)
        {
            InitializeComponent();
            repoShop = _repoShop;
            repoSession = _repoSession;
        }
        public TrmDrawerCount(  bool OpenAsTool)
        {
            InitializeComponent();
            this.OpenAsTool = OpenAsTool;
            btnSave.Visible = false;
        }
        private async void FrmDrawerCount_Load(object sender, EventArgs e)
        {
            session = await repoSession.Get(BSLayer.Instance.shop.CurrentSessionIID);
            if (!OpenAsTool)
                LoadSessionData();
        }
        private void LoadSessionData()
        {
            ctl001.Value = session.Peny1;
            ctl002.Value = session.Peny2;
            ctl005.Value = session.Peny5;
            ctl010.Value = session.Peny10;
            ctl020.Value = session.Peny20;
            ctl050.Value = session.Peny50;
            ctl1.Value = session.Pound1;
            ctl2.Value = session.Pound2;
            ctl5.Value = session.Pound5;
            ctl10.Value = session.Pound10;
            ctl20.Value = session.Pound20;
            ctl50.Value = session.Pound50;
            ctl100.Value = session.Pound100;
            ctl200.Value = session.Pound200;
            ctl500.Value = session.Pound500;
            ctl1000.Value = session.Pound1000;

        }

        private void BtnBozuk_Click(object sender, EventArgs e)
        {
            TrmGetValue frm = new TrmGetValue(NumberModes.FloatMode);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Button btn = (Button)sender;
                btn.Tag = frm.ReturnValue;
                btn.Text = frm.ReturnValue.ToString("f");
                CalculateTotals();
            }
        }

        private void CalculateTotals()
        {
            //calculate cash totals
            double total = 0f;
            foreach (object obj in this.Controls)
            {
                if (obj.GetType() == typeof(ctlBozukPara))
                {
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }



        private async Task CtlBozukPara_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            if (!OpenAsTool)
            {
                session.Peny1 = ctl001.Value;
                session.Peny2 = ctl002.Value;
                session.Peny5 = ctl005.Value;
                session.Peny10 = ctl010.Value;
                session.Peny20 = ctl020.Value;
                session.Peny50 = ctl050.Value;
                session.Pound1 = ctl1.Value;
                session.Pound2 = ctl2.Value;
                session.Pound5 = ctl5.Value;
                session.Pound10 = ctl10.Value;
                session.Pound20 = ctl20.Value;
                session.Pound50 = ctl50.Value;
                session.Pound100 = ctl100.Value;
                session.Pound200 = ctl200.Value;
                session.Pound500 = ctl500.Value;
                session.Pound1000 = ctl1000.Value;

                session.CashTotal = float.Parse(btnCashTotal.Tag.ToString());
                session.CardTotal = float.Parse(btnDebitCardTotal.Tag.ToString());
                session.OnlineTotal = float.Parse(btnOthersTotal.Tag.ToString());

                await repoSession.Save(session);
            }
            this.DialogResult = DialogResult.OK;
            Close();

        }






    }
}