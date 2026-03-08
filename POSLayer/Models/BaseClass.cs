using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using POSLayer.Library;

namespace POSLayer.Models;

public partial class BaseClass : ISelectable
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public virtual string IID { get; set; }   = ShortGuid.NewGuid().ToString();

   // public int DisplayOrder { get; set; }

    [NotMapped]
    public bool Selected { get; set; }

    public void Select()
    {
        Selected = true;
    }
    public void DeSelect()
    {
        Selected = false;
    }
}
