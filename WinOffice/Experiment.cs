using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

using POSLayer.Library;
using POSLayer.Models;

namespace WinOffice;


//public partial class BaseClass
//{
//    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
//    [Key]
//    public string IID { get; set; }

//}

//public class Menu : BaseClass
//{
//    public string MenuName { get; set; }

//    public List<Distribution> distributions { get; set; } = new();
//    public List<Category> categories { get; set; } = new();
//}

//public class Distribution : BaseClass
//{
//    public string DistributionName { get; set; }
//    public string MenuIID { get; set; }
//    public Menu Menu { get; set; }
//    public List<Printer> printers { get; set; } = new();
//}

//public class Printer : BaseClass
//{
//    public string PrinterName { get; set; }
//    public List<Distribution> distributions { get; set; } = new();

//}

//public class Category : BaseClass
//{
//    public string CategoryName { get; set; }

//    public string MenuIID { get; set; }
//    public Menu Menu { get; set; }
//    public List<CategoryItem> items { get; set; } = new();

//    public string? DistributionIID { get; set; }
//    public Distribution? Distribution { get; set; }
//}

//public class CategoryItem : BaseClass
//{
//    public string CategoryIID { get; set; }
//    public Category Category { get; set; }
//    public string ItemName { get; set; }

//    public string? DistributionIID { get; set; }
//    public Distribution? Distribution { get; set; }

//}