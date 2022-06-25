using System;
using System.Collections.Generic;

#nullable disable

namespace ERentalWebAPI.Model
{
    public partial class Customer
    {
        public Customer()
        {
            Bookings = new HashSet<Booking>();
            Orders = new HashSet<Order>();
        }

        public int CustomerId { get; set; }
        public string Customername { get; set; }
        public string CustomerUsername { get; set; }
        public string Customerpwd { get; set; }
        public int ProductId { get; set; }
        public int VendorId { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerState { get; set; }
        public decimal CustomerPincode { get; set; }
        public decimal CustomerAccountBalance { get; set; }
        public decimal CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }

        public virtual Product Product { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
