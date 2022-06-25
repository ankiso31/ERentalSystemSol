using System;
using System.Collections.Generic;

#nullable disable

namespace ERentalWebAPI.Model
{
    public partial class Booking
    {
        public int BookingId { get; set; }
        public int ProductId { get; set; }
        public int VendorId { get; set; }
        public int CustomerId { get; set; }
        public string Pickupaddress { get; set; }
        public string Dropupaddress { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal CustomerPhone { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
