using System;
using System.Collections.Generic;
using System.Text;

namespace POSLayer.Models;

public class PurchaseInvoiceItem : BaseClass
{
    public string PurchaseInvoiceIID { get; set; }
    public PurchaseInvoice PurchaseInvoice { get; set; }

    public string? StockItemIID { get; set; }
    public StockItem? StockItem { get; set; }
}
