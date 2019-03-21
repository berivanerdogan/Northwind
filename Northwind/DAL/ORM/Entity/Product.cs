using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.ORM.Entity
{

    public class Product : BaseEntity
    {
        [MaxLength(40)]
        public string ProductName { get; set; }

        [MaxLength(20)]
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int MyProperty { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public string Discontinued { get; set; }

        public int ProductID { get; set; }
        public virtual OrderDetail OrderDetail{get; set;}

        public List<Category> Categories { get; set; }

        public List<Supplier> Suppliers { get; set; }

    }
}
