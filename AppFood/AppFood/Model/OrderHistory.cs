﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppFood.Model
{
    public class OrderHistory : List<OrderDetails>
    {
        public string OrderId { get; set; }
        public string Username { get; set; }
        public decimal TotalCost { get; set; }
        public string ReceiptId { get; set; }
    }
}
