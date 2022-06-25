using System;
using System.Collections.Generic;

#nullable disable

namespace ERentalWebAPI.Model
{
    public partial class Product
    {
        public Product()
        {
            Bookings = new HashSet<Booking>();
            Customers = new HashSet<Customer>();
            Orders = new HashSet<Order>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public int VendorId { get; set; }
        public string UnitAvailability { get; set; }
        public decimal UnitPrice { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        public virtual Category Category { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
