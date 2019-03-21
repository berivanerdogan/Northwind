using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.ORM.Entity
{
   public class Supplier:BaseAdressInfo
    {
        [MaxLength(40)]
        public string CompanyName { get; set; }

        [MaxLength(30)]
        public string ContactName { get; set; }

        [MaxLength(30)]
        public string ContactTitle { get; set; }

        [MaxLength(24)]
        public string PhoneNumber { get; set; }

       [MaxLength(24)]
        public string Fax { get; set; }
        public string HomePage { get; set; }

        public int SupplierID { get; set; }
        public virtual Product Product { get; set; }
    }
}
