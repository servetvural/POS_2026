using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Text;

namespace POSWinFormLayer.Library;

public class ScreenSaverImage
{

    public Image image { get; set; } = new Bitmap(1, 1);
    public Point location;
    public int ZoomFactor { get; set; }
    public int MaxZoomFactor { get; set; } = 1;
    public int StepX { get; set; } = 0;
    public int StepY { get; set; } = -1;
    private Random rnd = new Random();
    public string Name { get; set; } = "Unknown";
    private int maximumY;
    private int maximumX;

    public Size originalImageSize;

    public ScreenSaverImage()
    {

    }
    public ScreenSaverImage(Image img)
    {
        image = img;
        location = new Point(0, 0);
    }
    public ScreenSaverImage(Image img, int x, int y)
    {
        image = img;
        location = new Point(x, y);
    }
    public ScreenSaverImage(Image img, Point location)
    {
        image = img;
        this.location = location;
    }
    public ScreenSaverImage(Image img, int maxX, int maxY, int screenWidth, bool blnAllowImageCrop = false, int stepY = 1, int stepX = 0)
    {
        this.StepX = stepX;
        this.StepY = stepY;
        maximumY = maxY;
        maximumX = maxX;

        image = img;
        int x = 0;
        rnd.Next(0, maxX - img.Width);
        if (blnAllowImageCrop)
        {
            x = rnd.Next(0, maxX - 20);
        } else
        {
            x = rnd.Next(0, (maxX - image.Width) < 0 ? maxX : maxX - image.Width);
        }

        originalImageSize = img.Size;
        SetMaxZoomFactor(screenWidth);
        int y = maxY + rnd.Next(50);
        location = new Point(x, y);


    }
    public void SetMaxZoomFactor(int screenWidth)
    {
        int maxallowedwidth = screenWidth / 2;
        MaxZoomFactor = maxallowedwidth / image.Width;

        MaxZoomFactor = MaxZoomFactor <= 0 ? 1 : MaxZoomFactor;
        ZoomFactor = rnd.Next(1, MaxZoomFactor);

    }
    public ScreenSaverImage Step()
    {
        location.X += StepX;
        location.Y += StepY;
        if (location.Y + image.Height < 0)
        {
            //it is coming back to range again so change parameters
            location.Y = maximumY;
            StepY = rnd.Next(20) * -1;

            location.X = rnd.Next(maximumX);

            ZoomFactor = rnd.Next(1, MaxZoomFactor);
            Zoom();
        }
        return this;
    }

    public void Zoom()
    {
        Rectangle destinationRect = new Rectangle(0, 0, originalImageSize.Width * ZoomFactor, originalImageSize.Height * ZoomFactor);
        var destImage = new Bitmap(destinationRect.Width, destinationRect.Height);
        destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

        using (var graphics = Graphics.FromImage(destImage))
        {
            graphics.CompositingMode = CompositingMode.SourceCopy;
            graphics.CompositingQuality = CompositingQuality.HighQuality;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            using (var wrapMode = new ImageAttributes())
            {
                wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                graphics.DrawImage(image, destinationRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
            }
            image = destImage;
            if (image.Width + location.X > maximumX)
                location.X = location.X - image.Width;
        }
    }

    public void ResizeWidth(int destinationWidth, int destinationHeight)
    {
        float factorWidth = (float)destinationWidth / (float)originalImageSize.Width;
        float factorHeight = (float)destinationHeight / (float)originalImageSize.Height;
        //use smaller one
        float factor = (factorWidth > factorHeight ? factorHeight : factorWidth);

        Rectangle destinationRect = new Rectangle(0, 0, (int)(originalImageSize.Width * factor), (int)(originalImageSize.Height * factor));
        var destImage = new Bitmap(destinationRect.Width, destinationRect.Height);
        // destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

        using (var graphics = Graphics.FromImage(destImage))
        {
            graphics.CompositingMode = CompositingMode.SourceCopy;
            graphics.CompositingQuality = CompositingQuality.HighQuality;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            using (var wrapMode = new ImageAttributes())
            {
                wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                graphics.DrawImage(image, destinationRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
            }
            image = destImage;
            //if (image.Width + location.X > maximumX)
            //    location.X = location.X - image.Width;
        }
    }

    public static Image Resize(Image image, int destinationWidth, int destinationHeight)
    {
        float factorWidth = (float)destinationWidth / (float)image.Width;
        float factorHeight = (float)destinationHeight / (float)image.Height;
        //use smaller one
        float factor = (factorWidth > factorHeight ? factorHeight : factorWidth);

        Rectangle destinationRect = new Rectangle(0, 0, (int)(image.Width * factor), (int)(image.Height * factor));
        var destImage = new Bitmap(destinationRect.Width, destinationRect.Height);
        // destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

        using (var graphics = Graphics.FromImage(destImage))
        {
            graphics.CompositingMode = CompositingMode.SourceCopy;
            graphics.CompositingQuality = CompositingQuality.HighQuality;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            using (var wrapMode = new ImageAttributes())
            {
                wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                graphics.DrawImage(image, destinationRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
            }
            return destImage;
        }
    }
}