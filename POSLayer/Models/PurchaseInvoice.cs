using System;
using System.Collections.Generic;
using System.Text;

namespace POSLayer.Models;

public  class PurchaseInvoice : BaseClass
{

    public string SupplierIID { get; set; }

    public Supplier Supplier { get; set; }

    public List<PurchaseInvoiceItem> Items { get; set; } = new();
}
