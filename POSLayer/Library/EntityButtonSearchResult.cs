using System;
using System.Collections.Generic;
using System.Text;

using POSLayer.Models;

namespace POSLayer.Library;

public class EntityButtonSearchResult
{
    public string IID { get; set; }
    public string EntityButtonName { get; set; }
    public string EntityName { get; set; }
    public GenericImage DisplayImage { get; set; }

    public EntityButtonSearchResult()
    {

    }
}
