using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace WinLayer; 
public partial class DRProgressBar : Panel {
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public int Maximum { get; set; } = 100;
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public int Minimum { get; set; } = 0;
    private float ProgressWidth { get; set; } = 0;



    private int _Value = 0;
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public int Value {
        get { return _Value; }
        set {
            if (value > Maximum && value < Minimum)
                return;

            _Value = value;
            ProgressWidth = (float)Width / (float)Maximum;
            Refresh();
        }
    }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public System.Drawing.Color ProgressColour { get; set; } = Color.Green;

    bool blnShowValueText = false;
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public bool ShowValueText { get { return blnShowValueText; } set { blnShowValueText = value; Refresh(); } }

    bool blnShowRemainingValueText = false;
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public bool ShowRemainingValueText {
        get { return blnShowRemainingValueText; }
        set {
            blnShowRemainingValueText = value;
            Refresh();
        }
    }

    public DRProgressBar() {
        Text = "";
        InitializeComponent();
    }

    private ContentAlignment textalignment = ContentAlignment.MiddleLeft;
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public ContentAlignment TextAlignment {
        get { return textalignment; }
        set { textalignment = value; Refresh(); } }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public string CustomFormat { get; set; } = "N0";
    private void DRProgressBar_Paint(object sender, PaintEventArgs e) {
        Graphics g = e.Graphics;
        g.FillRectangle(new SolidBrush(ProgressColour), new RectangleF(0, 0, ProgressWidth * _Value, this.Height));

        float x=0;
        float y=0;
        SizeF vsize = new SizeF();
        

        if (ShowValueText)
            vsize = g.MeasureString(_Value.ToString(), this.Font);

        if (ShowRemainingValueText)
            vsize = g.MeasureString((Maximum - _Value).ToString(), this.Font);

        if (ShowValueText || ShowRemainingValueText) {
            switch (TextAlignment) {
                case ContentAlignment.MiddleLeft:
                    x = 0;
                    y = (Height - vsize.Height) / 2;
                    break;
                case ContentAlignment.BottomLeft:
                    x = 0;
                    y = (Height - vsize.Height);
                    break;
                case ContentAlignment.TopLeft:
                    x = 0;
                    y = 0;
                    break;
                case ContentAlignment.MiddleRight:
                    x = (Width - vsize.Width);
                    y = (Height - vsize.Height) / 2;
                    break;
                case ContentAlignment.BottomRight:
                    x = (Width - vsize.Width);
                    y = (Height - vsize.Height);
                    break;
                case ContentAlignment.TopRight:
                    x = (Width - vsize.Width);
                    y = 0;
                    break;
                case ContentAlignment.MiddleCenter:
                    x = (Width - vsize.Width) / 2;
                    y = (Height - vsize.Height) / 2;
                    break;
                case ContentAlignment.BottomCenter:
                    x = (Width - vsize.Width) / 2;
                    y = (Height - vsize.Height);
                    break;
                case ContentAlignment.TopCenter:
                    x = (Width - vsize.Width) / 2;
                    y = 0;
                    break;

            }

            if (ShowValueText)
                g.DrawString(_Value.ToString(CustomFormat), this.Font, new SolidBrush(this.ForeColor), x, y);

            if (ShowRemainingValueText)
                g.DrawString((Maximum - _Value).ToString(CustomFormat), this.Font, new SolidBrush(this.ForeColor), x, y);
        }

    }

   


}
