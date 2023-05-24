using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Shared
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public int SupplierID { get; set; }
        public int OnHandQty { get; set; }
        public int MinQty { get; set; }
        public int? LastOrderID { get; set; }
        public int[]? Tags { get; set; }


    }
}
