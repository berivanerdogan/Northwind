using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.ORM.Entity
{
    public class Region:BaseEntity
    {
        [MaxLength(50)]
        public string RegionDescrition { get; set; }

        public List<Territory> Territories { get; set; }
    }
}
