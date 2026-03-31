

using System.ComponentModel.DataAnnotations.Schema;

using POSLayer.Library;

namespace POSLayer.Models;

public partial class GenericImage     : BaseClass  
{
    public string? ReferenceIID { get; set; }

    public byte[]? DisplayImage { get; set; }

    public string? ExtraText { get; set; } = null!;

    public string? ImageFileName { get; set; }


    public long ImageSizeinKB { get; set; }

    public void SetImage(string FileName)
    {
        try
        {
            DisplayImage = File.ReadAllBytes(FileName);

            FileInfo finfo = new FileInfo(FileName);
            ImageFileName = finfo.Name;
            ImageSizeinKB = finfo.Length / 1024;
        } catch
        {

        }
    }

   
}
