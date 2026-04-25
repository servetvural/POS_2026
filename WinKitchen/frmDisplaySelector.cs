
using BSLayer;

using POSLayer.Library;

namespace WinKitchen
{
    public partial class frmDisplaySelector : Form
    {
        PosConfig config;
        public frmDisplaySelector(PosConfig configAsService)
        {
            InitializeComponent();
            config = configAsService;
        }
        private void frmDisplaySelector_Load(object sender, EventArgs e)
        {

        }

        private void frmDisplaySelector_Shown(object sender, EventArgs e)
        {

            switch (config.Kitchen_Monitor_Auto_Display_Type)
            {
                case KitchenDisplayTypes.None:
                    break;
                case KitchenDisplayTypes.Single_Display:
                    btnSingle_Click(null, null);
                    break;
                case KitchenDisplayTypes.Double_Display:
                case KitchenDisplayTypes.Triple_Display:
                    btnDouble_Click(null, null);
                    break;
                default:
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSingle_Click(object sender, EventArgs e)
        {
            ServiceHelper.GetService<frmKitchenSingleDisplay>().Show();
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            ServiceHelper.GetService<frmKitchenDoubleDisplay>().Show();
        }

        private async void btnSettings_Click(object sender, EventArgs e)
        {
            if (await ServiceHelper.GetService<frmConfig>().ShowDialogAsync() == DialogResult.OK)
                Close();
        }

    }
}
