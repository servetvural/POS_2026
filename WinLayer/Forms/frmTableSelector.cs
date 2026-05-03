using System.Data;

using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace WinLayer{
    public partial class frmTableSelector : Form{
        IRepository<Salon> repoSalon;
        IRepository<Masa> repoTable;
        public TableButton SelectedTableButton;
        private Salon selectedSalon;
        public frmTableSelector() {
            InitializeComponent();

            repoSalon = ServiceHelper.GetService<IRepository<Salon>>();
            repoTable = ServiceHelper.GetService<IRepository<Masa>>();
        }



        private void frmTableSelector_Load(object sender, EventArgs e) {
            //Loads tables as well through autoselectionchange method
            LoadSalons();

        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void LoadSalons() {
            pnlGroups.Controls.Clear();

            List<Salon> salons = await repoSalon.GetAllAsync();
            foreach (var salon in salons)
            {                                              
                RadioButton btn = new RadioButton();
                btn.Appearance = Appearance.Button;
                btn.CheckedChanged += new EventHandler(SalonButton_CheckedChanged);
                btn.BackColor = Color.Green;
                btn.BackgroundImage = Properties.Resources.shadow;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.MinimumSize = new Size(90, 50);
                btn.AutoSize = true;
                btn.Font = new Font("Arial", 9, FontStyle.Bold);
                btn.ForeColor = Color.Black;
                btn.Text = salon.SalonName;
                btn.Tag = salon;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.BorderColor = Color.Red;

                pnlGroups.Controls.Add(btn);
                btn.Dock = DockStyle.Top;
            }
            bool chk = false;
            for (int i = 0; i < pnlGroups.Controls.Count; i++) {
                RadioButton rb = (RadioButton) pnlGroups.Controls[i];
                if (rb.Checked) {
                    chk = true;
                    break;
                }
            }
            if (!chk && pnlGroups.Controls.Count > 0)
                ((RadioButton) pnlGroups.Controls[0]).Checked = true;
        }

        private void SalonButton_CheckedChanged(object sender, EventArgs e) {
            RadioButton rb = (RadioButton) sender;
            if (rb.Checked) {
                rb.FlatAppearance.BorderSize = 1;
                selectedSalon = (Salon)rb.Tag;
                LoadTables();
            }
            else
                rb.FlatAppearance.BorderSize = 0;
        }

        private async void LoadTables() {
            if (selectedSalon == null)
                return;

            pnlTables.Controls.Clear();

            List<Masa> tablelist = await repoTable.GetListByField("SalonIID", selectedSalon.IID);

            string locker = "";
            foreach (Masa table in tablelist)
            {

                if (table.LockedClientIP != null && table.LockedClientIP != "")
                    locker = table.LockedClientIP;

                TableButton btn = new TableButton();
                btn.Text = table.TableName;
                btn.Table = table;
                btn.Font = new Font("Arial", 12, FontStyle.Bold);
                if (locker.Length > 0) {
                    btn.BackColor = Color.DarkBlue; // BSLayer.Instance.config.Table_Busy_Back_Color;  // Color.DarkBlue;
                    btn.ForeColor = Color.White; //  BSLayer.Instance.config.Table_Busy_Text_Color;
                }
                else {
                    if (table.HasActiveOrder) {
                        btn.BackColor = Color.DarkRed; //  BSLayer.Instance.config.Table_Full_Back_Color; //  Color.DarkRed;
                        btn.ForeColor = Color.White; //  BSLayer.Instance.config.Table_Full_Text_Color;
                    }
                    else {
                        btn.BackColor = Color.DarkGreen;
                        //  BSLayer.Instance.config.Table_Free_Back_Color; // SystemColors.ControlDarkDark;
                        btn.ForeColor = Color.White; //  BSLayer.Instance.config.Table_Free_Text_Color;
                    }
                }
                btn.Location = new Point(table.XLocation, table.YLocation);
                btn.Size = new Size(table.Width, table.Height);
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Click += new System.EventHandler(this.btnSelectTableButton_Click);
                pnlTables.Controls.Add(btn);
                locker = "";
            }
        }

        private void btnSelectTableButton_Click(object sender, EventArgs e) {
            SelectedTableButton = (TableButton) sender;
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
