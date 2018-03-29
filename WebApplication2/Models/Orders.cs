using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Orders
    {
        public int OrderID { get; set; }

        public int CustomerID { get; set; }

        public int EmployeeID { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime RequireDate { get; set; }

        public DateTime ShippedDate { get; set; }

        public int ShipperID { get; set; }

        public Nullable<Decimal> Freight { get; set; }

        public Char ShipAddress { get; set; }

        public Char ShipCity { get; set; }

        public Char ShipRegion { get; set; }

        public Char ShipPostalCode { get; set; }

        public Char ShipCountry { get; set; }

    }
}