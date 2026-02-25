using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTRMNS.Components {
    public partial class ButtonX : Button {
        private DockStyle itemsDockStyle = DockStyle.Bottom;
        public DockStyle ItemsDockStyle {
            get { return itemsDockStyle; }
            set { itemsDockStyle = value; }
        }

        private Form pnl;
        private Rectangle pnlRect;

        private bool sameSizeButtons  = true;
        public bool SameSizeButtons {
            get { return sameSizeButtons; }
            set { sameSizeButtons = value; }
        }

        private Button[] dropDownItems = new Button[0];

        public Button[] DropDownItems {
            get { return dropDownItems; }
            set { dropDownItems = value; }
        }


        public event EventHandler SomeClick;
        protected bool OnSomeClick(object sender, EventArgs e) {
            //bubble the event up to the parent
            if (this.SomeClick != null)
                this.SomeClick(this, e);
            return true;
        }

        public ButtonX() {
            InitializeComponent();
        }

        private void ButtonX_Click(object sender, EventArgs e) {
            if (pnl == null) {
                pnl = new Form();
                pnl.FormBorderStyle = FormBorderStyle.None;
                pnl.StartPosition = FormStartPosition.Manual;
                pnl.MinimumSize = this.Size;
                pnl.MouseLeave += Pnl_MouseLeave;

                switch (ItemsDockStyle) {
                    case DockStyle.Bottom:
                        pnl.Size = new Size(this.Width, this.Height * DropDownItems.Length);
                        break;
                    case DockStyle.Top:
                        pnl.Size = new Size(this.Width, this.Height * DropDownItems.Length);
                        break;
                    case DockStyle.Left:
                        pnl.Size = new Size(this.Width * DropDownItems.Length, this.Height);
                        break;
                    case DockStyle.Right:
                        pnl.Size = new Size(this.Width * DropDownItems.Length, this.Height);
                        break;
                    default:
                        pnl.Size = new Size(this.Width, this.Height * DropDownItems.Length);
                        break;
                }

                pnl.BackColor = this.BackColor;

                for (int i = 0; i < DropDownItems.Length; i++) {
                    DropDownItems[i].Dock = ItemsDockStyle;
                    DropDownItems[i].Tag = this;
                    DropDownItems[i].Click += ButtonX_Click1;
                    
                    //DropDownItems[i].MouseUp += DropDownButton_MouseUp;
                    //DropDownItems[i].ParentButton = this;
                    //DropDownItems[i].Click += OnAnyItemClick;
                    if (SameSizeButtons)
                        DropDownItems[i].Size = this.Size;
                    pnl.Controls.Add(DropDownItems[i]);
                }
            }

            Point btnlocation = this.PointToScreen(Point.Empty);

            switch (ItemsDockStyle) {
                case DockStyle.Bottom:
                    pnl.Location = new Point(btnlocation.X, btnlocation.Y + this.Height);
                    break;
                case DockStyle.Top:
                    pnl.Location = new Point(btnlocation.X, btnlocation.Y - (this.Height * DropDownItems.Length));
                    break;
                case DockStyle.Left:
                    pnl.Location = new Point(btnlocation.X - (this.Width * DropDownItems.Length), btnlocation.Y);
                    break;
                case DockStyle.Right:
                    pnl.Location = new Point(btnlocation.X + this.Width, btnlocation.Y);
                    break;
                default:
                    pnl.Location = new Point(btnlocation.X, btnlocation.Y - (this.Height * DropDownItems.Length));
                    break;
            }
            pnlRect = pnl.Bounds;
            pnl.Show();
            pnl.Invalidate();
        }

        private void ButtonX_Click1(object sender, EventArgs e) {
            //this.Text = (int.Parse(this.Text) + 1).ToString();
            ButtonX parentx = (ButtonX)((Button)sender).Tag;

            parentx.SomeClick(sender, e);

            
            //  pnl.Hide();

            //if (this.SomeClick != null)
            //    this.SomeClick(sender, e);
        }

        private void Pnl_MouseLeave(object sender, EventArgs e) {
            throw new NotImplementedException();
        }


        private void ButtonX_MouseLeave(object sender, EventArgs e) {
            if (pnl != null) {
                Point p = this.Parent.PointToClient(Cursor.Position);
                //int x = p.X;
                //int y = p.Y;
                //Rectangle rect = pnl.Bounds;
                if (pnl.Bounds.Contains(p.X, p.Y) || this.Bounds.Contains(p.X, p.Y)) {

                }
                else {
                    // Panel disi nokta
                    pnl.Hide();
                }
            }
        }

        private void ButtonX_MouseMove(object sender, MouseEventArgs e) {
            //if (pnl != null) {
            //    Point p = this.Parent.PointToClient(Cursor.Position);
            //    if (this.Bounds.Contains(p.X, p.Y))
            //        this.BackColor = Color.Blue;
                
            //    //if (pnl.Bounds.Contains(p.X, p.Y) || this.Bounds.Contains(p.X, p.Y)) {

            //    //}
            //    //else {
            //    //    // Panel disi nokta
            //    //    pnl.Hide();
            //    //}
            //}
        }
    }
}
