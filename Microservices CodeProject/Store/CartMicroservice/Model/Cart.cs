﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartMicroservice.Model
{
    public class Cart
    {
        public static readonly string DocumentName = "carts";

        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}
