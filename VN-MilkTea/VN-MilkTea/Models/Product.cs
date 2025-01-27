﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VN_MilkTea.Models
{
    public class Product
    {
        [Key]
        public long ProductId { get; set; }
        public string ProductName { get; set; }

        public Nullable<double> Price { get; set; }
        public string Image { get; set; }
        public Nullable<long> BrandId { get; set; }
        public Nullable<long> CategoryId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
    }
}