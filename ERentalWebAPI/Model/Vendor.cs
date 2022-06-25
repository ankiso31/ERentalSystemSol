using System;
using System.Collections.Generic;

#nullable disable

namespace ERentalWebAPI.Model
{
    public partial class Vendor
    {
        public Vendor()
        {
            Bookings = new HashSet<Booking>();
            Customers = new HashSet<Customer>();
            Orders = new HashSet<Order>();
            Products = new HashSet<Product>();
        }

        public int VendorId { get; set; }
        public int CategoryId { get; set; }
        public string VendorName { get; set; }
        public string VendorUsername { get; set; }
        public string Vpwd { get; set; }
        public decimal VendorPhone { get; set; }
        public string VendorEmail { get; set; }
        public string VendorAddress { get; set; }
        public string VendorCity { get; set; }
        public string VendorState { get; set; }
        public decimal VendorPincode { get; set; }
        public int VendorAccountBalance { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
