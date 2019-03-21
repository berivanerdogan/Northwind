using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.ORM.Entity
{
    public class Category:BaseEntity
    {
        [MaxLength(15)]
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public int CategoryID { get; set; }
        public virtual Product Product { get; set; }

    }
}
