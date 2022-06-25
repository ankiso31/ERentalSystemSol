using System;
using System.Collections.Generic;

#nullable disable

namespace ERentalWebAPI.Model
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
            Vendors = new HashSet<Vendor>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Vendor> Vendors { get; set; }
    }
}
