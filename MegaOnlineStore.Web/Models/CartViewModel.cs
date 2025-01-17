﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaOnlineStore.Web.Models
{
    public class CartViewModel
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Catagory { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }
    }
}