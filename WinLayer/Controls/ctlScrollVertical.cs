using System.ComponentModel;

namespace WinLayer {
    public partial class ctlScrollVertical : UserControl {
        private DataGridView _Dgv;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public DataGridView Dgv { get { return _Dgv; } set { _Dgv = value; } }
        public ctlScrollVertical() {
            InitializeComponent();
        }

        private void btnScrollUp_Click(object sender, EventArgs e) {
            try {
                if (_Dgv.FirstDisplayedScrollingRowIndex > 0)
                    _Dgv.FirstDisplayedScrollingRowIndex = _Dgv.FirstDisplayedScrollingRowIndex - 1;
            } catch { }
        }

        private void btnScrollUp10_Click(object sender, EventArgs e) {
            try {
                if (_Dgv.FirstDisplayedScrollingRowIndex > 0) {
                    if (_Dgv.FirstDisplayedScrollingRowIndex - 10 >= 0)
                        _Dgv.FirstDisplayedScrollingRowIndex = _Dgv.FirstDisplayedScrollingRowIndex - 10;
                    else
                        _Dgv.FirstDisplayedScrollingRowIndex = 0;
                }
            } catch { }
        }

        private void btnScrollDown10_Click(object sender, EventArgs e) {
            try {
                if (_Dgv.FirstDisplayedScrollingRowIndex < _Dgv.Rows.Count)
                    _Dgv.FirstDisplayedScrollingRowIndex = _Dgv.FirstDisplayedScrollingRowIndex + 10;
            } catch { }
        }

        private void btnScrollDown_Click(object sender, EventArgs e) {
            try {
                if (_Dgv.FirstDisplayedScrollingRowIndex < _Dgv.Rows.Count)
                    _Dgv.FirstDisplayedScrollingRowIndex = _Dgv.FirstDisplayedScrollingRowIndex + 1;
            } catch { }
        }


    }
}
