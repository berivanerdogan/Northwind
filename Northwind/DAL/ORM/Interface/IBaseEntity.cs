using Northwind.DAL.ORM.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.ORM.Interface
{
   public  class IBaseEntity
    {
        [Key]
        [Column(Order = 1)]
        int ID { get; set; }

        DateTime AddDate { get; set; }
        DateTime Delete { get; set; }
        DateTime Update { get; set; }
        Status Status { get; set; }


    }
}
