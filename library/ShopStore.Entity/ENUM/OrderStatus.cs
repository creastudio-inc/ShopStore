﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity.ENUM
{
    public enum OrderStatus
    {
        New = 1,

        OnHold = 10,

        PendingPayment = 20,

        PaymentReceived = 30,

        PaymentFailed = 35,

        Invoiced = 40,

        Shipping = 50,

        Shipped = 60,

        Complete = 70,

        Canceled = 80,

        Refunded = 90,

        Closed = 100
    }
}
