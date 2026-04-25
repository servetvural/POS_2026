using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinLayer; 

public partial class Expander : Panel {
    
    private int _ExpandableControlWidth;
    private int _ExpandableControlHeight;

    private bool _Fixed;
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public bool Fixed {
        get { return _Fixed; }
        set {
            _Fixed = value;
            BackColor = (_Fixed ? ColourFixed : ColourUnFixed);
            if (_Fixed)
                btnLock.BackgroundImage = Properties.Resources.PinRedDown;
            else
                btnLock.BackgroundImage = Properties.Resources.PinGreenUp;
            btnExpand.Visible = !_Fixed;
            Refresh();
        }
    }
    
    //public bool FunctionWhenNotDockedTogether { get; set; } = false;

    private Color _ColourFixed = Color.Salmon;
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Color ColourFixed { get { return _ColourFixed; } set { _ColourFixed = value; Refresh(); } }

    private Color _ColourUnFixed = SystemColors.ActiveCaption;
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Color ColourUnFixed { get { return _ColourUnFixed; } set { _ColourUnFixed = value; Refresh(); } }

    private string _Caption = "";
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public string Caption { get { return _Caption; } set { _Caption = value; Refresh(); } }

    private Color _CaptionForeColor = Color.White;
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Color CaptionForeColor { get { return _CaptionForeColor; } set{_CaptionForeColor = value; Refresh(); } }

    private Font _CaptionFont = new Font("Arial", 10, FontStyle.Bold);
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Font CaptionFont {
        get { return _CaptionFont; }
        set { _CaptionFont = value; Refresh(); }
    }

    private Orientation _CaptionOrientation = Orientation.Horizontal;
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Orientation CaptionOrientation { get { return _CaptionOrientation; } set { _CaptionOrientation = value; Refresh(); } }
    
    private ContentAlignment _captionAlignment = ContentAlignment.MiddleCenter;
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public ContentAlignment CaptionAlignment {
        get { return _captionAlignment; }
        set { _captionAlignment = value; Refresh(); }
    }

