using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.ORM.Entity
{
    public class OrderDetail:BaseEntity
    {
        public string UnitPrice { get; set; }
        public string Quantity { get; set; }
        public string Discount { get; set; }

        public int OrderID { get; set; }
        public virtual Order Order { get; set; }

        public List<Product> Products { get; set; }

    }
}
