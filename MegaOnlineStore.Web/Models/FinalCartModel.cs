using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaOnlineStore.Web.Models
{
    public class FinalCartModel
    {
        public List<CartViewModel> cartViewModel = new List<CartViewModel>();
        public double TotalAmount { get; set; }
        public int TotalItem { get; set; }
    }
}