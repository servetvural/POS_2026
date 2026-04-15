using System.Drawing;

namespace POSLayer.Models;

public partial class Salon: BaseClass
{
    public string SalonName { get; set; } = string.Empty;

    public int SalonColour { get; set; } = Color.White.ToArgb();
    public int Width { get; set; }

    public int Height { get; set; }

    public string ToInfoString()
    {
        return SalonName + ", " + Width + ", " + Height + ", " + DOrder;
    }
}
