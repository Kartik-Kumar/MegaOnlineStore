using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaOnlineStore.Entities
{
    public class Product
    {
        
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string  Description { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        public string Catagory { get; set; }
        public int Quantity { get; set; }
        

    }
}
