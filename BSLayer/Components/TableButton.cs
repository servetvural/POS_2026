using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;

using POSLayer.Library;
using POSLayer.Models;

namespace BSLayer{
    public class TableButton : System.Windows.Forms.Button{
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        //public string IID { get; set; }
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        //public string TableNumber { get; set; }

        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        //public ButtonShapeTypes Shape { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Masa Table { get; set; }

        //public TableButton() {
        //    IID = "";
        //    TableNumber = "";
        //}

        //public TableButton(string IID, string TableNumber, int x, int y, int Width, int Height) {
        //    this.IID = IID;
        //    this.TableNumber = TableNumber;
        //    Text = TableNumber;
        //    Location = new Point(x, y);
        //    Size = new Size(Width, Height);
        //}

        //public TableButton(string IID, string TableNumber, int x, int y, int Width, int Height,
        //    ButtonShapeTypes Shape) {
        //    this.IID = IID;
        //    this.TableNumber = TableNumber;
        //    Text = TableNumber;
        //    Location = new Point(x, y);
        //    Size = new Size(Width, Height);
        //    this.Shape = Shape;
        //}

        //protected override void OnPaint(System.Windows.Forms.PaintEventArgs e) {
        //    switch (Shape) {
        //        case ButtonShapeTypes.Rectangle:
        //            base.OnPaint(e);
        //            break;
        //        case ButtonShapeTypes.Circle:
        //            GraphicsPath grPath = new GraphicsPath();
        //            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
        //            this.Region = new System.Drawing.Region(grPath);
        //            base.OnPaint(e);
        //            break;
        //    }
        //}
    }
}
