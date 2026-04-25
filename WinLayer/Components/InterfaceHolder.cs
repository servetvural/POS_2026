using System.Collections.Generic;
using System.ComponentModel;

namespace WinLayer {
    public class InterfaceHolder : System.Windows.Forms.Control {
        public List<UPEntity> Panels;
        private int _SelectedIndex;
        public InterfaceHolder() {
            Panels = new List<UPEntity>();
            SelectedIndex = -1;            
        }
        public InterfaceHolder(string name) {
            Panels = new List<UPEntity>();
            SelectedIndex = -1;
            Name = name;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int SelectedIndex {
            get {
                if (_SelectedIndex < 0 && Panels.Count > 0)
                    _SelectedIndex = 0;
                return _SelectedIndex;
            }
            set { _SelectedIndex = value; }
        }
        public UPEntity SelectedPanel { get { return Panels[SelectedIndex]; } }

        private void InitializeComponent() {
            this.SuspendLayout();
            // 
            // InterfaceHolder
            // 
            this.Name = "InterfaceHolder";
            this.Size = new System.Drawing.Size(670, 548);
            this.ResumeLayout(false);

        }
    }
}
