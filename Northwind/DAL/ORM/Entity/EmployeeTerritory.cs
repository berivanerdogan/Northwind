using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.ORM.Entity
{
    public class EmployeeTerritory:BaseEntity
    {
        public List<Employee> Employees { get; set; }

        public int TerritoryID { get; set; }
        public virtual Territory Territory { get; set; }

    }
}
