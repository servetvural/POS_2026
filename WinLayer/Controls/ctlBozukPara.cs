using System.ComponentModel;
using POSLayer.Library;

namespace WinLayer {
    public partial class ctlBozukPara : UserControl {
        public event GenericEventHandlerAsync ValueChanged;
        private double _Kurus;
        private double _Tane;
        private double _Value;
        public ctlBozukPara() {
            InitializeComponent();
        }

        protected virtual void OnValueChanged(EventArgs e) {
            ValueChanged(this, e);
        }

        private void ctlBozukPara_Load(object sender, EventArgs e) {
            Calculate();
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public double Kurus {
            get { return _Kurus; }
            set {
                _Kurus = value;
                Calculate();
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public double Tane {
            get { return _Tane; }
            set {
                _Tane = value;
                Calculate();
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public double Value {
            get { return _Value; }
            set {
                _Value = value;
                try {
                    _Tane = _Value / _Kurus;
                } catch { }
                Calculate();
            }
        }
        public void Calculate() {
            _Value = _Tane * _Kurus;
            lblKurus.Text = _Kurus.ToString("f");
            btnTane.Text = _Tane.ToString();
            btnValue.Text = _Value.ToString("f");
            if (ValueChanged != null)
            ValueChanged(this,null);
        }
        private void btnTane_Click(object sender, EventArgs e) {
            TrmGetValue frm = new TrmGetValue(NumberModes.IntegerMode);
            if (frm.ShowDialog() == DialogResult.OK) {
                _Tane = frm.ReturnValue;
                Calculate();
            }
        }

        private void btnValue_Click(object sender, EventArgs e) {
            TrmGetValue frm = new TrmGetValue(NumberModes.FloatMode);
            if (frm.ShowDialog() == DialogResult.OK) {

                try {
                    _Value = frm.ReturnValue;
                    _Tane = _Value / _Kurus;
                } catch {
                    _Value = 0;
                    _Tane = 0;
                }
                Calculate();
            }
        }

    }
}
