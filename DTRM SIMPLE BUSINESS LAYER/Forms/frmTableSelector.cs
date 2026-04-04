using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

using POSLayer.Models;

namespace DTRMNS{
    public partial class frmTableSelector : Form{
        public TableButton SelectedTableButton;
        private string SelectedGroup;

        public frmTableSelector() {
            InitializeComponent();
        }



        private void frmTableSelector_Load(object sender, EventArgs e) {
            //Loads tables as well through autoselectionchange method
            LoadGroups();

        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void LoadGroups() {
            pnlGroups.Controls.Clear();

            DataTable dt = DTRMSimpleBusiness.Instance.GetAllTableGroups();
            for (int i = 0; i < dt.Rows.Count; i++) {
                RadioButton btn = new RadioButton();
                btn.Appearance = Appearance.Button;
                btn.CheckedChanged += new EventHandler(GroupButton_CheckedChanged);
                btn.BackColor = Color.Green;
                btn.BackgroundImage = Properties.Resources.shadow;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.MinimumSize = new Size(90, 50);
                btn.AutoSize = true;
                btn.Font = new Font("Arial", 9, FontStyle.Bold);
                btn.ForeColor = Color.Black;
                btn.Text = dt.Rows[i]["GroupName"].ToString();
                btn.Tag = dt.Rows[i]["IID"].ToString();
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

        private void GroupButton_CheckedChanged(object sender, EventArgs e) {
            RadioButton rb = (RadioButton) sender;
            if (rb.Checked) {
                rb.FlatAppearance.BorderSize = 1;
                SelectedGroup = rb.Tag.ToString();
                LoadTables();
            }
            else
                rb.FlatAppearance.BorderSize = 0;
        }

        private async void LoadTables() {
            List<Masa> tablelist = await DTRMSimpleBusiness.Instance.GetTableList(SelectedGroup);

            pnlTables.Controls.Clear();

            Masa table;
            string locker = "";
            for (int i = 0; i < tablelist.Count; i++) {
                table = tablelist[i];

                if (table.LockedClientIP != null && table.LockedClientIP != "")
                    locker = table.LockedClientIP;

                TableButton btn = new TableButton();
                btn.Text = table.TableName;
                btn.IID = table.IID;
                btn.Font = new Font("Arial", 12, FontStyle.Bold);
                if (locker.Length > 0) {
                    btn.BackColor = Color.DarkBlue; // DTRMSimpleBusiness.Instance.config.Table_Busy_Back_Color;  // Color.DarkBlue;
                    btn.ForeColor = Color.White; //  DTRMSimpleBusiness.Instance.config.Table_Busy_Text_Color;
                }
                else {
                    if (table.HasActiveOrder()) {
                        btn.BackColor = Color.DarkRed; //  DTRMSimpleBusiness.Instance.config.Table_Full_Back_Color; //  Color.DarkRed;
                        btn.ForeColor = Color.White; //  DTRMSimpleBusiness.Instance.config.Table_Full_Text_Color;
                    }
                    else {
                        btn.BackColor = Color.DarkGreen;
                        //  DTRMSimpleBusiness.Instance.config.Table_Free_Back_Color; // SystemColors.ControlDarkDark;
                        btn.ForeColor = Color.White; //  DTRMSimpleBusiness.Instance.config.Table_Free_Text_Color;
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
