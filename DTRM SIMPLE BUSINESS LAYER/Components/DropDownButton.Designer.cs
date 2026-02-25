using System.Windows.Forms;
using System.Drawing;
using System;

namespace DTRMNS {
    partial class DropDownButton {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
       // private System.ComponentModel.IContainer components = null;
     
        public event EventHandler AnyItemClick;
        protected void OnAnyItemClick(object sender, EventArgs e) {
            //bubble the event up to the parent
            if (this.AnyItemClick != null)
                this.AnyItemClick(this, e);
        }
        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            //if (disposing && (components != null)) {
            //    components.Dispose();
            //}
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            //components = new System.ComponentModel.Container();
            this.DropDownItems = new DropDownButtonItem[0];
            // 
            // DropDownButton
            // 
            this.Click += new System.EventHandler(this.DropDownButton_Click);
            this.MouseLeave += new System.EventHandler(this.DropDownButton_MouseLeave);            
        }

        private void DropDownButton_MouseLeave(object sender, System.EventArgs e) {
            if (pnl != null) {
                Point p = this.Parent.PointToClient(Cursor.Position);
                int x = p.X;
                int y = p.Y;
                Rectangle rect = pnl.Bounds;
                if (!rect.Contains(x, y)) {
                    // Panel disi nokta
                    pnl.Hide();
                }
            }
        }

        private void DropDownButton_Click(object sender, System.EventArgs e) {
            if (pnl == null) {
                pnl = new Form();
                pnl.FormBorderStyle = FormBorderStyle.None;
                pnl.StartPosition = FormStartPosition.Manual;
                pnl.MinimumSize = this.Size;

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
                    DropDownItems[i].MouseUp += DropDownButton_MouseUp;
                    DropDownItems[i].ParentButton = this;
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
            pnl.Show();
        }


        private void DropDownButton_MouseUp(object sender, MouseEventArgs e) {
            if (pnl != null)
                pnl.Hide();
        }
        #endregion

        
        public DockStyle ItemsDockStyle { get; set; } = DockStyle.Bottom;

        private Form pnl;
        public bool SameSizeButtons { get; set; } = true;
    }
}
