﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VN_MilkTea.Models
{
    public class Order
    {
        [Key]
        public long OrderId { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<int> OrderStatus { get; set; }
        public Nullable<long> UserId { get; set; }
        public Nullable<long> ProductId { get; set; }


        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}