    private Control expandableControl;
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Control ExpandableControl {
        get { return expandableControl; }
        set {
            expandableControl = value;
            if (expandableControl != null) {
                _ExpandableControlWidth = expandableControl.Width;
                _ExpandableControlHeight = expandableControl.Height;
            }
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Color ExpandButtonBackColor { get { return btnExpand.BackColor; } set{ btnExpand.BackColor = value; Refresh(); } }

    private bool blnexpanded = true;
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public bool Expanded { 
        get {
            return blnexpanded;
        }
        set {
            blnexpanded = value;
            if (ExpandableControl != null) {
                if (blnexpanded) {
                    ExpandableControl.Height = _ExpandableControlHeight;
                    ExpandableControl.Width = _ExpandableControlWidth;
                }
                else {
                    switch (this.Dock) {
                        case DockStyle.Top:
                        case DockStyle.Bottom:
                            //Get the height to the memory
                            _ExpandableControlHeight = ExpandableControl.Height;
                            //NestedControl
                            if (ExpandableControl == Parent)                                     
                                ExpandableControl.Height = this.Height;                      
                            else 
                                ExpandableControl.Height = 0;
                            
                            break;
                        case DockStyle.Left:
                        case DockStyle.Right:
                            //Get the width to the memory
                            _ExpandableControlWidth = ExpandableControl.Width;
                            //NestedControl
                            if (ExpandableControl == Parent) 
                                ExpandableControl.Width = this.Width; //Hide as much as expander's width
                            else 
                                ExpandableControl.Width = 0;
                            
                            break;
                        default:
                            //Get the width to the memory
                            _ExpandableControlWidth = ExpandableControl.Width;                               
                            expandableControl.Width = 0;
                            break;
                    }
                    

                }
            }
        }
    }

    public Expander() {
        InitializeComponent();           
    }

    private void Expander_MouseDown(object sender, MouseEventArgs e) {
        if (Fixed)
            return;
        
        startPositionX = e.X;
        startPositionY = e.Y;
    }
    
    private int startPositionX;
    private int startPositionY;
    private void Expander_MouseMove(object sender, MouseEventArgs e) {
        if (_Fixed) 
            return;
        //if (!FunctionWhenNotDockedTogether)
        //    return;

        Cursor.Current = Cursors.Hand;
        if (e.Button == MouseButtons.Left) {

            if (expandableControl != null) {
                if (expandableControl == Parent) {
                    if ((expandableControl.Dock == DockStyle.Top && this.Dock == DockStyle.Bottom) ||
                        (expandableControl.Dock == DockStyle.Bottom && this.Dock == DockStyle.Top))
                        _ExpandableControlHeight = expandableControl.Height += e.Y - startPositionY;

                    if ((expandableControl.Dock == DockStyle.Left && this.Dock == DockStyle.Right) ||
                        (expandableControl.Dock == DockStyle.Right && this.Dock == DockStyle.Left))
                        _ExpandableControlWidth = expandableControl.Width += e.X - startPositionX;
                } else {
                    if ((expandableControl.Dock == DockStyle.Top && this.Dock == DockStyle.Top) ||
                        (expandableControl.Dock == DockStyle.Bottom && this.Dock == DockStyle.Bottom))
                        _ExpandableControlHeight = expandableControl.Height += e.Y - startPositionY;

                    if ((expandableControl.Dock == DockStyle.Left && this.Dock == DockStyle.Left) ||
                        (expandableControl.Dock == DockStyle.Right && this.Dock == DockStyle.Right))
                        _ExpandableControlWidth = expandableControl.Width += e.X - startPositionX;
                }
            }
        }
    }

    private void Expander_MouseUp(object sender, MouseEventArgs e) {
        if (Fixed)
            return;
        
    }

    private void Expander_Paint(object sender, PaintEventArgs e) {

        if (Caption.Length > 0) {
            float x = 0;
            float y = 0;
            SizeF hsize = e.Graphics.MeasureString(Caption.ToString(), CaptionFont);
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();               


            switch (CaptionOrientation) {
                case Orientation.Horizontal:
                    //use hsize                        
                    break;
                case Orientation.Vertical:
                    //convert 
                    hsize = new SizeF(hsize.Height, hsize.Width);
                    drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;
                    break;
            }
            switch (CaptionAlignment) {
                case ContentAlignment.MiddleLeft:
                    x = 0;
                    y = (Height - hsize.Height) / 2;
                    break;
                case ContentAlignment.BottomLeft:
                    x = 0;
                    y = (Height - hsize.Height);
                    break;
                case ContentAlignment.TopLeft:
                    x = 0;
                    y = 0;
                    break;
                case ContentAlignment.MiddleRight:
                    x = (Width - hsize.Width);
                    y = (Height - hsize.Height) / 2;
                    break;
                case ContentAlignment.BottomRight:
                    x = (Width - hsize.Width);
                    y = (Height - hsize.Height);
                    break;
                case ContentAlignment.TopRight:
                    x = (Width - hsize.Width);
                    y = 0;
                    break;
                case ContentAlignment.MiddleCenter:
                    x = (Width - hsize.Width) / 2;
                    y = (Height - hsize.Height) / 2;
                    break;
                case ContentAlignment.BottomCenter:
                    x = (Width - hsize.Width) / 2;
                    y = (Height - hsize.Height);
                    break;
                case ContentAlignment.TopCenter:
                    x = (Width - hsize.Width) / 2;
                    y = 0;
                    break;

            }
            e.Graphics.DrawString(Caption, CaptionFont, new SolidBrush(CaptionForeColor), x, y, drawFormat);                
        }
    }


    public Button LockButton { get { return btnLock; } }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Size LockButtonSize { get { return btnLock.Size; } set { btnLock.Size = value; } }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public DockStyle LockButtonDock { get { return btnLock.Dock; } set { btnLock.Dock = value; } }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public bool LockButtonVisible { get { return btnLock.Visible; } set { btnLock.Visible = value; } } 


    private void btnLock_Click(object sender, EventArgs e) {
        Fixed = !Fixed;
        
    }

    private void Expander_DockChanged(object sender, EventArgs e) {
        switch (this.Dock) {
            case DockStyle.Left:
            case DockStyle.Right:
                btnLock.Dock = DockStyle.Top;
                btnLock.Height = 32;

                btnExpand.Dock = DockStyle.Bottom;
                btnExpand.Height = 64;
                btnExpand.BackgroundImage = Properties.Resources.double_horizontal_arrow;
                this.Width = 30;
                break;
            case DockStyle.Fill:
                btnLock.Dock = DockStyle.Top;
                btnLock.Height = 32;

                btnExpand.Dock = DockStyle.Bottom;
                btnExpand.Height = 64;
                btnExpand.BackgroundImage = Properties.Resources.double_horizontal_arrow;
                break;
            case DockStyle.Top:
            case DockStyle.Bottom:
                btnLock.Dock = DockStyle.Left;
                btnLock.Width = 32;

                btnExpand.Dock = DockStyle.Right;
                btnExpand.Width = 64;
                btnExpand.BackgroundImage = Properties.Resources.double_vertical_arrow;
                this.Height = 30;
                break;
        }
    }

    private void btnExpand_Click(object sender, EventArgs e) {
        if (Fixed)
            return;

        //if (!FunctionWhenNotDockedTogether)
        //    return;


        Expanded = !Expanded;
    }
    //private bool IsDockedTogether() {
    //    if (expandableControl == null)
    //        return false;
    //    int dockedPointShouldBe = 0;
    //    switch (expandableControl.Dock) {
    //        case DockStyle.Left:
    //            if (this.Dock != DockStyle.Left)
    //                return false;
    //            return (expandableControl.Left + expandableControl.Width) == this.Location.X;
    //        case DockStyle.Right:
    //            if (this.Dock != DockStyle.Right)
    //                return false;
    //            return (expandableControl.Left + expandableControl.Width) == this.Location.X;


    //    }
    //}

    private void Expander_MouseLeave(object sender, EventArgs e) {
        Cursor.Current = Cursors.Arrow;
    }
}
