using System.ComponentModel;
using System.Globalization;
using POSLayer.Library;
using POSLayer.Models;

namespace WinLayer {
    public partial class frmVariables : Form {
        private KitchenOrderItem koi;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string ItemVariableText { get; set; }

        private int ModifiedQuantity { get; set; }
        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;

        public frmVariables() {
            InitializeComponent();
        }
        public frmVariables( KitchenOrderItem koi) {
            InitializeComponent();
            this.koi = koi;
        }
        private void frmVariables_Load(object sender, EventArgs e) {
            GetRidOfQuantityButtons();
            lblResult.Text = koi.ItemText;
        }

        private void GetRidOfQuantityButtons() {
            foreach (Control ctl in pnlHowMany.Controls) {
                if (ctl is RadioButton) {
                    if (ctl.Text.ToUpper() == "ALL")
                        continue;
                    if (int.Parse(((RadioButton)ctl).Text) > koi.Quantity - koi.ModifiedQuantity)
                        ((RadioButton)ctl).Visible = false;
                }
            }

            rbAll.Visible = (koi.Modified == 0);
        }
        private void AddVariableText(string variableText) {
            CheckBox rb = new CheckBox();
            rb.Text = variableText;
            rb.Appearance = Appearance.Button;
            rb.BackColor = Color.Black;
            //rb.ForeColor = Color.White;
            rb.FlatStyle = FlatStyle.Flat;
            rb.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Regular);
            rb.TextAlign = ContentAlignment.MiddleLeft;
            rb.Size = new Size(200, 79);
            rb.CheckedChanged += new EventHandler(this.Rb_CheckedChanged);
            rb.Dock = DockStyle.Top;
            pnlText.Controls.Add(rb);
            rb.BringToFront();


        }

        private void Rb_CheckedChanged(object sender, EventArgs e) {
            if (((Control)sender).Text == "")
                return;
            int test = 0;




            ItemVariableText = " (";
            foreach (Control ctl in pnlHowMany.Controls) {
                if (ctl is RadioButton) {
                    if (((RadioButton)ctl).Checked) {
                        ctl.BackColor = Color.DarkGreen;
                        string label = ((RadioButton)ctl).Text;
                        ItemVariableText += label + " ";
                        if (label.ToUpper() == "ALL")
                            ModifiedQuantity = koi.Quantity;
                        else
                            ModifiedQuantity = int.Parse(label);
                        test = 1;
                    } else
                        ctl.BackColor = Color.Black;
                }
            }

            foreach (Control ctl in pnlVariables.Controls) {
                if (ctl is RadioButton) {
                    if (((RadioButton)ctl).Checked) {
                        ctl.BackColor = Color.DarkGreen;
                        ItemVariableText += ((RadioButton)ctl).Text + " ";
                        test += 1;
                    } else
                        ctl.BackColor = Color.Black;
                }
            }

            int chkCount = 0;
            foreach (Control ctl in pnlText.Controls) {
                if (ctl is CheckBox) {
                    if (((CheckBox)ctl).Checked) {
                        ctl.BackColor = Color.DarkGreen;
                        ItemVariableText += (chkCount > 0 ? " && " : "") + ((CheckBox)ctl).Text;
                        chkCount++;
                    } else
                        ctl.BackColor = Color.Black;
                }
            }
            foreach (Control ctl in pnlText2.Controls) {
                if (ctl is CheckBox) {
                    if (((CheckBox)ctl).Checked) {
                        ctl.BackColor = Color.DarkGreen;
                        ItemVariableText += (chkCount > 0 ? " && " : "") + ((CheckBox)ctl).Text;
                        chkCount++;
                    } else
                        ctl.BackColor = Color.Black;
                }
            }
            foreach (Control ctl in pnlText3.Controls) {
                if (ctl is CheckBox) {
                    if (((CheckBox)ctl).Checked) {
                        ctl.BackColor = Color.DarkGreen;
                        
                        CheckState chkstate = ((CheckBox)ctl).CheckState;
                        if (chkstate == CheckState.Checked && (ctl.Tag == null)) {
                            frmNumericInput frm = new frmNumericInput();
                            if (frm.ShowDialog() == DialogResult.OK) {
                                ctl.Tag = frm.SelectedValue;
                            } 
                        }
                        string quantity = "";
                        if (ctl.Tag != null) 
                            quantity = ctl.Tag.ToString() + " ";
                        
                        ItemVariableText += (chkCount > 0 ? " && " : "") + quantity +  ((CheckBox)ctl).Text;
                        chkCount++;
                    } else {
                        ctl.BackColor = Color.Black;
                        ctl.Tag = null;
                    }
                }
            }
            ItemVariableText += ")";
            lblResult.Text = koi.ItemText + ti.ToTitleCase(ItemVariableText.ToLower());

            btnOKAll.Visible = (test == 2) && chkCount > 0;
        }



        private void BtnOKAll_Click(object sender, EventArgs e) {
            koi.ModifiedQuantity += ModifiedQuantity;

            koi.ItemText += ti.ToTitleCase(ItemVariableText.ToLower());

            if (koi.ModifiedQuantity == 0)
                koi.Modified = ModificationFlag.None;
            else if (koi.Quantity > koi.ModifiedQuantity)
                koi.Modified = ModificationFlag.Partially;
            else
                koi.Modified = ModificationFlag.Completed;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnClear_Click(object sender, EventArgs e) {
            lblResult.Text = "";
        }

        private void tabGeneral_Paint(object sender, PaintEventArgs e) {
            SolidBrush fillBrush = new SolidBrush(BackColor);
            e.Graphics.FillRectangle(fillBrush, e.ClipRectangle);
        }

        private void countable_CheckStateChanged(object sender, EventArgs e) {
            CheckBox chk = (CheckBox)sender;
            if (!chk.Checked) {
                chk.Tag = null;
            }
           
        }
    }
}
