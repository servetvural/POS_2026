using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

using POSLayer.Library;

namespace POSLayer.Models;

public partial class XOrder : BaseOrder
{

    public List<XOrderItem> Items { get; set; } = new();
    public Order ToOrder()
    {
        Order order = new Order()
        {
            IID = this.IID,
            DOrder = this.DOrder,
            OrderDate = this.OrderDate,
            SessionIID = this.SessionIID,
            TableIID = this.TableIID,
            CustomerIID = this.CustomerIID,
            UserIID = this.UserIID,
            LastModified = this.LastModified,
            Covers = this.Covers,
            OrderType = this.OrderType,
            Payment = this.Payment,
            Status = this.Status,
            LockedClientIP = this.LockedClientIP,
            Instruction = this.Instruction,
            PaymentFlag = this.PaymentFlag,
            Reference = this.Reference,
            ServiceChargeRate = this.ServiceChargeRate,
            ServiceChargeTaxRate = this.ServiceChargeTaxRate
        };
        foreach (var item in Items)
        {
            order.Items.Add(item.ToOrderItem());
        }
        return order;

    }

}
